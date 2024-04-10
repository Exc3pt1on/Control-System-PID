namespace PCS
{
    partial class Form1
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.lblChannelOut = new System.Windows.Forms.Label();
            this.txtChannelOut = new System.Windows.Forms.TextBox();
            this.lblChannelIn = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtChannelIn = new System.Windows.Forms.TextBox();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblManual = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(605, 181);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(48, 22);
            this.txtTemp.TabIndex = 0;
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(164, 57);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(44, 22);
            this.txtHeat.TabIndex = 1;
            this.txtHeat.Text = "0";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageDevice);
            this.TabControl.Controls.Add(this.tabPageControl);
            this.TabControl.Location = new System.Drawing.Point(78, 67);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(368, 460);
            this.TabControl.TabIndex = 3;
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.Controls.Add(this.lblChannelOut);
            this.tabPageDevice.Controls.Add(this.txtChannelOut);
            this.tabPageDevice.Controls.Add(this.lblChannelIn);
            this.tabPageDevice.Controls.Add(this.lblDevice);
            this.tabPageDevice.Controls.Add(this.txtDevice);
            this.tabPageDevice.Controls.Add(this.txtChannelIn);
            this.tabPageDevice.Location = new System.Drawing.Point(4, 25);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevice.Size = new System.Drawing.Size(360, 431);
            this.tabPageDevice.TabIndex = 0;
            this.tabPageDevice.Text = "Device";
            this.tabPageDevice.UseVisualStyleBackColor = true;
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
            this.txtChannelOut.Location = new System.Drawing.Point(142, 85);
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
            this.txtDevice.Location = new System.Drawing.Point(142, 29);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(100, 22);
            this.txtDevice.TabIndex = 4;
            this.txtDevice.Text = "dev3";
            // 
            // txtChannelIn
            // 
            this.txtChannelIn.Location = new System.Drawing.Point(142, 57);
            this.txtChannelIn.Name = "txtChannelIn";
            this.txtChannelIn.Size = new System.Drawing.Size(100, 22);
            this.txtChannelIn.TabIndex = 3;
            this.txtChannelIn.Text = "ai0";
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.lblManual);
            this.tabPageControl.Controls.Add(this.txtHeat);
            this.tabPageControl.Location = new System.Drawing.Point(4, 25);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControl.Size = new System.Drawing.Size(360, 431);
            this.tabPageControl.TabIndex = 1;
            this.tabPageControl.Text = "Control";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(514, 184);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(85, 16);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Temperature";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(659, 184);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(20, 16);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "°C";
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            this.chartTemp.Location = new System.Drawing.Point(700, 92);
            this.chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(615, 365);
            this.chartTemp.TabIndex = 23;
            this.chartTemp.Text = "chart1";
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(75, 60);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(83, 16);
            this.lblManual.TabIndex = 24;
            this.lblManual.Text = "Manual gain:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 677);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.txtTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            this.tabPageControl.ResumeLayout(false);
            this.tabPageControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Label lblChannelOut;
        private System.Windows.Forms.TextBox txtChannelOut;
        private System.Windows.Forms.Label lblChannelIn;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtChannelIn;
        private System.Windows.Forms.Label lblManual;
    }
}

