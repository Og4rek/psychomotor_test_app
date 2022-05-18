using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace psychomotor_test_app
{
    public partial class Form6 : Form
    {
        Random rnd = new Random();
        Stopwatch stopwatch = new Stopwatch();
        int counter = 0;
        int x = 0;
        int y = 0;
        int liczba_bledow = 0;
        bool button_result = false;
        public Form6()
        {
            InitializeComponent();
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g_0 = panel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g_0.DrawEllipse(p, 8, 8, 9, 9);
        }
        private void color_white_lights()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g_1 = this.panel1.CreateGraphics();
            Graphics g_2 = this.panel2.CreateGraphics();
            Graphics g_3 = this.panel3.CreateGraphics();
            Graphics g_4 = this.panel4.CreateGraphics();
            Graphics g_5 = this.panel5.CreateGraphics();
            Graphics g_6 = this.panel6.CreateGraphics();
            Graphics g_7 = this.panel7.CreateGraphics();
            Graphics g_8 = this.panel8.CreateGraphics();
            Graphics g_9 = this.panel9.CreateGraphics();
            Graphics g_10 = this.panel10.CreateGraphics(); 

            g_1.FillEllipse(whiteBrush, 8, 8, 9, 9); g_2.FillEllipse(whiteBrush, 8, 8, 9, 9); g_3.FillEllipse(whiteBrush, 8, 8, 9, 9); g_4.FillEllipse(whiteBrush, 8, 8, 9, 9); g_5.FillEllipse(whiteBrush, 8, 8, 9, 9);
            g_6.FillEllipse(whiteBrush, 8, 8, 9, 9); g_7.FillEllipse(whiteBrush, 8, 8, 9, 9); g_8.FillEllipse(whiteBrush, 8, 8, 9, 9); g_9.FillEllipse(whiteBrush, 8, 8, 9, 9); g_10.FillEllipse(whiteBrush, 8, 8, 9, 9);
        }
        private void color_lights(Button button)
        {
            Console.Beep();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g_1 = this.panel1.CreateGraphics();
            Graphics g_2 = this.panel2.CreateGraphics();
            Graphics g_3 = this.panel3.CreateGraphics();
            Graphics g_4 = this.panel4.CreateGraphics();
            Graphics g_5 = this.panel5.CreateGraphics();
            Graphics g_6 = this.panel6.CreateGraphics();
            Graphics g_7 = this.panel7.CreateGraphics();
            Graphics g_8 = this.panel8.CreateGraphics();
            Graphics g_9 = this.panel9.CreateGraphics();
            Graphics g_10 = this.panel10.CreateGraphics();

            g_1.FillEllipse(whiteBrush, 8, 8, 9, 9); g_2.FillEllipse(whiteBrush, 8, 8, 9, 9); g_3.FillEllipse(whiteBrush, 8, 8, 9, 9); g_4.FillEllipse(whiteBrush, 8, 8, 9, 9); g_5.FillEllipse(whiteBrush, 8, 8, 9, 9);
            g_6.FillEllipse(whiteBrush, 8, 8, 9, 9); g_7.FillEllipse(whiteBrush, 8, 8, 9, 9); g_8.FillEllipse(whiteBrush, 8, 8, 9, 9); g_9.FillEllipse(whiteBrush, 8, 8, 9, 9); g_10.FillEllipse(whiteBrush, 8, 8, 9, 9);

            string xy = Convert.ToString(y+1) + Convert.ToString(x+1);

            if (button.Name.Length == 3)
                if (button.Name != "b" + xy)
                    liczba_bledow++;

            // dioda x
            x = rnd.Next(0, 5);
            switch (x)
            {
                case 0:
                    g_1.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 1:
                    g_2.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 2:
                    g_3.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 3:
                    g_4.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 4:
                    g_5.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
            }
            // dioda y
            y = rnd.Next(0, 5);
            switch (y)
            {
                case 0:
                    g_6.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 1:
                    g_7.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 2:
                    g_8.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 3:
                    g_9.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
                case 4:
                    g_10.FillEllipse(redBrush, 8, 8, 9, 9);
                    break;
            }
        }
        private void button_disable()
        {
            b11.Enabled = false; b52.Enabled = false; b42.Enabled = false; b32.Enabled = false; b22.Enabled = false;
            b55.Enabled = false; b51.Enabled = false; b41.Enabled = false; b31.Enabled = false; b12.Enabled = false;
            b21.Enabled = false; b45.Enabled = false; b35.Enabled = false; b25.Enabled = false; b13.Enabled = false;
            b54.Enabled = false; b44.Enabled = false; b34.Enabled = false; b24.Enabled = false; b14.Enabled = false;
            b53.Enabled = false; b43.Enabled = false; b33.Enabled = false; b23.Enabled = false; b15.Enabled = false;
        }
        private void button_enabled()
        {
            b11.Enabled = true; b52.Enabled = true; b42.Enabled = true; b32.Enabled = true; b22.Enabled = true;
            b55.Enabled = true; b51.Enabled = true; b41.Enabled = true; b31.Enabled = true; b12.Enabled = true;
            b21.Enabled = true; b45.Enabled = true; b35.Enabled = true; b25.Enabled = true; b13.Enabled = true;
            b54.Enabled = true; b44.Enabled = true; b34.Enabled = true; b24.Enabled = true; b14.Enabled = true;
            b53.Enabled = true; b43.Enabled = true; b33.Enabled = true; b23.Enabled = true; b15.Enabled = true;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            counter++;
            if (button.Name == "button1")
            {
                button_result = true;
                button1.Enabled = false;
                button_enabled();
                stopwatch = new Stopwatch();
                color_white_lights();
                Thread.Sleep(2000);
                stopwatch.Start();
                color_lights(button);
            }
            else if (button.Name == "button2")
            {
                button2.Enabled = false;
                button_enabled();
                Thread.Sleep(2000);
                stopwatch.Start();
                color_lights(button);
            }
            else
            {
                if (counter < 11)
                {
                    color_lights(button);
                }
                else
                {
                    stopwatch.Stop();
                    button_disable();
                    if (button_result)
                    {
                        textBox1.Text = Convert.ToString(liczba_bledow);
                        textBox2.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms";
                        string test1_result = "Test4: " + Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms\n";
                        File.AppendAllText("results.txt", test1_result);
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                    }
                    else
                    {
                        textBox1.Text = "Szkolenie wykonane!";
                        textBox2.Text = "Szkolenie wykonane!";
                        button1.Enabled = true;
                    }
                    counter = 0;
                    liczba_bledow = 0;
                }
            }
        }
    }
}
