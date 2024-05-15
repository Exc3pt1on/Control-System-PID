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
            this.lblUnitHeat = new System.Windows.Forms.Label();
            this.lblUnitFan = new System.Windows.Forms.Label();
            this.lblUnitSetpoint = new System.Windows.Forms.Label();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.txtSetpoint = new System.Windows.Forms.TextBox();
            this.lblSimMode = new System.Windows.Forms.Label();
            this.btnSimMode = new System.Windows.Forms.Button();
            this.lblManual2 = new System.Windows.Forms.Label();
            this.txtFan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblManual = new System.Windows.Forms.Label();
            this.tabPID = new System.Windows.Forms.TabPage();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.lblAntiWindup = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtAntiWindup = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.lblMaxChartYSim = new System.Windows.Forms.Label();
            this.txtChartYmaxSim = new System.Windows.Forms.TextBox();
            this.lblMinChartYsim = new System.Windows.Forms.Label();
            this.txtChartYminSim = new System.Windows.Forms.TextBox();
            this.lblLimitTemp = new System.Windows.Forms.Label();
            this.btnLimitTemp = new System.Windows.Forms.Button();
            this.lblChartYmax = new System.Windows.Forms.Label();
            this.txtChartYmax = new System.Windows.Forms.TextBox();
            this.lblChartYmin = new System.Windows.Forms.Label();
            this.txtChartYmin = new System.Windows.Forms.TextBox();
            this.lblTempReal = new System.Windows.Forms.Label();
            this.lblUnitReal = new System.Windows.Forms.Label();
            this.chartTempReal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTempSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUnitSim = new System.Windows.Forms.Label();
            this.lblTempSim = new System.Windows.Forms.Label();
            this.txtTempSim = new System.Windows.Forms.TextBox();
            this.lblUnitSimV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputSim = new System.Windows.Forms.TextBox();
            this.lblUnitRealV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputReal = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            this.tabPID.SuspendLayout();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempSim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempReal
            // 
            this.txtTempReal.Location = new System.Drawing.Point(656, 48);
            this.txtTempReal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempReal.Name = "txtTempReal";
            this.txtTempReal.Size = new System.Drawing.Size(48, 22);
            this.txtTempReal.TabIndex = 0;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(243, 127);
            this.txtHeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(44, 22);
            this.txtHeat.TabIndex = 1;
            this.txtHeat.Text = "0";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageDevice);
            this.TabControl.Controls.Add(this.tabPageControl);
            this.TabControl.Controls.Add(this.tabPID);
            this.TabControl.Controls.Add(this.tabChart);
            this.TabControl.Location = new System.Drawing.Point(73, 68);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(368, 460);
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
            this.tabPageDevice.Location = new System.Drawing.Point(4, 25);
            this.tabPageDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDevice.Size = new System.Drawing.Size(360, 431);
            this.tabPageDevice.TabIndex = 0;
            this.tabPageDevice.Text = "Device";
            this.tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.BackColor = System.Drawing.Color.Transparent;
            this.lblConnect.ForeColor = System.Drawing.Color.Red;
            this.lblConnect.Location = new System.Drawing.Point(40, 114);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(96, 16);
            this.lblConnect.TabIndex = 28;
            this.lblConnect.Text = "Not Connected";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(141, 112);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblChannelOut
            // 
            this.lblChannelOut.AutoSize = true;
            this.lblChannelOut.Location = new System.Drawing.Point(56, 85);
            this.lblChannelOut.Name = "lblChannelOut";
            this.lblChannelOut.Size = new System.Drawing.Size(80, 16);
            this.lblChannelOut.TabIndex = 27;
            this.lblChannelOut.Text = "Channel out:";
            // 
            // txtChannelOut
            // 
            this.txtChannelOut.Location = new System.Drawing.Point(141, 85);
            this.txtChannelOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChannelOut.Name = "txtChannelOut";
            this.txtChannelOut.Size = new System.Drawing.Size(100, 22);
            this.txtChannelOut.TabIndex = 26;
            this.txtChannelOut.Text = "ao0";
            // 
            // lblChannelIn
            // 
            this.lblChannelIn.AutoSize = true;
            this.lblChannelIn.Location = new System.Drawing.Point(64, 57);
            this.lblChannelIn.Name = "lblChannelIn";
            this.lblChannelIn.Size = new System.Drawing.Size(72, 16);
            this.lblChannelIn.TabIndex = 25;
            this.lblChannelIn.Text = "Channel in:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(83, 32);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(53, 16);
            this.lblDevice.TabIndex = 24;
            this.lblDevice.Text = "Device:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(141, 30);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(100, 22);
            this.txtDevice.TabIndex = 4;
            this.txtDevice.Text = "dev3";
            // 
            // txtChannelIn
            // 
            this.txtChannelIn.Location = new System.Drawing.Point(141, 57);
            this.txtChannelIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChannelIn.Name = "txtChannelIn";
            this.txtChannelIn.Size = new System.Drawing.Size(100, 22);
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
            this.tabPageControl.Location = new System.Drawing.Point(4, 25);
            this.tabPageControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageControl.Size = new System.Drawing.Size(360, 431);
            this.tabPageControl.TabIndex = 1;
            this.tabPageControl.Text = "Control";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // lblUnitHeat
            // 
            this.lblUnitHeat.AutoSize = true;
            this.lblUnitHeat.Location = new System.Drawing.Point(293, 130);
            this.lblUnitHeat.Name = "lblUnitHeat";
            this.lblUnitHeat.Size = new System.Drawing.Size(16, 16);
            this.lblUnitHeat.TabIndex = 45;
            this.lblUnitHeat.Text = "V";
            // 
            // lblUnitFan
            // 
            this.lblUnitFan.AutoSize = true;
            this.lblUnitFan.Location = new System.Drawing.Point(293, 162);
            this.lblUnitFan.Name = "lblUnitFan";
            this.lblUnitFan.Size = new System.Drawing.Size(16, 16);
            this.lblUnitFan.TabIndex = 44;
            this.lblUnitFan.Text = "V";
            // 
            // lblUnitSetpoint
            // 
            this.lblUnitSetpoint.AutoSize = true;
            this.lblUnitSetpoint.Location = new System.Drawing.Point(293, 250);
            this.lblUnitSetpoint.Name = "lblUnitSetpoint";
            this.lblUnitSetpoint.Size = new System.Drawing.Size(20, 16);
            this.lblUnitSetpoint.TabIndex = 28;
            this.lblUnitSetpoint.Text = "°C";
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Location = new System.Drawing.Point(25, 250);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(59, 16);
            this.lblSetpoint.TabIndex = 43;
            this.lblSetpoint.Text = "Setpoint:";
            // 
            // txtSetpoint
            // 
            this.txtSetpoint.Location = new System.Drawing.Point(243, 246);
            this.txtSetpoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetpoint.Name = "txtSetpoint";
            this.txtSetpoint.Size = new System.Drawing.Size(44, 22);
            this.txtSetpoint.TabIndex = 42;
            this.txtSetpoint.Text = "28";
            this.txtSetpoint.TextChanged += new System.EventHandler(this.txtSetpoint_TextChanged);
            // 
            // lblSimMode
            // 
            this.lblSimMode.AutoSize = true;
            this.lblSimMode.Location = new System.Drawing.Point(25, 58);
            this.lblSimMode.Name = "lblSimMode";
            this.lblSimMode.Size = new System.Drawing.Size(113, 16);
            this.lblSimMode.TabIndex = 31;
            this.lblSimMode.Text = "Simulation mode: ";
            // 
            // btnSimMode
            // 
            this.btnSimMode.Location = new System.Drawing.Point(152, 53);
            this.btnSimMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimMode.Name = "btnSimMode";
            this.btnSimMode.Size = new System.Drawing.Size(107, 23);
            this.btnSimMode.TabIndex = 30;
            this.btnSimMode.Text = "PID";
            this.btnSimMode.UseVisualStyleBackColor = true;
            this.btnSimMode.Click += new System.EventHandler(this.btnSimMode_Click);
            // 
            // lblManual2
            // 
            this.lblManual2.AutoSize = true;
            this.lblManual2.Location = new System.Drawing.Point(25, 162);
            this.lblManual2.Name = "lblManual2";
            this.lblManual2.Size = new System.Drawing.Size(153, 16);
            this.lblManual2.TabIndex = 29;
            this.lblManual2.Text = "Manual fan signal (2,3-5):";
            // 
            // txtFan
            // 
            this.txtFan.Location = new System.Drawing.Point(243, 159);
            this.txtFan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFan.Name = "txtFan";
            this.txtFan.Size = new System.Drawing.Size(44, 22);
            this.txtFan.TabIndex = 28;
            this.txtFan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Simulation: ";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(152, 24);
            this.btnSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(107, 23);
            this.btnSim.TabIndex = 26;
            this.btnSim.Text = "Off";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(213, 391);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(25, 130);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(163, 16);
            this.lblManual.TabIndex = 24;
            this.lblManual.Text = "Manual heater signal (0-5):";
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
            this.tabPID.Location = new System.Drawing.Point(4, 25);
            this.tabPID.Margin = new System.Windows.Forms.Padding(4);
            this.tabPID.Name = "tabPID";
            this.tabPID.Padding = new System.Windows.Forms.Padding(4);
            this.tabPID.Size = new System.Drawing.Size(360, 431);
            this.tabPID.TabIndex = 2;
            this.tabPID.Text = "PID";
            this.tabPID.UseVisualStyleBackColor = true;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(29, 167);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(193, 16);
            this.lblAlpha.TabIndex = 41;
            this.lblAlpha.Text = "Derivate filter (0-1 where 1 is off)";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(247, 164);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(44, 22);
            this.txtAlpha.TabIndex = 40;
            this.txtAlpha.Text = "0,1";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(247, 39);
            this.txtP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(44, 22);
            this.txtP.TabIndex = 32;
            this.txtP.Text = "1,58";
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(29, 43);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(19, 16);
            this.lblP.TabIndex = 33;
            this.lblP.Text = "P:";
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(247, 70);
            this.txtI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(44, 22);
            this.txtI.TabIndex = 34;
            this.txtI.Text = "9,17";
            this.txtI.TextChanged += new System.EventHandler(this.txtI_TextChanged);
            // 
            // lblAntiWindup
            // 
            this.lblAntiWindup.AutoSize = true;
            this.lblAntiWindup.Location = new System.Drawing.Point(29, 137);
            this.lblAntiWindup.Name = "lblAntiWindup";
            this.lblAntiWindup.Size = new System.Drawing.Size(124, 16);
            this.lblAntiWindup.TabIndex = 39;
            this.lblAntiWindup.Text = "I antiwindup (0 = off):";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(29, 74);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(58, 16);
            this.lblI.TabIndex = 35;
            this.lblI.Text = "I (0 = off):";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(247, 103);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(44, 22);
            this.txtD.TabIndex = 36;
            this.txtD.Text = "0";
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // txtAntiWindup
            // 
            this.txtAntiWindup.Location = new System.Drawing.Point(247, 133);
            this.txtAntiWindup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntiWindup.Name = "txtAntiWindup";
            this.txtAntiWindup.Size = new System.Drawing.Size(44, 22);
            this.txtAntiWindup.TabIndex = 38;
            this.txtAntiWindup.Text = "100";
            this.txtAntiWindup.TextChanged += new System.EventHandler(this.txtAntiWindup_TextChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(29, 107);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(65, 16);
            this.lblD.TabIndex = 37;
            this.lblD.Text = "D (0 = off):";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.lblMaxChartYSim);
            this.tabChart.Controls.Add(this.txtChartYmaxSim);
            this.tabChart.Controls.Add(this.lblMinChartYsim);
            this.tabChart.Controls.Add(this.txtChartYminSim);
            this.tabChart.Controls.Add(this.lblLimitTemp);
            this.tabChart.Controls.Add(this.btnLimitTemp);
            this.tabChart.Controls.Add(this.lblChartYmax);
            this.tabChart.Controls.Add(this.txtChartYmax);
            this.tabChart.Controls.Add(this.lblChartYmin);
            this.tabChart.Controls.Add(this.txtChartYmin);
            this.tabChart.Location = new System.Drawing.Point(4, 25);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(360, 431);
            this.tabChart.TabIndex = 3;
            this.tabChart.Text = "Chart settings";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // lblMaxChartYSim
            // 
            this.lblMaxChartYSim.AutoSize = true;
            this.lblMaxChartYSim.Location = new System.Drawing.Point(49, 223);
            this.lblMaxChartYSim.Name = "lblMaxChartYSim";
            this.lblMaxChartYSim.Size = new System.Drawing.Size(142, 16);
            this.lblMaxChartYSim.TabIndex = 39;
            this.lblMaxChartYSim.Text = "Maximum temperature:";
            // 
            // txtChartYmaxSim
            // 
            this.txtChartYmaxSim.Location = new System.Drawing.Point(267, 220);
            this.txtChartYmaxSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChartYmaxSim.Name = "txtChartYmaxSim";
            this.txtChartYmaxSim.Size = new System.Drawing.Size(44, 22);
            this.txtChartYmaxSim.TabIndex = 38;
            this.txtChartYmaxSim.Text = "40";
            // 
            // lblMinChartYsim
            // 
            this.lblMinChartYsim.AutoSize = true;
            this.lblMinChartYsim.Location = new System.Drawing.Point(49, 191);
            this.lblMinChartYsim.Name = "lblMinChartYsim";
            this.lblMinChartYsim.Size = new System.Drawing.Size(138, 16);
            this.lblMinChartYsim.TabIndex = 37;
            this.lblMinChartYsim.Text = "Minimum temperature:";
            // 
            // txtChartYminSim
            // 
            this.txtChartYminSim.Location = new System.Drawing.Point(267, 188);
            this.txtChartYminSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChartYminSim.Name = "txtChartYminSim";
            this.txtChartYminSim.Size = new System.Drawing.Size(44, 22);
            this.txtChartYminSim.TabIndex = 36;
            this.txtChartYminSim.Text = "0";
            // 
            // lblLimitTemp
            // 
            this.lblLimitTemp.AutoSize = true;
            this.lblLimitTemp.Location = new System.Drawing.Point(47, 40);
            this.lblLimitTemp.Name = "lblLimitTemp";
            this.lblLimitTemp.Size = new System.Drawing.Size(115, 16);
            this.lblLimitTemp.TabIndex = 35;
            this.lblLimitTemp.Text = "Limit temperature: ";
            // 
            // btnLimitTemp
            // 
            this.btnLimitTemp.Location = new System.Drawing.Point(202, 37);
            this.btnLimitTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimitTemp.Name = "btnLimitTemp";
            this.btnLimitTemp.Size = new System.Drawing.Size(107, 23);
            this.btnLimitTemp.TabIndex = 34;
            this.btnLimitTemp.Text = "Off";
            this.btnLimitTemp.UseVisualStyleBackColor = true;
            this.btnLimitTemp.Click += new System.EventHandler(this.btnLimitTemp_Click);
            // 
            // lblChartYmax
            // 
            this.lblChartYmax.AutoSize = true;
            this.lblChartYmax.Location = new System.Drawing.Point(47, 130);
            this.lblChartYmax.Name = "lblChartYmax";
            this.lblChartYmax.Size = new System.Drawing.Size(142, 16);
            this.lblChartYmax.TabIndex = 33;
            this.lblChartYmax.Text = "Maximum temperature:";
            // 
            // txtChartYmax
            // 
            this.txtChartYmax.Location = new System.Drawing.Point(265, 127);
            this.txtChartYmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChartYmax.Name = "txtChartYmax";
            this.txtChartYmax.Size = new System.Drawing.Size(44, 22);
            this.txtChartYmax.TabIndex = 32;
            this.txtChartYmax.Text = "40";
            // 
            // lblChartYmin
            // 
            this.lblChartYmin.AutoSize = true;
            this.lblChartYmin.Location = new System.Drawing.Point(47, 98);
            this.lblChartYmin.Name = "lblChartYmin";
            this.lblChartYmin.Size = new System.Drawing.Size(138, 16);
            this.lblChartYmin.TabIndex = 31;
            this.lblChartYmin.Text = "Minimum temperature:";
            // 
            // txtChartYmin
            // 
            this.txtChartYmin.Location = new System.Drawing.Point(265, 95);
            this.txtChartYmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChartYmin.Name = "txtChartYmin";
            this.txtChartYmin.Size = new System.Drawing.Size(44, 22);
            this.txtChartYmin.TabIndex = 30;
            this.txtChartYmin.Text = "0";
            // 
            // lblTempReal
            // 
            this.lblTempReal.AutoSize = true;
            this.lblTempReal.Location = new System.Drawing.Point(561, 52);
            this.lblTempReal.Name = "lblTempReal";
            this.lblTempReal.Size = new System.Drawing.Size(85, 16);
            this.lblTempReal.TabIndex = 4;
            this.lblTempReal.Text = "Temperature";
            // 
            // lblUnitReal
            // 
            this.lblUnitReal.AutoSize = true;
            this.lblUnitReal.Location = new System.Drawing.Point(709, 52);
            this.lblUnitReal.Name = "lblUnitReal";
            this.lblUnitReal.Size = new System.Drawing.Size(20, 16);
            this.lblUnitReal.TabIndex = 5;
            this.lblUnitReal.Text = "°C";
            // 
            // chartTempReal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTempReal.ChartAreas.Add(chartArea1);
            this.chartTempReal.Location = new System.Drawing.Point(768, 48);
            this.chartTempReal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTempReal.Name = "chartTempReal";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartTempReal.Series.Add(series1);
            this.chartTempReal.Size = new System.Drawing.Size(893, 366);
            this.chartTempReal.TabIndex = 23;
            this.chartTempReal.Text = "chart1";
            // 
            // chartTempSim
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTempSim.ChartAreas.Add(chartArea2);
            this.chartTempSim.Location = new System.Drawing.Point(768, 446);
            this.chartTempSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTempSim.Name = "chartTempSim";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartTempSim.Series.Add(series2);
            this.chartTempSim.Size = new System.Drawing.Size(893, 366);
            this.chartTempSim.TabIndex = 24;
            this.chartTempSim.Text = "chart1";
            // 
            // lblUnitSim
            // 
            this.lblUnitSim.AutoSize = true;
            this.lblUnitSim.Location = new System.Drawing.Point(709, 449);
            this.lblUnitSim.Name = "lblUnitSim";
            this.lblUnitSim.Size = new System.Drawing.Size(20, 16);
            this.lblUnitSim.TabIndex = 27;
            this.lblUnitSim.Text = "°C";
            // 
            // lblTempSim
            // 
            this.lblTempSim.AutoSize = true;
            this.lblTempSim.Location = new System.Drawing.Point(561, 449);
            this.lblTempSim.Name = "lblTempSim";
            this.lblTempSim.Size = new System.Drawing.Size(85, 16);
            this.lblTempSim.TabIndex = 26;
            this.lblTempSim.Text = "Temperature";
            // 
            // txtTempSim
            // 
            this.txtTempSim.Location = new System.Drawing.Point(656, 446);
            this.txtTempSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempSim.Name = "txtTempSim";
            this.txtTempSim.Size = new System.Drawing.Size(48, 22);
            this.txtTempSim.TabIndex = 25;
            // 
            // lblUnitSimV
            // 
            this.lblUnitSimV.AutoSize = true;
            this.lblUnitSimV.Location = new System.Drawing.Point(709, 479);
            this.lblUnitSimV.Name = "lblUnitSimV";
            this.lblUnitSimV.Size = new System.Drawing.Size(16, 16);
            this.lblUnitSimV.TabIndex = 30;
            this.lblUnitSimV.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Input (Heat u):";
            // 
            // txtInputSim
            // 
            this.txtInputSim.Location = new System.Drawing.Point(656, 475);
            this.txtInputSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputSim.Name = "txtInputSim";
            this.txtInputSim.Size = new System.Drawing.Size(48, 22);
            this.txtInputSim.TabIndex = 28;
            // 
            // lblUnitRealV
            // 
            this.lblUnitRealV.AutoSize = true;
            this.lblUnitRealV.Location = new System.Drawing.Point(709, 81);
            this.lblUnitRealV.Name = "lblUnitRealV";
            this.lblUnitRealV.Size = new System.Drawing.Size(16, 16);
            this.lblUnitRealV.TabIndex = 33;
            this.lblUnitRealV.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Input (Heat u):";
            // 
            // txtInputReal
            // 
            this.txtInputReal.Location = new System.Drawing.Point(656, 78);
            this.txtInputReal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputReal.Name = "txtInputReal";
            this.txtInputReal.Size = new System.Drawing.Size(48, 22);
            this.txtInputReal.TabIndex = 31;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1816, 894);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Controller";
            this.Text = "Controller";
            this.TabControl.ResumeLayout(false);
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            this.tabPageControl.ResumeLayout(false);
            this.tabPageControl.PerformLayout();
            this.tabPID.ResumeLayout(false);
            this.tabPID.PerformLayout();
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
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
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.Label lblChartYmax;
        private System.Windows.Forms.TextBox txtChartYmax;
        private System.Windows.Forms.Label lblChartYmin;
        private System.Windows.Forms.TextBox txtChartYmin;
        private System.Windows.Forms.Label lblLimitTemp;
        private System.Windows.Forms.Button btnLimitTemp;
        private System.Windows.Forms.Label lblMaxChartYSim;
        private System.Windows.Forms.TextBox txtChartYmaxSim;
        private System.Windows.Forms.Label lblMinChartYsim;
        private System.Windows.Forms.TextBox txtChartYminSim;
    }
}

