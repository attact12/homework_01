
namespace homework
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_totalPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_total_show = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "啤酒\r\nBeer\r\nNT$120\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "威士忌\r\nWhisky\r\nNT$350\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "紅酒\r\nwine\r\nNT$320";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 271);
            this.label1.TabIndex = 6;
            this.label1.Text = "菜單Menu";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(314, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 81);
            this.label2.TabIndex = 7;
            this.label2.Text = "總金額 Total Price";
            // 
            // text_totalPay
            // 
            this.text_totalPay.BackColor = System.Drawing.SystemColors.WindowText;
            this.text_totalPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_totalPay.ForeColor = System.Drawing.SystemColors.Window;
            this.text_totalPay.Location = new System.Drawing.Point(337, 74);
            this.text_totalPay.Multiline = true;
            this.text_totalPay.Name = "text_totalPay";
            this.text_totalPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_totalPay.Size = new System.Drawing.Size(139, 29);
            this.text_totalPay.TabIndex = 8;
            this.text_totalPay.Text = "0";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(315, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 111);
            this.label3.TabIndex = 9;
            this.label3.Text = "付款方式";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "現金";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(407, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "信用卡";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(409, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "信用卡9折";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(506, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 271);
            this.label5.TabIndex = 13;
            this.label5.Text = "購物清單List";
            // 
            // label_total_show
            // 
            this.label_total_show.AutoEllipsis = true;
            this.label_total_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_total_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_total_show.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_total_show.Location = new System.Drawing.Point(513, 54);
            this.label_total_show.Name = "label_total_show";
            this.label_total_show.Size = new System.Drawing.Size(274, 176);
            this.label_total_show.TabIndex = 14;
            this.label_total_show.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(665, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 25);
            this.button7.TabIndex = 15;
            this.button7.Text = "清除清單";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label_total_show);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_totalPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_totalPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_total_show;
        private System.Windows.Forms.Button button7;
    }
}