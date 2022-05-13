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
        private void color_lights()
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

            // dioda x
            int x = rnd.Next(0, 5);
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
            int y = rnd.Next(0, 5);
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
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "button1")
            {
                Thread.Sleep(2000);
                // prawdziwy test
                int x = 0;
            }
            else if (button.Name == "button2")
            {
                Thread.Sleep(2000);
                color_lights();
            }
            else
            {
                color_lights();
            }
        }
    }
}
