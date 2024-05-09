using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NationalInstruments.DAQmx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Opc.UaFx;
using Opc.UaFx.Server;
using System.Threading;
using Opc.UaFx.Client;
using Opc.Ua;
using System.Drawing;

namespace PCS
{
    public partial class Controller : Form
    {
        private List<double> SensorValue = new List<double>();
        private List<double> FilteredValue = new List<double>();
        private List<DateTime> Timestamp = new List<DateTime>();
        private double Heat = 0;
        OpcHandler opcHandler = new OpcHandler();
        private bool Connected = false;
        private bool Running = false;
        private bool Simulating = false;
        public Controller()
        {
            InitializeComponent();
            opcHandler.AddNode("Temperature");
            opcHandler.AddNode("Heat");
            opcHandler.AddNode("Fan");
            Thread serverThread = new Thread(opcHandler.StartOpcUaServer);
            serverThread.Start();
        }

        private bool CheckConnectionDAQ(string sensor, string channel)
        {
            try
            {
                // Attempt to read a value from the DAQmx sensor
                ReadDAQ(sensor, channel);
                return true;
            }
            catch (Exception)
            {
                // If an exception is thrown, the device is not connected
                return false;
            }
        }
        private double ReadDAQ(string sensor, string channel)
        {
            // Method for reading the DAQmx sensor

            double value;
            string sensorName;
            sensorName = sensor + "/" + channel;

            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            analogInTask.AIChannels.CreateVoltageChannel(sensorName, "myAIChannel", AITerminalConfiguration.Rse, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            value = reader.ReadSingleSample();
            return value;
        }

        private void WriteDAQ(string sensor, string channel, double value)
        {
            // Method for reading the DAQmx sensor

            string sensorName;
            sensorName = sensor + "/" + channel;

            NationalInstruments.DAQmx.Task analogOutTask = new NationalInstruments.DAQmx.Task();
            analogOutTask.AOChannels.CreateVoltageChannel(sensorName, "myAIChannel", 0, 5, AOVoltageUnits.Volts);
            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogOutTask.Stream);

            writer.WriteSingleSample(true, value);
        }

        private double MovingAverage(List<double> data, int windowSize = 10)
        {
            // Method for filtering the analog signals
            // This method is a copy from Software engineering assignment 1
            double result;

            int start = Math.Max(0, data.Count - windowSize);
            int end = data.Count;

            // Calculate the average of the values in the window
            double sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += data[i];
            }
            result = sum / (end - start);

            return Math.Round(result, 2);
        }

        private double ConvertAnalogSignal(double Signal, double SignalLow = 1, double SignalHigh = 5, double ValueLow = 0, double ValueHigh = 50)
        {
            // Convert e.g. voltage to temperature (from 1-5V to 0-50C)
            return (Signal - SignalLow) * (ValueHigh - ValueLow) / (SignalHigh - SignalLow);
        }

        private void InsertIntoChart()
        {
            // Method for inserting sensor values into chart
            try
            {
                chartTempReal.Titles.Clear();
                chartTempReal.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.DateTime;

                for (int i = 0; i < FilteredValue.Count; i++)
                {
                    series.Points.AddXY(Timestamp[i], FilteredValue[i]);
                }

                chartTempReal.Titles.Add("Sensor readings");
                chartTempReal.ChartAreas[0].AxisX.Title = "Time";
                chartTempReal.ChartAreas[0].AxisY.Title = "Temperature °C";
                chartTempReal.Series.Add(series);
                chartTempReal.Refresh();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void simulate(int id)
        {
            switch (id)
            {
                case 1: //pwm 50% 2sec
                    while (Simulating)
                    {
                        if (Heat == 0)
                        {
                            Heat = 5;
                        }
                        else
                        {
                            Heat = 0;
                        }
                        Thread.Sleep(2000);
                    }
                    break;
                case 2:
                    Random rnd = new Random();
                    double heatChange;
                    Heat = 2.5;
                    while (Simulating)
                    {
                        heatChange = (rnd.NextDouble() * 2) - 1;
                        Heat += heatChange;
                        Heat = Math.Min(Heat, 5);
                        Heat = Math.Max(Heat, 0);
                        Thread.Sleep(500);
                    }
                    break;
                default:
                    break;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            double signal, temp, filtered;
            double fan = 0;
            string channel, device;
            DateTime datetime = DateTime.Now;


            ///
            if (Simulating == false)
            {
                if (double.TryParse(txtHeat.Text, out double val))
                {
                    Heat = val;
                }
                else
                {
                    Heat = 0;
                }
            }

            ///

            //get temperature from sensor or manually written in txtTemp
            if (Connected)
            {
                device = txtDevice.Text;
                channel = txtChannelIn.Text;
                fan = ReadDAQ(device, "ai1");
                signal = ReadDAQ(device, channel);
                temp = ConvertAnalogSignal(signal, 1, 5, 0, 50);
                WriteDAQ("dev3", "ao0", Heat);
            }
            else
            {
                if (double.TryParse(txtTempReal.Text, out double value))
                {
                    temp = value;
                }
                else
                {
                    temp = 0;
                }
            }


            SensorValue.Add(temp);
            Timestamp.Add(datetime);
            filtered = MovingAverage(SensorValue);
            FilteredValue.Add(filtered);

            opcHandler.UpdateNodeValue("Temperature", filtered);
            opcHandler.UpdateNodeValue("Fan", fan);
            opcHandler.UpdateNodeValue("Heat", Heat);

            txtTempReal.Text = filtered.ToString();
            InsertIntoChart();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string sensor, channel;
            sensor = txtDevice.Text;
            channel = txtChannelIn.Text;
            if (CheckConnectionDAQ(sensor, channel))
            {
                Connected = true;
                lblConnect.Text = "Connected";
                lblConnect.ForeColor = Color.Green;
                btnConnect.Text = "Disconnect";
            }
            else
            {
                Connected = false;
                lblConnect.Text = "Not Connected";
                lblConnect.ForeColor = Color.Red;
                btnConnect.Text = "Connect";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                tmr1.Stop();
            }
            else
            {
                tmr1.Start();
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Simulation id
            int id = 2;
            if (Simulating)
            {
                Simulating = false;
            }
            else
            {
                Simulating = true;
                Thread sim = new Thread(() => simulate(id));
                sim.Start();
            }

        }


    }
}
