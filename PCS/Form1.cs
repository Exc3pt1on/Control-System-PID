using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NationalInstruments.DAQmx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PCS
{
    public partial class Form1 : Form
    {
        private List<double> SensorValue = new List<double>();
        private List<double> FilteredValue = new List<double>();
        private List<DateTime> Timestamp = new List<DateTime>();
        private double Heat;
        public Form1()
        {
            InitializeComponent();
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
                chartTemp.Titles.Clear();
                chartTemp.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.DateTime;

                for (int i = 0; i < FilteredValue.Count; i++)
                {
                    series.Points.AddXY(Timestamp[i], FilteredValue[i]);
                }

                chartTemp.Titles.Add("Sensor readings");
                chartTemp.ChartAreas[0].AxisX.Title = "Time";
                chartTemp.ChartAreas[0].AxisY.Title = "Temperature °C";
                chartTemp.Series.Add(series);
                chartTemp.Refresh();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            double signal, temp, filtered;
            string channel, device;
            DateTime datetime = DateTime.Now;


            ///
            if (double.TryParse(txtHeat.Text, out double val))
            {
                Heat = val;
            }
            else
            {
                Heat = 0;
            }
            ///

            device = txtDevice.Text;
            channel = txtChannelIn.Text;
            signal = ReadDAQ(device, channel);
            temp = ConvertAnalogSignal(signal, 1, 5, 0, 50);
            SensorValue.Add(temp);
            Timestamp.Add(datetime);
            FilteredValue.Add(temp);

            filtered = MovingAverage(SensorValue);
            txtTemp.Text = filtered.ToString();
            WriteDAQ("dev3", "ao0", Heat);
            InsertIntoChart();

        }
    }
}
