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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name1 = name.Text;
            string STAR = star.Text;
            string fm = textBox3.Text;
            string enname = textBox4.Text;
            MessageBox.Show("hi,我是"+name1+"\n\r"+"星座是"+STAR+"\n\r"+"性別是"+fm+"\n\r"+"英文名字是"+enname);
        }

        private void hellow_but_Click(object sender, EventArgs e)
        {
            String name1 = name.Text;
            string STAR = star.Text;
            string fm = textBox3.Text;
            string enname = textBox4.Text;
            MessageBox.Show("hellow,我是" + name1 + "\n\r" + "星座是" + STAR + "\n\r" + "性別是" + fm + "\n\r" + "英文名字是" + enname);
        }
    }
}
