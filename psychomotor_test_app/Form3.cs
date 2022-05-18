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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Stopwatch stopwatch = new Stopwatch();
        int counter = 0;
        int num = 0;
        bool b_click = false;
        private void button_color_change(Button button)
        {
            string button_name = "button" + Convert.ToString(num);
            if (button.Name == button_name || button.Name == "button9" || button.Name == "button10")
            {
                counter++;
                int new_num = rnd.Next(1, 9);
                while (new_num == num)
                    new_num = rnd.Next(1, 9);
                switch (new_num)
                {
                    case 1:
                        button1.BackColor = Color.Red;
                        break;
                    case 2:
                        button2.BackColor = Color.Red;
                        break;
                    case 3:
                        button3.BackColor = Color.Red;
                        break;
                    case 4:
                        button4.BackColor = Color.Red;
                        break;
                    case 5:
                        button5.BackColor = Color.Red;
                        break;
                    case 6:
                        button6.BackColor = Color.Red;
                        break;
                    case 7:
                        button7.BackColor = Color.Red;
                        break;
                    case 8:
                        button8.BackColor = Color.Red;
                        break;
                }
                num = new_num;
            }
        }
        private void button_color_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "button10")
                b_click = true;
            if (button.Name == "button9" || button.Name == "button10")
            {
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
                button5.Enabled = true; button6.Enabled = true; button7.Enabled = true; button8.Enabled = true;

            }
            if (counter == 0) 
            {
                button9.Enabled = false;
                button10.Enabled = false;
                Thread.Sleep(1000);
                stopwatch = new Stopwatch();
                stopwatch.Start();
            }
            if (counter < 10)
            {
                button_color_change(button);
                button.BackColor = Color.White;
            }
            else
            {
                stopwatch.Stop();
                button.BackColor = Color.White;
                if (!b_click)
                {
                    textBox_calkowityczas.Text = "Szkolenie wykonane!";
                    button10.Enabled = true;
                }
                else
                {
                    textBox_calkowityczas.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms";
                    string test1_result = "Test2: " + Convert.ToString(stopwatch.ElapsedMilliseconds) + "ms\n";
                    File.AppendAllText("results.txt", test1_result);
                }
                b_click = false;
                textBox_calkowityczas.Enabled = false;
                counter = 0;
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
                button5.Enabled = false; button6.Enabled = false; button7.Enabled = false; button8.Enabled = false;
            }
        }
    }
}
