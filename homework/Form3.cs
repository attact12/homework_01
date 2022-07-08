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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public struct winebase
        {
            public string wineName;
            public double winePrice;


        }

        //void showlabel()
        //{
        //    label_total_show.Text = "尚未購物";
            

        //}
        double count_beer = 0, count_TequilaX=0,count_威士忌=0,count_紅酒=0, total_總金額, totalprice_beer = 0, totalprice_TequilaX = 0, totalprice_威士忌, totalprice_紅酒;
        //decimal totalprice_beer = 0, totalprice_TequilaX=0,totalprice_威士忌,totalprice_紅酒 ;

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + total_總金額.ToString(), "確認付款", MessageBoxButtons.OKCancel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double total_折扣;
            total_折扣 = total_總金額 * 0.9;
            MessageBox.Show("總金額: NT$" + total_折扣.ToString(), "確認付款",MessageBoxButtons.OKCancel);
        }

        string labeShow = " ", str_啤酒 = " ", str_龍舌蘭 = " ", str_紅酒 = " ", str_威士忌 = " ";

        List<winebase> win_app = new List<winebase>();

        private void button4_Click(object sender, EventArgs e)
        {
            winebase win_類別 = new winebase();
            win_類別.wineName = "紅酒";
            count_紅酒++;
            win_類別.winePrice += 180 * count_紅酒;
            totalprice_紅酒 += win_類別.winePrice;
            win_app.Add(win_類別);

            str_紅酒 = "紅酒wine" + count_紅酒 + " ,共NT$:" + win_類別.winePrice + "元";
            labeShow = str_啤酒 + "\n" + str_龍舌蘭 + "\n" + str_威士忌 + "\n" + str_紅酒 + "\n";
            label_total_show.Text = labeShow;
            total_總金額 += win_類別.winePrice;
            text_totalPay.Text = "NT$"+total_總金額.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            winebase win_類別 = new winebase();
            win_類別.wineName = "威士忌";
            count_威士忌++;
            win_類別.winePrice += 180 * count_威士忌;
            totalprice_威士忌 += win_類別.winePrice;
            win_app.Add(win_類別);

            str_威士忌 = "威士忌Whisky" + count_威士忌 + " ,共NT$:" + win_類別.winePrice + "元";
            labeShow = str_啤酒 + "\n" + str_龍舌蘭 + "\n" + str_威士忌 + "\n" + str_紅酒 + "\n";
            label_total_show.Text = labeShow;
            total_總金額 += win_類別.winePrice;
            text_totalPay.Text = "NT$"+ total_總金額.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            winebase win_類別 = new winebase();
            win_類別.wineName= "啤酒";

            count_beer++;
            win_類別.winePrice += 120 * count_beer;
            totalprice_beer += win_類別.winePrice;

            win_app.Add(win_類別);

            str_啤酒 = "啤酒beerX" + count_beer + " ,共NT$:" + win_類別.winePrice + "元";
            labeShow = str_啤酒 + "\n" + str_龍舌蘭 + "\n" + str_威士忌 + "\n" + str_紅酒 + "\n";
            label_total_show.Text = labeShow;
            total_總金額 += win_類別.winePrice;
            text_totalPay.Text = "NT$"+total_總金額.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            win_app.Clear();
            label_total_show.Text = "尚未購物";
            total_總金額 = 0;
            text_totalPay.Text = "NT$"+total_總金額.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winebase win_類別 = new winebase();
            win_類別.wineName = "龍舌蘭";
            count_TequilaX++;
            win_類別.winePrice+= 180 * count_TequilaX;
            totalprice_TequilaX  += win_類別.winePrice;

            win_app.Add(win_類別);

            str_龍舌蘭 = "龍舌蘭TequilaX" + count_TequilaX + " ,共NT$:" + win_類別.winePrice + "元";
            labeShow = str_啤酒 +"\n"+ str_龍舌蘭 +"\n"+ str_威士忌 +"\n"+ str_紅酒+"\n";
            label_total_show.Text = labeShow;
            total_總金額 += win_類別.winePrice;
            text_totalPay.Text = "NT$"+total_總金額.ToString();
        }
    }
}
