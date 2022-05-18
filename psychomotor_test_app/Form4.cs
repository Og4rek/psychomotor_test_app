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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int counter = 0;
        float sum_of_time = 0;
        bool dzialanie = false;
        bool b_click;
        Random rnd = new Random();
        Stopwatch stopwatch = new Stopwatch();
        private void play_sound()
        {
            textBox1.Text = "Dzwiek numer: " + Convert.ToString(counter + 1);
            stopwatch = new Stopwatch();
            Thread.Sleep(rnd.Next(1500, 2500));
            Console.Beep();
            stopwatch.Start();
            dzialanie = true;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            if (button.Name == "button1")
                b_click = true;
            play_sound();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && dzialanie)
            {
                stopwatch.Stop();
                sum_of_time += stopwatch.ElapsedMilliseconds;
                counter++;
                dzialanie = false;
                if (counter < 5)
                    play_sound();
                else
                {
                    if (b_click == false) 
                    { 
                        textBox1.Text = "Szkolenie wykonane!";
                        sum_of_time = 0;
                    }   
                    button1.Enabled = true;
                    counter = 0;
                }
                if (b_click && counter == 0)
                {
                    textBox1.Text = Convert.ToString(sum_of_time / 5) + "ms";
                    textBox1.Enabled = false;
                    string test1_result = "Test3: " + Convert.ToString(sum_of_time/5) + "\n";
                    File.AppendAllText("results.txt", test1_result);
                    b_click = false;
                    button1.Enabled = false;
                }
            }
        }
    }
}
