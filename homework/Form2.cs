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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string name;
        int english;
        int chinese;
        int math;

        private void button1_Click(object sender, EventArgs e)
        {
            name = nametxt.Text;
            english = int.Parse(entxt.Text);
            chinese = int.Parse(chinatxt.Text);
            math = int.Parse(mathtxt.Text);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            grade.Text = $"姓名: {name}\n英文成績: {english}\n國文成績: {chinese}\n數學成績: {math}\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int grade;
            string class_科目;
            int mingrade;
            string min_科目;
            if(english > chinese)
            {
                grade = english;
                class_科目 = "英文";
                mingrade = chinese;
                min_科目 = "中文";
            }
            else
            {
                grade = chinese;
                class_科目 = "國文";
                mingrade = english;
                min_科目 = "英文";
            }
            if (grade < math)
            {
                grade = math;
                class_科目 = "數學";
            }
            if (mingrade > math)
            {
                mingrade = math;
                min_科目="數學";
            }
            //else
            //{
            //    grade = chinese;
            //    class_科目 = "國文";
            //    mingrade = math;
            //    min_科目 = "數學";
            //}
            maxgrade.Text = "最高科目成績為:"+class_科目+grade+"分"+"" +
                "\n"+"最低科目為: "+min_科目+mingrade+"分";
        }
    }
}
