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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanmany = double.Parse(textBox1.Text);
            double year = int.Parse(textBox3.Text);
            double rent = int.Parse(textBox2.Text);
            double ownmoney = int.Parse(textBox4.Text);
            double r = (rent / 100) / 12;
        }
    }
}
