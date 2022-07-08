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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            Form1 hw = new Form1();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            Form2 hw = new Form2();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            Form3 hw = new Form3();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            Form4 hw = new Form4();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            loan hw = new loan();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            myclac hw = new myclac();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            spl2.Panel2.Controls.Clear();
            grade01 hw = new grade01();
            hw.TopLevel = false;
            spl2.Panel2.Controls.Add(hw);
            hw.Show();
        }
    }

}
