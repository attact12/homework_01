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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int guess, min, max;

        private void butguess_Click(object sender, EventArgs e)
        {
            Form4_guess showmaker=new Form4_guess();
            showmaker.Owner = this;
            showmaker.Show();
            Form4_guess RETURN = new Form4_guess();
            RETURN.guessnumber();//TEXT=$"{A}----{B}",用一個方法每次數值有變動,就SHOW一次
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 100);
            min = 0;
            max = 100;
            butguess.Enabled = true;
            butshow.Enabled = true;
        }
    }
}
