using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcutor
{
    public partial class Form1 : Form
    {
        double x, y, resullt;
        char os;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cacul.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cacul.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cacul.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cacul.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cacul.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cacul.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cacul.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cacul.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cacul.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(cacul.Text);
            os = '+';
            cacul.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(cacul.Text);
            os = '-';
            cacul.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(cacul.Text);
            os = '/';
            cacul.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(cacul.Text);
            os = '*';
            cacul.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(cacul.Text);
            switch (os)
            {
                case '+':
                    resullt = x + y;
                    break;
                case '-':
                    resullt = x - y;
                    break;
                case'/':
                    resullt = x / y;
                    break;
                case'*':
                    resullt = x * y;
                    break;
            }
            cacul.Text = Convert.ToString(resullt);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            cacul.Clear();
        }

        private void cacul_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
