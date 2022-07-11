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
        private string strValue;
        
        public string StrValue
        {
            
            set
            {
                strValue = value;
            }
            //get { return strValue; }
        }

        
        private void butshow_Click(object sender, EventArgs e)
        {

            MessageBox.Show("答案是"+guess);
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(0, 100);
            min = 0;
            max = 100;
            butguess.Enabled = true;
            butshow.Enabled = true;
            
        }

        private void butguess_Click(object sender, EventArgs e)
        {
            Form4_guess showmaker=new Form4_guess();
            showmaker.Owner = this;
            //showmaker.Show();
            
            showmaker.ShowDialog();
            //label1_tx.Text = strValue;


        }
        public string myshow()
        {
            label1_tx.Text = strValue;
            return strValue;
        }
    }
}
