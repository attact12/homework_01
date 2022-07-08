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
    public partial class Form4_guess : Form
    {
        public Form4_guess()
        {
            InitializeComponent();
        }
        internal void guessnumber()
        {
            Form4 count = (Form4)this.Owner;
            int number = int.Parse(textinput.Text);
            if (number == count.guess)
            {
                MessageBox.Show("恭喜答對");
            }
            else if (number > count.guess)
            {
                count.max = number;

            }
            else if (number < count.guess)
            {
                count.min= number;

            }
            else
            {
                MessageBox.Show("請輸入範圍內數字");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 count = (Form4)this.Owner;
            guessnumber();

        }
    }
}
