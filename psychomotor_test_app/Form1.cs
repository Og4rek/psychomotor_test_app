using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace psychomotor_test_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string text1 = "";
            File.WriteAllText("results.txt", text1);
        }
        private void buttonTest1_Click(object sender, EventArgs e)
        {
            Form2 form_test_1 = new Form2();
            form_test_1.ShowDialog();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            Form3 form_test_2 = new Form3();
            form_test_2.ShowDialog();
        }

        private void buttonTest3_Click(object sender, EventArgs e)
        {
            Form4 form_test_3 = new Form4();
            form_test_3.ShowDialog();
        }

        private void buttonTest4_Click(object sender, EventArgs e)
        {
            Form5 form_test_4 = new Form5();
            form_test_4.ShowDialog();
        }

        private void buttonTest5_Click(object sender, EventArgs e)
        {
            Form6 form_test_5 = new Form6();
            form_test_5.ShowDialog();
        }
    }
}
