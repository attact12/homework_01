using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class myclac : Form
    {
        public myclac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(N1.Text);
            double num2 = double.Parse(N2.Text);
            double sum1 = num1 + num2;
            A1.Text = sum1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(N1.Text);
            double num2 = double.Parse(N2.Text);
            double sum2 = num1 - num2;
            A1.Text = sum2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(N1.Text);
            double num2 = double.Parse(N2.Text);
            double sum3 = num1 * num2;
            A1.Text = sum3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(N1.Text);
            double num2 = double.Parse(N2.Text);
            double sum4 = num1 / num2;
            A1.Text = sum4.ToString();
        }
    }
}
