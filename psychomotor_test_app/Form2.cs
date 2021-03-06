using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace psychomotor_test_app
{
    public partial class Form2 : Form
    {
        int counter = 0;
        bool space_pressed = false;
        bool zgaszone = false;
        bool b_click = false;
        Random rnd = new Random();
        Stopwatch stopwatch = new Stopwatch();
        public Form2()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_0 = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 0, 0, 100, 100);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_0 = this.panel2.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 0, 0, 100, 100);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_0 = this.panel3.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 0, 0, 100, 100);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_0 = this.panel4.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 0, 0, 100, 100);
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_0 = this.panel5.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 0, 0, 100, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            button1.Enabled = false;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b_click = true;
            textBox2.Enabled = true;
            textBox2.Text = "";
            stopwatch = new Stopwatch();
            button2.Enabled = false;
            space_pressed = false;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g_1 = this.panel1.CreateGraphics();
            Graphics g_2 = this.panel2.CreateGraphics();
            Graphics g_3 = this.panel3.CreateGraphics();
            Graphics g_4 = this.panel4.CreateGraphics();
            Graphics g_5 = this.panel5.CreateGraphics();

            switch (counter)
            {
                case 0:
                    g_1.FillEllipse(redBrush, 0, 0, 100, 100);
                    break;
                case 1:
                    g_2.FillEllipse(redBrush, 0, 0, 100, 100);
                    break;
                case 3:
                    g_3.FillEllipse(redBrush, 0, 0, 100, 100);
                    break;
                case 4:
                    g_4.FillEllipse(redBrush, 0, 0, 100, 100);
                    break;
                case 5:
                    g_5.FillEllipse(redBrush, 0, 0, 100, 100);
                    Thread.Sleep(rnd.Next(1500, 3000));
                    g_1.FillEllipse(whiteBrush, 0, 0, 100, 100);
                    g_2.FillEllipse(whiteBrush, 0, 0, 100, 100);
                    g_3.FillEllipse(whiteBrush, 0, 0, 100, 100);
                    g_4.FillEllipse(whiteBrush, 0, 0, 100, 100);
                    g_5.FillEllipse(whiteBrush, 0, 0, 100, 100);
                    zgaszone = true;
                    stopwatch.Start();
                    break;
                default:
                    break;
            }
            counter++;
            if (space_pressed == true)
            {
                counter = 0;
                timer1.Stop();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && zgaszone)
            {
                stopwatch.Stop();
                textBox2.Text = "Szkolenie wykonane!";
                button2.Enabled = true;
                textBox2.Enabled = false;
                space_pressed = true;
                zgaszone = false;
                if (b_click)
                {
                    string test1_result = "Test1: " + Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms\n";
                    textBox2.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms";
                    File.AppendAllText("results.txt", test1_result);
                    b_click = false;
                    button2.Enabled = false;
                }
            }
        }
    }
}
