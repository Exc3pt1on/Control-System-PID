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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblSimMode = new System.Windows.Forms.Label();
            this.btnSimMode = new System.Windows.Forms.Button();
            this.lblManual2 = new System.Windows.Forms.Label();
            this.txtFan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblP = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblAntiWindup = new System.Windows.Forms.Label();
            this.txtAntiWindup = new System.Windows.Forms.TextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.txtSetpoint = new System.Windows.Forms.TextBox();
            this.tabPID = new System.Windows.Forms.TabPage();
            this.lblUnitSetpoint = new System.Windows.Forms.Label();
            this.lblUnitFan = new System.Windows.Forms.Label();
            this.lblUnitHeat = new System.Windows.Forms.Label();
            this.lblUnitSimV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputSim = new System.Windows.Forms.TextBox();
            this.lblUnitRealV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputReal = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempSim)).BeginInit();
            this.tabPID.SuspendLayout();
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
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(182, 103);
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
            this.TabControl.Controls.Add(this.tabPID);
            this.TabControl.Location = new System.Drawing.Point(55, 55);
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
            this.tabPageControl.Controls.Add(this.lblUnitHeat);
            this.tabPageControl.Controls.Add(this.lblUnitFan);
            this.tabPageControl.Controls.Add(this.lblUnitSetpoint);
            this.tabPageControl.Controls.Add(this.lblSetpoint);
            this.tabPageControl.Controls.Add(this.txtSetpoint);
            this.tabPageControl.Controls.Add(this.lblSimMode);
            this.tabPageControl.Controls.Add(this.btnSimMode);
            this.tabPageControl.Controls.Add(this.lblManual2);
            this.tabPageControl.Controls.Add(this.txtFan);
            this.tabPageControl.Controls.Add(this.label1);
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
            // lblSimMode
            // 
            this.lblSimMode.AutoSize = true;
            this.lblSimMode.Location = new System.Drawing.Point(19, 47);
            this.lblSimMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSimMode.Name = "lblSimMode";
            this.lblSimMode.Size = new System.Drawing.Size(90, 13);
            this.lblSimMode.TabIndex = 31;
            this.lblSimMode.Text = "Simulation mode: ";
            // 
            // btnSimMode
            // 
            this.btnSimMode.Location = new System.Drawing.Point(114, 43);
            this.btnSimMode.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimMode.Name = "btnSimMode";
            this.btnSimMode.Size = new System.Drawing.Size(80, 19);
            this.btnSimMode.TabIndex = 30;
            this.btnSimMode.Text = "PID";
            this.btnSimMode.UseVisualStyleBackColor = true;
            this.btnSimMode.Click += new System.EventHandler(this.btnSimMode_Click);
            // 
            // lblManual2
            // 
            this.lblManual2.AutoSize = true;
            this.lblManual2.Location = new System.Drawing.Point(19, 132);
            this.lblManual2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManual2.Name = "lblManual2";
            this.lblManual2.Size = new System.Drawing.Size(117, 13);
            this.lblManual2.TabIndex = 29;
            this.lblManual2.Text = "Manual fan signal (0-5):";
            // 
            // txtFan
            // 
            this.txtFan.Location = new System.Drawing.Point(182, 129);
            this.txtFan.Margin = new System.Windows.Forms.Padding(2);
            this.txtFan.Name = "txtFan";
            this.txtFan.Size = new System.Drawing.Size(34, 20);
            this.txtFan.TabIndex = 28;
            this.txtFan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Simulation: ";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(114, 20);
            this.btnSim.Margin = new System.Windows.Forms.Padding(2);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(80, 19);
            this.btnSim.TabIndex = 26;
            this.btnSim.Text = "Off";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(160, 318);
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
            this.lblManual.Location = new System.Drawing.Point(19, 106);
            this.lblManual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(132, 13);
            this.lblManual.TabIndex = 24;
            this.lblManual.Text = "Manual heater signal (0-5):";
            // 
            // lblTempReal
            // 
            this.lblTempReal.AutoSize = true;
            this.lblTempReal.Location = new System.Drawing.Point(421, 42);
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
            chartArea9.Name = "ChartArea1";
            this.chartTempReal.ChartAreas.Add(chartArea9);
            this.chartTempReal.Location = new System.Drawing.Point(576, 39);
            this.chartTempReal.Margin = new System.Windows.Forms.Padding(2);
            this.chartTempReal.Name = "chartTempReal";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.chartTempReal.Series.Add(series9);
            this.chartTempReal.Size = new System.Drawing.Size(670, 297);
            this.chartTempReal.TabIndex = 23;
            this.chartTempReal.Text = "chart1";
            // 
            // chartTempSim
            // 
            chartArea10.Name = "ChartArea1";
            this.chartTempSim.ChartAreas.Add(chartArea10);
            this.chartTempSim.Location = new System.Drawing.Point(576, 362);
            this.chartTempSim.Margin = new System.Windows.Forms.Padding(2);
            this.chartTempSim.Name = "chartTempSim";
            series10.ChartArea = "ChartArea1";
            series10.Name = "Series1";
            this.chartTempSim.Series.Add(series10);
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
            this.lblTempSim.Location = new System.Drawing.Point(421, 365);
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
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(22, 35);
            this.lblP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 13);
            this.lblP.TabIndex = 33;
            this.lblP.Text = "P:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(185, 32);
            this.txtP.Margin = new System.Windows.Forms.Padding(2);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(34, 20);
            this.txtP.TabIndex = 32;
            this.txtP.Text = "2,97";
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(22, 60);
            this.lblI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(52, 13);
            this.lblI.TabIndex = 35;
            this.lblI.Text = "I (0 = off):";
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(185, 57);
            this.txtI.Margin = new System.Windows.Forms.Padding(2);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(34, 20);
            this.txtI.TabIndex = 34;
            this.txtI.Text = "9";
            this.txtI.TextChanged += new System.EventHandler(this.txtI_TextChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(22, 87);
            this.lblD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(57, 13);
            this.lblD.TabIndex = 37;
            this.lblD.Text = "D (0 = off):";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(185, 84);
            this.txtD.Margin = new System.Windows.Forms.Padding(2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(34, 20);
            this.txtD.TabIndex = 36;
            this.txtD.Text = "2,25";
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // lblAntiWindup
            // 
            this.lblAntiWindup.AutoSize = true;
            this.lblAntiWindup.Location = new System.Drawing.Point(22, 111);
            this.lblAntiWindup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntiWindup.Name = "lblAntiWindup";
            this.lblAntiWindup.Size = new System.Drawing.Size(106, 13);
            this.lblAntiWindup.TabIndex = 39;
            this.lblAntiWindup.Text = "I antiwindup (0 = off):";
            // 
            // txtAntiWindup
            // 
            this.txtAntiWindup.Location = new System.Drawing.Point(185, 108);
            this.txtAntiWindup.Margin = new System.Windows.Forms.Padding(2);
            this.txtAntiWindup.Name = "txtAntiWindup";
            this.txtAntiWindup.Size = new System.Drawing.Size(34, 20);
            this.txtAntiWindup.TabIndex = 38;
            this.txtAntiWindup.Text = "1000";
            this.txtAntiWindup.TextChanged += new System.EventHandler(this.txtAntiWindup_TextChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(22, 136);
            this.lblAlpha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(159, 13);
            this.lblAlpha.TabIndex = 41;
            this.lblAlpha.Text = "Derivate filter (0-1 where 1 is off)";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(185, 133);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(34, 20);
            this.txtAlpha.TabIndex = 40;
            this.txtAlpha.Text = "0.1";
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Location = new System.Drawing.Point(19, 203);
            this.lblSetpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(49, 13);
            this.lblSetpoint.TabIndex = 43;
            this.lblSetpoint.Text = "Setpoint:";
            // 
            // txtSetpoint
            // 
            this.txtSetpoint.Location = new System.Drawing.Point(182, 200);
            this.txtSetpoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetpoint.Name = "txtSetpoint";
            this.txtSetpoint.Size = new System.Drawing.Size(34, 20);
            this.txtSetpoint.TabIndex = 42;
            this.txtSetpoint.Text = "28";
            this.txtSetpoint.TextChanged += new System.EventHandler(this.txtSetpoint_TextChanged);
            // 
            // tabPID
            // 
            this.tabPID.Controls.Add(this.lblAlpha);
            this.tabPID.Controls.Add(this.txtAlpha);
            this.tabPID.Controls.Add(this.txtP);
            this.tabPID.Controls.Add(this.lblP);
            this.tabPID.Controls.Add(this.txtI);
            this.tabPID.Controls.Add(this.lblAntiWindup);
            this.tabPID.Controls.Add(this.lblI);
            this.tabPID.Controls.Add(this.txtD);
            this.tabPID.Controls.Add(this.txtAntiWindup);
            this.tabPID.Controls.Add(this.lblD);
            this.tabPID.Location = new System.Drawing.Point(4, 22);
            this.tabPID.Name = "tabPID";
            this.tabPID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPID.Size = new System.Drawing.Size(268, 348);
            this.tabPID.TabIndex = 2;
            this.tabPID.Text = "PID";
            this.tabPID.UseVisualStyleBackColor = true;
            // 
            // lblUnitSetpoint
            // 
            this.lblUnitSetpoint.AutoSize = true;
            this.lblUnitSetpoint.Location = new System.Drawing.Point(220, 203);
            this.lblUnitSetpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitSetpoint.Name = "lblUnitSetpoint";
            this.lblUnitSetpoint.Size = new System.Drawing.Size(18, 13);
            this.lblUnitSetpoint.TabIndex = 28;
            this.lblUnitSetpoint.Text = "°C";
            // 
            // lblUnitFan
            // 
            this.lblUnitFan.AutoSize = true;
            this.lblUnitFan.Location = new System.Drawing.Point(220, 132);
            this.lblUnitFan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitFan.Name = "lblUnitFan";
            this.lblUnitFan.Size = new System.Drawing.Size(14, 13);
            this.lblUnitFan.TabIndex = 44;
            this.lblUnitFan.Text = "V";
            // 
            // lblUnitHeat
            // 
            this.lblUnitHeat.AutoSize = true;
            this.lblUnitHeat.Location = new System.Drawing.Point(220, 106);
            this.lblUnitHeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitHeat.Name = "lblUnitHeat";
            this.lblUnitHeat.Size = new System.Drawing.Size(14, 13);
            this.lblUnitHeat.TabIndex = 45;
            this.lblUnitHeat.Text = "V";
            // 
            // lblUnitSimV
            // 
            this.lblUnitSimV.AutoSize = true;
            this.lblUnitSimV.Location = new System.Drawing.Point(532, 389);
            this.lblUnitSimV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitSimV.Name = "lblUnitSimV";
            this.lblUnitSimV.Size = new System.Drawing.Size(14, 13);
            this.lblUnitSimV.TabIndex = 30;
            this.lblUnitSimV.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Input (Heat u):";
            // 
            // txtInputSim
            // 
            this.txtInputSim.Location = new System.Drawing.Point(492, 386);
            this.txtInputSim.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputSim.Name = "txtInputSim";
            this.txtInputSim.Size = new System.Drawing.Size(37, 20);
            this.txtInputSim.TabIndex = 28;
            // 
            // lblUnitRealV
            // 
            this.lblUnitRealV.AutoSize = true;
            this.lblUnitRealV.Location = new System.Drawing.Point(532, 66);
            this.lblUnitRealV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitRealV.Name = "lblUnitRealV";
            this.lblUnitRealV.Size = new System.Drawing.Size(14, 13);
            this.lblUnitRealV.TabIndex = 33;
            this.lblUnitRealV.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Input (Heat u):";
            // 
            // txtInputReal
            // 
            this.txtInputReal.Location = new System.Drawing.Point(492, 63);
            this.txtInputReal.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputReal.Name = "txtInputReal";
            this.txtInputReal.Size = new System.Drawing.Size(37, 20);
            this.txtInputReal.TabIndex = 31;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1362, 726);
            this.Controls.Add(this.lblUnitRealV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInputReal);
            this.Controls.Add(this.lblUnitSimV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputSim);
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
            this.tabPID.ResumeLayout(false);
            this.tabPID.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblManual2;
        private System.Windows.Forms.TextBox txtFan;
        private System.Windows.Forms.Label lblSimMode;
        private System.Windows.Forms.Button btnSimMode;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lblAntiWindup;
        private System.Windows.Forms.TextBox txtAntiWindup;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TabPage tabPID;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.TextBox txtSetpoint;
        private System.Windows.Forms.Label lblUnitHeat;
        private System.Windows.Forms.Label lblUnitFan;
        private System.Windows.Forms.Label lblUnitSetpoint;
        private System.Windows.Forms.Label lblUnitSimV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputSim;
        private System.Windows.Forms.Label lblUnitRealV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputReal;
    }
}

