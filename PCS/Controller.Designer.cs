namespace PCS
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtTempReal = new System.Windows.Forms.TextBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.lblConnect = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblChannelOut = new System.Windows.Forms.Label();
            this.txtChannelOut = new System.Windows.Forms.TextBox();
            this.lblChannelIn = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtChannelIn = new System.Windows.Forms.TextBox();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblTempReal = new System.Windows.Forms.Label();
            this.lblUnitReal = new System.Windows.Forms.Label();
            this.chartTempReal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTempSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUnitSim = new System.Windows.Forms.Label();
            this.lblTempSim = new System.Windows.Forms.Label();
            this.txtTempSim = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempSim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempReal
            // 
            this.txtTempReal.Location = new System.Drawing.Point(492, 39);
            this.txtTempReal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempReal.Name = "txtTempReal";
            this.txtTempReal.Size = new System.Drawing.Size(37, 20);
            this.txtTempReal.TabIndex = 0;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 500;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(160, 50);
            this.txtHeat.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(34, 20);
            this.txtHeat.TabIndex = 1;
            this.txtHeat.Text = "0";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageDevice);
            this.TabControl.Controls.Add(this.tabPageControl);
            this.TabControl.Location = new System.Drawing.Point(58, 54);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(276, 374);
            this.TabControl.TabIndex = 3;
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.Controls.Add(this.lblConnect);
            this.tabPageDevice.Controls.Add(this.btnConnect);
            this.tabPageDevice.Controls.Add(this.lblChannelOut);
            this.tabPageDevice.Controls.Add(this.txtChannelOut);
            this.tabPageDevice.Controls.Add(this.lblChannelIn);
            this.tabPageDevice.Controls.Add(this.lblDevice);
            this.tabPageDevice.Controls.Add(this.txtDevice);
            this.tabPageDevice.Controls.Add(this.txtChannelIn);
            this.tabPageDevice.Location = new System.Drawing.Point(4, 22);
            this.tabPageDevice.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDevice.Size = new System.Drawing.Size(268, 348);
            this.tabPageDevice.TabIndex = 0;
            this.tabPageDevice.Text = "Device";
            this.tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.BackColor = System.Drawing.Color.Transparent;
            this.lblConnect.ForeColor = System.Drawing.Color.Red;
            this.lblConnect.Location = new System.Drawing.Point(30, 93);
            this.lblConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(79, 13);
            this.lblConnect.TabIndex = 28;
            this.lblConnect.Text = "Not Connected";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(106, 91);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 19);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblChannelOut
            // 
            this.lblChannelOut.AutoSize = true;
            this.lblChannelOut.Location = new System.Drawing.Point(42, 69);
            this.lblChannelOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChannelOut.Name = "lblChannelOut";
            this.lblChannelOut.Size = new System.Drawing.Size(67, 13);
            this.lblChannelOut.TabIndex = 27;
            this.lblChannelOut.Text = "Channel out:";
            // 
            // txtChannelOut
            // 
            this.txtChannelOut.Location = new System.Drawing.Point(106, 69);
            this.txtChannelOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtChannelOut.Name = "txtChannelOut";
            this.txtChannelOut.Size = new System.Drawing.Size(76, 20);
            this.txtChannelOut.TabIndex = 26;
            this.txtChannelOut.Text = "ao0";
            // 
            // lblChannelIn
            // 
            this.lblChannelIn.AutoSize = true;
            this.lblChannelIn.Location = new System.Drawing.Point(48, 46);
            this.lblChannelIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChannelIn.Name = "lblChannelIn";
            this.lblChannelIn.Size = new System.Drawing.Size(60, 13);
            this.lblChannelIn.TabIndex = 25;
            this.lblChannelIn.Text = "Channel in:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(62, 26);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 24;
            this.lblDevice.Text = "Device:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(106, 24);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(76, 20);
            this.txtDevice.TabIndex = 4;
            this.txtDevice.Text = "dev3";
            // 
            // txtChannelIn
            // 
            this.txtChannelIn.Location = new System.Drawing.Point(106, 46);
            this.txtChannelIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtChannelIn.Name = "txtChannelIn";
            this.txtChannelIn.Size = new System.Drawing.Size(76, 20);
            this.txtChannelIn.TabIndex = 3;
            this.txtChannelIn.Text = "ai0";
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.btnSim);
            this.tabPageControl.Controls.Add(this.btnStart);
            this.tabPageControl.Controls.Add(this.lblManual);
            this.tabPageControl.Controls.Add(this.txtHeat);
            this.tabPageControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageControl.Size = new System.Drawing.Size(268, 348);
            this.tabPageControl.TabIndex = 1;
            this.tabPageControl.Text = "Control";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(148, 120);
            this.btnSim.Margin = new System.Windows.Forms.Padding(2);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(80, 19);
            this.btnSim.TabIndex = 26;
            this.btnSim.Text = "Simulate input";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(160, 86);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(19, 52);
            this.lblManual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(138, 13);
            this.lblManual.TabIndex = 24;
            this.lblManual.Text = "Manual heater signal (0-5v):";
            // 
            // lblTempReal
            // 
            this.lblTempReal.AutoSize = true;
            this.lblTempReal.Location = new System.Drawing.Point(424, 42);
            this.lblTempReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempReal.Name = "lblTempReal";
            this.lblTempReal.Size = new System.Drawing.Size(67, 13);
            this.lblTempReal.TabIndex = 4;
            this.lblTempReal.Text = "Temperature";
            // 
            // lblUnitReal
            // 
            this.lblUnitReal.AutoSize = true;
            this.lblUnitReal.Location = new System.Drawing.Point(532, 42);
            this.lblUnitReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitReal.Name = "lblUnitReal";
            this.lblUnitReal.Size = new System.Drawing.Size(18, 13);
            this.lblUnitReal.TabIndex = 5;
            this.lblUnitReal.Text = "°C";
            // 
            // chartTempReal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTempReal.ChartAreas.Add(chartArea1);
            this.chartTempReal.Location = new System.Drawing.Point(576, 39);
            this.chartTempReal.Margin = new System.Windows.Forms.Padding(2);
            this.chartTempReal.Name = "chartTempReal";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartTempReal.Series.Add(series1);
            this.chartTempReal.Size = new System.Drawing.Size(670, 297);
            this.chartTempReal.TabIndex = 23;
            this.chartTempReal.Text = "chart1";
            // 
            // chartTempSim
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTempSim.ChartAreas.Add(chartArea2);
            this.chartTempSim.Location = new System.Drawing.Point(576, 362);
            this.chartTempSim.Margin = new System.Windows.Forms.Padding(2);
            this.chartTempSim.Name = "chartTempSim";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartTempSim.Series.Add(series2);
            this.chartTempSim.Size = new System.Drawing.Size(670, 297);
            this.chartTempSim.TabIndex = 24;
            this.chartTempSim.Text = "chart1";
            // 
            // lblUnitSim
            // 
            this.lblUnitSim.AutoSize = true;
            this.lblUnitSim.Location = new System.Drawing.Point(532, 365);
            this.lblUnitSim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitSim.Name = "lblUnitSim";
            this.lblUnitSim.Size = new System.Drawing.Size(18, 13);
            this.lblUnitSim.TabIndex = 27;
            this.lblUnitSim.Text = "°C";
            // 
            // lblTempSim
            // 
            this.lblTempSim.AutoSize = true;
            this.lblTempSim.Location = new System.Drawing.Point(424, 365);
            this.lblTempSim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempSim.Name = "lblTempSim";
            this.lblTempSim.Size = new System.Drawing.Size(67, 13);
            this.lblTempSim.TabIndex = 26;
            this.lblTempSim.Text = "Temperature";
            // 
            // txtTempSim
            // 
            this.txtTempSim.Location = new System.Drawing.Point(492, 362);
            this.txtTempSim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempSim.Name = "txtTempSim";
            this.txtTempSim.Size = new System.Drawing.Size(37, 20);
            this.txtTempSim.TabIndex = 25;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1362, 726);
            this.Controls.Add(this.lblUnitSim);
            this.Controls.Add(this.lblTempSim);
            this.Controls.Add(this.txtTempSim);
            this.Controls.Add(this.chartTempSim);
            this.Controls.Add(this.chartTempReal);
            this.Controls.Add(this.lblUnitReal);
            this.Controls.Add(this.lblTempReal);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.txtTempReal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Controller";
            this.Text = "Controller";
            this.TabControl.ResumeLayout(false);
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            this.tabPageControl.ResumeLayout(false);
            this.tabPageControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempReal;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.Label lblTempReal;
        private System.Windows.Forms.Label lblUnitReal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempReal;
        private System.Windows.Forms.Label lblChannelOut;
        private System.Windows.Forms.TextBox txtChannelOut;
        private System.Windows.Forms.Label lblChannelIn;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtChannelIn;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempSim;
        private System.Windows.Forms.Label lblUnitSim;
        private System.Windows.Forms.Label lblTempSim;
        private System.Windows.Forms.TextBox txtTempSim;
    }
}

