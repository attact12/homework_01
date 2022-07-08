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
    public partial class loanreport : Form
    {
        public loanreport()
        {
            InitializeComponent();
        }
        internal void wokshit(double loanmany, double year, double rait, double monthpay, double yearpay)
        {
            textBox1.Text = loanmany.ToString();
            textBox2.Text = year.ToString();
            textBox3.Text = rait.ToString();
            textBox4.Text = monthpay.ToString();
            textBox5.Text = yearpay.ToString();
        }

    }
}
