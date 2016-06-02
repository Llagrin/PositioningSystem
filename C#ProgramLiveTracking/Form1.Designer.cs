namespace Arduino
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.ChbMeten = new System.Windows.Forms.CheckBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnReset = new System.Windows.Forms.Button();
            this.ChbTesten = new System.Windows.Forms.CheckBox();
            this.ChbHoek = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // comPorts
            // 
            this.comPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(12, 38);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(341, 33);
            this.comPorts.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1237, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 33);
            this.progressBar1.TabIndex = 2;
            // 
            // BtnBegin
            // 
            this.BtnBegin.Enabled = false;
            this.BtnBegin.Location = new System.Drawing.Point(379, 12);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(329, 82);
            this.BtnBegin.TabIndex = 1;
            this.BtnBegin.Text = "Begin";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(729, 12);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(329, 82);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtY
            // 
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(999, 118);
            this.txtY.Multiline = true;
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(218, 52);
            this.txtY.TabIndex = 0;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(1237, 60);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(168, 52);
            this.BtnOpen.TabIndex = 5;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Enabled = false;
            this.BtnClose.Location = new System.Drawing.Point(1237, 118);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(168, 52);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port Name";
            // 
            // ChbMeten
            // 
            this.ChbMeten.AutoSize = true;
            this.ChbMeten.Enabled = false;
            this.ChbMeten.Location = new System.Drawing.Point(1084, 12);
            this.ChbMeten.Name = "ChbMeten";
            this.ChbMeten.Size = new System.Drawing.Size(104, 29);
            this.ChbMeten.TabIndex = 9;
            this.ChbMeten.Text = "Meten";
            this.ChbMeten.UseVisualStyleBackColor = true;
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(775, 118);
            this.txtX.Multiline = true;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(218, 52);
            this.txtX.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(37, 195);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(987, 829);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // BtnReset
            // 
            this.BtnReset.Enabled = false;
            this.BtnReset.Location = new System.Drawing.Point(18, 94);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(161, 58);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ChbTesten
            // 
            this.ChbTesten.AutoSize = true;
            this.ChbTesten.Location = new System.Drawing.Point(1084, 39);
            this.ChbTesten.Name = "ChbTesten";
            this.ChbTesten.Size = new System.Drawing.Size(110, 29);
            this.ChbTesten.TabIndex = 12;
            this.ChbTesten.Text = "Testen";
            this.ChbTesten.UseVisualStyleBackColor = true;
            // 
            // ChbHoek
            // 
            this.ChbHoek.AutoSize = true;
            this.ChbHoek.Location = new System.Drawing.Point(1084, 65);
            this.ChbHoek.Name = "ChbHoek";
            this.ChbHoek.Size = new System.Drawing.Size(94, 29);
            this.ChbHoek.TabIndex = 13;
            this.ChbHoek.Text = "Hoek";
            this.ChbHoek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1480, 1192);
            this.Controls.Add(this.ChbHoek);
            this.Controls.Add(this.ChbTesten);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.ChbMeten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "Form1";
            this.Text = "Serial Communication";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.CheckBox ChbMeten;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.CheckBox ChbTesten;
        private System.Windows.Forms.CheckBox ChbHoek;
    }
}

