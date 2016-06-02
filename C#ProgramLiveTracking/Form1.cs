using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Arduino
{
    public partial class Form1 : Form
    {
        public static List<float> tabel = new List<float>();
        public static List<float> tabel2 = new List<float>();

        public Form1()
        {
            InitializeComponent();
            GetPortNames();
            ResetGrafiek();

            Application.DoEvents();

        }

        void GetPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            comPorts.Items.AddRange(ports);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comPorts.Items.Count == 1)
                {
                    this.arduino = new SerialPort((string)this.comPorts.Items[0], 38400, Parity.None, 8, StopBits.One);
                    this.comPorts.Text = this.arduino.PortName;
                    arduino.Open();                 
                    //arduino.DtrEnable = true;
                    progressBar1.Value = 100;
                    BtnBegin.Enabled = true;
                    BtnStop.Enabled = true;
                    //txtX.Enabled = true;
                    BtnOpen.Enabled = false;
                    BtnClose.Enabled = true;
                    BtnReset.Enabled = true;
                }
                else if (this.comPorts.Items.Count > 1)
                {
                    if (this.comPorts.Text != string.Empty)
                    {
                        this.arduino = new SerialPort(this.comPorts.Text, 38400, Parity.None, 8, StopBits.One);
                        arduino.Open();
                        //arduino.DtrEnable = true;
                        progressBar1.Value = 100;
                        BtnBegin.Enabled = true;
                        BtnStop.Enabled = true;
                        //txtX.Enabled = true;
                        BtnOpen.Enabled = false;
                        BtnClose.Enabled = true;
                        BtnReset.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Select the arduino port, moron!");
                    }
                }

            }
            catch (UnauthorizedAccessException)
            {
                txtY.Text = "Failed to connect";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arduino.Close();
            progressBar1.Value = 0;
            BtnBegin.Enabled = false;
            BtnStop.Enabled = false;
            //txtX.Enabled = false;
            BtnOpen.Enabled = true;
            BtnClose.Enabled = false;
            BtnReset.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnClose.Enabled = false;
            BtnReset.Enabled = false;
            ChbMeten.Checked = true;
            ResetGrafiek();
            arduino.ReadTimeout = 20;
            arduino.WriteTimeout = 20;

            if (ChbTesten.Checked == false)
            {
                while (ChbMeten.Checked == true)
                {
                    try
                    {
                        arduino.Write("1");
                        //System.Threading.Thread.Sleep(10);
                        float x = ((float)((Int16)(256 * arduino.ReadByte() + arduino.ReadByte())) / 100);
                        float y = ((float)((Int16)(256 * arduino.ReadByte() + arduino.ReadByte())) / 100);
                        txtX.Text = Convert.ToString(x);
                        txtY.Text = Convert.ToString(y);

                        chart.Series[1].Points.AddXY(x, y);
                        Application.DoEvents();
                    }
                    catch (TimeoutException)
                    {
                        Console.WriteLine("Faal");
                        //Application.DoEvents();
                        //System.Threading.Thread.Sleep(10);
                    }
                }
            
            }
            else if (ChbTesten.Checked == true)
            {
                if (ChbHoek.Checked == true)
                {
                    while (ChbMeten.Checked == true)
                    {
                        try
                        {
                            arduino.Write("1");
                            //System.Threading.Thread.Sleep(10);
                            float hoek = ((float)((Int16)(256 * arduino.ReadByte() + arduino.ReadByte())) / 10);
                            txtX.Text = Convert.ToString(hoek);
                            txtY.Text = "/";
                            tabel.Add(hoek);
                            Application.DoEvents();
                        }
                        catch (TimeoutException)
                        {
                            Console.WriteLine("Faal");
                            //Application.DoEvents();
                            //System.Threading.Thread.Sleep(10);
                        }
                    }
                }
                else
                {
                    while (ChbMeten.Checked == true)
                    {
                        try
                        {
                            arduino.Write("1");
                            //System.Threading.Thread.Sleep(10);
                            float afstand = ((float)((Int16)(256 * arduino.ReadByte() + arduino.ReadByte())) / 100);
                            float tijd = ((float)((Int16)(256 * arduino.ReadByte() + arduino.ReadByte())) / 100);
                            txtX.Text = Convert.ToString(afstand);
                            txtY.Text = Convert.ToString(tijd);
                            tabel.Add(afstand);
                            tabel2.Add(tijd);
                            Application.DoEvents();
                        }
                        catch (TimeoutException)
                        {
                            Console.WriteLine("Faal");
                            //Application.DoEvents();
                            //System.Threading.Thread.Sleep(10);
                        }
                    }
                }
                

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChbMeten.Checked = false;
            BtnClose.Enabled = true;
            BtnReset.Enabled = true;
            //ResetGrafiek();
            if (ChbTesten.Checked == true)
            {
                if (ChbHoek.Checked == true)
                {
                    float[] tabelletje = tabel.ToArray();
                    int lengte = tabelletje.Length;
                    using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(@"C:\Users\Lowie\OneDrive\School\1e Ma\Masterproef\Testen\Test.csv"))
                    {
                        for (int x = 0; x < lengte; x++)
                        {
                            outfile.WriteLine(tabelletje[x].ToString("0.00"));
                        }
                    }
                    Application.DoEvents();
                }
                else
                {
                    float[] tabelletje = tabel.ToArray();
                    float[] tabelletje2 = tabel2.ToArray();
                    int lengte = tabelletje.Length;
                    using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(@"C:\Users\Lowie\OneDrive\School\1e Ma\Masterproef\Testen\Test.csv"))
                    {
                        for (int x = 0; x < lengte; x++)
                        {
                            var line = string.Format("{0};{1}", tabelletje[x].ToString("0.00"), tabelletje2[x].ToString("0.00"));
                            //outfile.Write(tabelletje[x].ToString("0.00"));
                            //outfile.Write(",");
                            //outfile.WriteLine(tabelletje2[x].ToString("0.00"));
                            outfile.WriteLine(line);
                        }
                    }
                    Application.DoEvents();
                }
            }
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            arduino.Write("R");

            ResetGrafiek();
            Application.DoEvents();
        }

        void ResetGrafiek()
        {
            chart.Series.Clear();
            chart.BackColor = Color.Transparent;
            chart.ChartAreas[0].BackColor = Color.Black;
            chart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart.Series.Add("Data");
            chart.ChartAreas[0].AxisX.Maximum = 85;
            chart.ChartAreas[0].AxisX.Minimum = -85;
            chart.ChartAreas[0].AxisY.Maximum = 85;
            chart.ChartAreas[0].AxisY.Minimum = -85;
            chart.Legends.Clear();
            chart.Height = 700;
            chart.Width = 700;
            chart.Series.Add("Circle");
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart.Series[0].MarkerSize = 14;
            chart.Series[0].Color = Color.White;
            int r = 78;
            for (double ang = 0; ang <= 2 * Math.PI; ang += 0.005)
            {
                double xc = r * Math.Cos(ang);
                double yc = r * Math.Sin(ang);
                chart.Series[0].Points.AddXY(xc, yc);
            }
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[1].Color = Color.Red;
            chart.Series[1].BorderWidth = 3;
        }
        

    }
}
