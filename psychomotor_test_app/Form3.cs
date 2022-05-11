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

namespace psychomotor_test_app
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int counter = 0;
        int num = 0;
        private void button_color_change()
        {
            counter++;
            if (counter < 11)
            {
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
                switch (num)
                {
                    case 1:
                        button1.BackColor = Color.White;
                        break;
                    case 2:
                        button2.BackColor = Color.White;
                        break;
                    case 3:
                        button3.BackColor = Color.White;
                        break;
                    case 4:
                        button4.BackColor = Color.White;
                        break;
                    case 5:
                        button5.BackColor = Color.White;
                        break;
                    case 6:
                        button6.BackColor = Color.White;
                        break;
                    case 7:
                        button7.BackColor = Color.White;
                        break;
                    case 8:
                        button8.BackColor = Color.White;
                        break;
                }
                num = new_num;
            }
        }
        private void button_color_Click(object sender, EventArgs e)
        {
            if (counter == 0)
                Thread.Sleep(1000);
            button_color_change();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
