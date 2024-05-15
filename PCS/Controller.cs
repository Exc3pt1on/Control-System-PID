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
        /*
         Notes
        Ultimate gain simulation = 4,95
        Tu = 18
        PID: 
        Kp = 0.6*Ku = 2,97
        Ti = 0.5*Tu = 9
        Td = 0.125*Tu = 2,25


         */
        private List<double> SensorValue = new List<double>();
        private List<double> FilteredValue = new List<double>();
        private List<double> SimValue = new List<double>();
        private List<double> FilteredSim = new List<double>();
        private List<DateTime> Timestamp = new List<DateTime>();
        private List<DateTime> TimestampSim = new List<DateTime>();
        private double Heat = 0;
        private double Setpoint = 0;
        PID PidControllerSim = new PID();
        PID PidControllerReal = new PID();
        OpcHandler opcHandler = new OpcHandler();
        Simulation Sim;
        private bool Connected = false;
        private bool Running = false;
        private bool Simulating = false;
        private bool Manual = false;
        public Controller()
        {
            InitializeComponent();
            opcHandler.AddNode("Temperature");
            opcHandler.AddNode("Heat");
            opcHandler.AddNode("Fan");
            Thread serverThread = new Thread(opcHandler.StartOpcUaServer);
            serverThread.Start();

            double a = 0.9488;
            double[] b = { 0.24, -0.0433 };
            double c = 0.4894;
            double initialState = 52.9864;

            Setpoint = Convert.ToDouble(txtSetpoint.Text);
            Sim = new Simulation(a, b, c, initialState);
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
                if (Connected)
                {
                    chartTempReal.Titles.Clear();
                    chartTempReal.Series.Clear();
                    Series series = new Series();
                    series.ChartType = SeriesChartType.Line;
                    //series.XValueType = ChartValueType.DateTime;

                    for (int i = 0; i < FilteredValue.Count; i++)
                    {
                        series.Points.AddXY(i, FilteredValue[i]); //Timestamp[i]
                    }


                    chartTempReal.Titles.Add("Sensor readings");
                    chartTempReal.ChartAreas[0].AxisX.Title = "Time";
                    chartTempReal.ChartAreas[0].AxisY.Title = "Temperature °C";
                    chartTempReal.Series.Add(series);
                    chartTempReal.Refresh();
                }

                if (Simulating)
                {
                    chartTempSim.Titles.Clear();
                    chartTempSim.Series.Clear();
                    Series series = new Series();
                    series.ChartType = SeriesChartType.Line;
                    //series.XValueType = ChartValueType.DateTime;

                    for (int i = 0; i < FilteredSim.Count; i++)
                    {
                        series.Points.AddXY(i, FilteredSim[i]); //TimestampSim[i]
                    }

                    chartTempSim.Titles.Add("Sensor readings");
                    chartTempSim.ChartAreas[0].AxisX.Title = "Time";
                    chartTempSim.ChartAreas[0].AxisY.Title = "Temperature °C";
                    chartTempSim.Series.Add(series);
                    chartTempSim.Refresh();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdatePidParameters()
        {
            double kp, ti, td, windup;
            try
            {
                kp = Convert.ToDouble(txtP.Text);
                ti = Convert.ToDouble(txtI.Text);
                td = Convert.ToDouble(txtD.Text);
                windup = Convert.ToDouble(txtAntiWindup.Text);

                PidControllerSim.Kp = kp;

                PidControllerReal.Kp = kp;

                if (ti <= 0)
                {
                    ti = double.MaxValue;
                }
                PidControllerSim.Ti = ti;
                PidControllerSim.Td = td;
                PidControllerSim.antiWindup = windup;

                PidControllerReal.Ti = ti;
                PidControllerReal.Td = td;
                PidControllerReal.antiWindup = windup;
            }
            catch (Exception)
            {
                MessageBox.Show("PID parameters must be of type double");
            }
        }


        private void tmr1_Tick(object sender, EventArgs e)
        {
            double signal, temp = 0, filtered, tempSim = 0, filteredSim = 0, fanMan, heatMan;
            double fan = 0;
            string channel, device;
            double[] inputs = new double[2];
            DateTime datetime = DateTime.Now;


            ///
            if (Simulating)
            {
                if (Manual)
                {
                    if (double.TryParse(txtHeat.Text, out double heatD))
                    {
                        heatMan = heatD;
                    }
                    else { heatMan = 0; }

                    if (double.TryParse(txtFan.Text, out double fanD))
                    {
                        fanMan = fanD;
                    }
                    else { fanMan = 0; }

                    inputs[0] = heatMan;
                    inputs[1] = fanMan;
                }
                else
                {
                    // PID run for simulation
                    double previousTemp;
                    try
                    {
                        previousTemp = FilteredSim[FilteredSim.Count - 1];
                    }
                    catch (Exception)
                    {
                        previousTemp = 2;
                    }

                    inputs[0] = Math.Max(Math.Min(PidControllerSim.NextU(previousTemp, Setpoint, 1), 5), 0);
                    inputs[1] = 5;
                }
                txtInputSim.Text = inputs[0].ToString("0.##");
                tempSim = Sim.UpdateSimulation(inputs, 1);
                SimValue.Add(tempSim);
                TimestampSim.Add(datetime);
                filteredSim = MovingAverage(SimValue);
                FilteredSim.Add(filteredSim);

                txtTempSim.Text = filteredSim.ToString("0.##");

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

                Heat = Math.Max(Math.Min(PidControllerReal.NextU(temp, Setpoint, 1), 5), 0);

                WriteDAQ("dev3", "ao0", Heat);

                SensorValue.Add(temp);
                Timestamp.Add(datetime);
                filtered = MovingAverage(SensorValue);
                FilteredValue.Add(filtered);

                opcHandler.UpdateNodeValue("Temperature", filtered);
                opcHandler.UpdateNodeValue("Fan", fan);
                opcHandler.UpdateNodeValue("Heat", Heat);

                txtTempReal.Text = filtered.ToString("0.##");
                txtInputReal.Text = Heat.ToString("0.##");
            }
            else
            {
                opcHandler.UpdateNodeValue("Temperature", filteredSim);
                opcHandler.UpdateNodeValue("Fan", inputs[1]);
                opcHandler.UpdateNodeValue("Heat", inputs[0]);

            }

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
            UpdatePidParameters();

            if (Running)
            {
                tmr1.Stop();
                btnStart.Text = "Start";
                Running = false;
            }
            else
            {
                tmr1.Start();
                btnStart.Text = "Stop";
                Running = true;
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            // Turn simulation on or off
            if (Simulating)
            {
                Simulating = false;
                btnSim.Text = "Off";
            }
            else
            {
                Simulating = true;
                btnSim.Text = "On";
            }
        }

        private void btnSimMode_Click(object sender, EventArgs e)
        {
            if (Manual)
            {
                Manual = false;
                btnSimMode.Text = "PID";
            }
            else
            {
                Manual = true;
                btnSimMode.Text = "Manual";
            }
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            UpdatePidParameters();
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            UpdatePidParameters();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            UpdatePidParameters();
        }

        private void txtAntiWindup_TextChanged(object sender, EventArgs e)
        {
            UpdatePidParameters();
        }

        private void txtSetpoint_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSetpoint.Text, out double setpoint))
            {
                Setpoint = setpoint;
            }
        }
    }
}
