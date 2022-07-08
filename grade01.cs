using System;
using System.Collections;
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

    //public struct DataBase
    //{
    //    public string name;
    //    public int english;
    //    public int chinese;
    //    public int math;
    //    public double sum;
    //    public double average;
    //    public double min;
    //    public double max;
    //    public string class_max;
    //    public string class_min;


    //}



    public partial class grade01 : Form
    {



        public grade01()
        {
            InitializeComponent();
        }
        List<DataBase> arrystudent = new List<DataBase>();

        string start = $"{"姓名",w}" + $"{"中文",w}" + $"{"英文",w}" + $"{"數學",w}" + $"{"總和",w}"
                     + $"{"平均",w}" + $"{"最低",w}" + $"{"最高",w}" + "\n";
        const int w = 6;
        const int r = 6;

        /*int T;*/
        public struct DataBase
        {
            public string name;
            public int english;
            public int chinese;
            public int math;
            public double sum;
            public double average;
            public double min;
            public double max;
            public string class_max;
            public string class_min;
        }


            //}

            void TableShow()
            {
            tableshow1.Text = start + "\n";
            for (int i = 0; i < Lsemp.Count; i++)
            {
                tableshow1.Text += $" {((DataBase)Lsemp[i]).name,r} {((DataBase)Lsemp[i]).chinese,9}" +
                    $" {((DataBase)Lsemp[i]).english,9} {((DataBase)Lsemp[i]).math,8}" +
                    $" {((DataBase)Lsemp[i]).sum,6} {((DataBase)Lsemp[i]).average,7}" +
                    $" {((DataBase)Lsemp[i]).class_min + ((DataBase)Lsemp[i]).min,7} {((DataBase)Lsemp[i]).class_max + ((DataBase)Lsemp[i]).max,5}\n";
                //unboxing



            }



            }
        int chinaSum;
        int englishSum;
        int mathSum;
        int maxcht, maxeng, maxmath,mincht,mineng,minmath;
        void maxMinNumber()
            {


                List<int> comcht = new List<int>();
                List<int> comeng = new List<int>();
                List<int> comMath = new List<int>();
                for (int i = 0; i <arrystudent.Count; i++)
                {
                 comcht.Add(arrystudent[i].chinese);
                 maxcht = comcht.Max();
                 mincht = comcht.Min();
                 comeng.Add(arrystudent[i].english);
                 maxeng = comeng.Max();
                 mineng = comeng.Min();
                 comMath.Add(arrystudent[i].math);
                 maxmath = comMath.Max();
                 minmath = comMath.Min();
                }

            labelshow2.Text = $"{"總分",w - 1}" + $"{"    ",w - 1}" + chinaSum + $"{"    ",w - 1}" + englishSum + $"{"    ",w - 1}" + mathSum + "\n"
+ $"{"平均",w - 1}" + $"{"    ",w - 1}" + chinaSum / count_加入次數 + $"{"    ",w}"
+ englishSum / count_加入次數 + $"{"    ",w }" + mathSum / count_加入次數 + "\n"
+ $"{"最高",w-1}" + $"{"    ",w - 1}"+ maxcht + $"{"    ",w}"+ maxeng + $"{"    ",w}"+ maxmath + "\n" 
+$"{"最低",w-1}"+ $"{"    ",w - 1}"+mincht + $"{"    ",w +2}"+mineng + $"{"    ",w +2}"+minmath +"\n";
        }




            ArrayList Lsemp = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
            {

                DataBase data;

                count_加入次數++;
                data.name = name1.Text;
                data.chinese = int.Parse(cha1.Text);
                chinaSum += data.chinese;

                data.english = int.Parse(en1.Text);
                englishSum += data.english;

                data.math = int.Parse(math1.Text);
                mathSum += data.math;

                data.sum = data.chinese + data.english + data.math;
                data.average = Math.Round(data.sum / 3.0, 1);
                if (data.chinese > data.english)
                {
                    data.max = data.chinese;
                    data.min = data.english;
                    data.class_max = "國文";
                    data.class_min = "英文";
                }
                else
                {
                    data.max = data.english;
                    data.min = data.chinese;
                    data.class_max = "英文";
                    data.class_min = "國文";
                }
                if (data.max < data.math)
                {
                    data.max = data.math;
                    data.class_max = "數學";
                }
                if (data.min > data.math)
                {
                    data.min = data.math;
                    data.class_min = "數學";
                }

                Lsemp.Add(data);
                arrystudent.Add(data);

                TableShow();

            }


            //=========================================================================================================
            private void button5_Click(object sender, EventArgs e)
            {
                Random myRandom = new Random();
                DataBase data;

                for (int i = 0; i < 20; i++)
                {
                    count_加入次數++;
                    data.name = count_加入次數.ToString();
                    data.chinese = myRandom.Next(0, 100);
                    data.english = myRandom.Next(0, 100);
                    data.math = myRandom.Next(0, 100);
                    data.sum = data.chinese + data.english + data.math;
                    data.average = Math.Round(data.sum / 3.0, 1);
                    chinaSum += data.chinese;
                    englishSum += data.english;
                    mathSum += data.math;
                    if (data.chinese > data.english)
                    {
                        data.max = data.chinese;
                        data.min = data.english;
                        data.class_max = "國文";
                        data.class_min = "英文";
                    }
                    else
                    {
                        data.max = data.english;
                        data.min = data.chinese;
                        data.class_max = "英文";
                        data.class_min = "國文";
                    }
                    if (data.max < data.math)
                    {
                        data.max = data.math;
                        data.class_max = "數學";
                    }
                    if (data.min > data.math)
                    {
                        data.min = data.math;
                        data.class_min = "數學";
                    }
                    Lsemp.Add(data);
                    arrystudent.Add(data);

                TableShow();

                }

            }
            //=========================================================================
            private void button4_Click(object sender, EventArgs e)
            {
                Lsemp.Clear();
            arrystudent.Clear();
                count_加入次數 = 0;
                TableShow();
            labelshow2.Text = "";

            }
            //===========================================================================
            int count_加入次數 = 0;
            private void button2_Click(object sender, EventArgs e)
            {
                // void Main()
                //{
                Random myRandom = new Random();
                DataBase data;
                count_加入次數++;
                data.name = count_加入次數.ToString();
                data.chinese = myRandom.Next(0, 100);
                data.english = myRandom.Next(0, 100);
                data.math = myRandom.Next(0, 100);
                data.sum = data.chinese + data.english + data.math;
                data.average = Math.Round(data.sum / 3.0, 1);
                chinaSum += data.chinese;
                englishSum += data.english;
                mathSum += data.math;


                if (data.chinese > data.english)
                {
                    data.max = data.chinese;
                    data.min = data.english;
                    data.class_max = "國文";
                    data.class_min = "英文";
                }
                else
                {
                    data.max = data.english;
                    data.min = data.chinese;
                    data.class_max = "英文";
                    data.class_min = "國文";
                }
                if (data.max < data.math)
                {
                    data.max = data.math;
                    data.class_max = "數學";
                }
                if (data.min > data.math)
                {
                    data.min = data.math;
                    data.class_min = "數學";
                }

                Lsemp.Add(data);
                arrystudent.Add(data);

                TableShow();

                //}
            }
            //int chinaSum;
            //int englishSum;
            //int mathSum;
            //int maxcht, maxeng, maxmath;


            private void button3_Click(object sender, EventArgs e)
            {
            maxMinNumber();

                //labelshow2.Text = $"{"總分",w - 1}" + $"{"    ",w - 1}" + chinaSum + $"{"    ",w - 1}" + englishSum + $"{"    ",w - 1}" + mathSum + "\n"
                //    + $"{"平均",w - 1}" + $"{"    ",w - 1}" + chinaSum / count_加入次數 + $"{"    ",w}"
                //    + englishSum / count_加入次數 + $"{"    ",w }" + mathSum / count_加入次數 + "\n"
                //   + $"最高" + maxcht + maxeng + maxmath + "\n" + $"最低\n";


             TableShow();
            }
        }
    }


