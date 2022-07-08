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


        private void button1_Click_1(object sender, EventArgs e)
        {
            double loanmany = double.Parse(textBox1.Text);
            double year = int.Parse(textBox3.Text);
            double rent = int.Parse(textBox2.Text);
            double ownmoney = int.Parse(textBox4.Text);
            double r = (rent * 0.01) / 12;//月利率
            double averagerent = Math.Pow(1 + r, (year * 12));
            double Averagerent = averagerent - 1;
            double Aver月攤還率 = averagerent * r / Averagerent;
            double month_pay = loanmany - ownmoney;
            double Month_pay = month_pay * Aver月攤還率;
            MessageBox.Show("每月應還:" + Math.Round(Month_pay));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double loanmany = double.Parse(textBox1.Text);
            double year = int.Parse(textBox3.Text);
            double rent = int.Parse(textBox2.Text);
            double ownmoney = int.Parse(textBox4.Text);
            double r = (rent * 0.01) / 12;//月利率
            double averagerent = Math.Pow(1 + r, (year * 12));
            double Averagerent = averagerent - 1;
            double Aver月攤還率 = averagerent * r / Averagerent;
            double month_pay = loanmany - ownmoney;
            double Month_pay = month_pay * Aver月攤還率;
            MessageBox.Show("總付金額為: " + Math.Round(Month_pay * 12 * year));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double loanmany = double.Parse(textBox1.Text);
            double year = int.Parse(textBox3.Text);
            double rent = int.Parse(textBox2.Text);
            double ownmoney = int.Parse(textBox4.Text);
            double r = (rent * 0.01) / 12;//月利率
            double averagerent = Math.Pow(1 + r, (year * 12));
            double Averagerent = averagerent - 1;
            double Aver月攤還率 = averagerent * r / Averagerent;
            double month_pay = loanmany - ownmoney;
            double Month_pay = month_pay * Aver月攤還率;


            loanreport showmaker=new loanreport();
            showmaker.Show();
            showmaker.wokshit(loanmany,year,rent,Math.Round(Month_pay), Math.Round(Month_pay * 12 * year));
        }
    }
}
