
namespace homework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hi_button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.hellow_but = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Label();
            this.fm = new System.Windows.Forms.Label();
            this.ENname = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hi_button1
            // 
            this.hi_button1.Location = new System.Drawing.Point(21, 288);
            this.hi_button1.Name = "hi_button1";
            this.hi_button1.Size = new System.Drawing.Size(126, 45);
            this.hi_button1.TabIndex = 0;
            this.hi_button1.Text = "say hi";
            this.hi_button1.UseVisualStyleBackColor = true;
            this.hi_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AcceptsReturn = true;
            this.name.Location = new System.Drawing.Point(124, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 1;
            // 
            // hellow_but
            // 
            this.hellow_but.Location = new System.Drawing.Point(199, 288);
            this.hellow_but.Name = "hellow_but";
            this.hellow_but.Size = new System.Drawing.Size(234, 42);
            this.hellow_but.TabIndex = 2;
            this.hellow_but.Text = "say hellow";
            this.hellow_but.UseVisualStyleBackColor = true;
            this.hellow_but.Click += new System.EventHandler(this.hellow_but_Click);
            // 
            // box1
            // 
            this.box1.AutoSize = true;
            this.box1.Location = new System.Drawing.Point(29, 42);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(29, 12);
            this.box1.TabIndex = 3;
            this.box1.Text = "姓名";
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(26, 76);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(29, 12);
            this.b2.TabIndex = 4;
            this.b2.Text = "星座";
            // 
            // fm
            // 
            this.fm.AutoSize = true;
            this.fm.Location = new System.Drawing.Point(27, 104);
            this.fm.Name = "fm";
            this.fm.Size = new System.Drawing.Size(29, 12);
            this.fm.TabIndex = 5;
            this.fm.Text = "性別";
            // 
            // ENname
            // 
            this.ENname.AutoSize = true;
            this.ENname.Location = new System.Drawing.Point(26, 145);
            this.ENname.Name = "ENname";
            this.ENname.Size = new System.Drawing.Size(53, 12);
            this.ENname.TabIndex = 6;
            this.ENname.Text = "英文姓名";
            // 
            // star
            // 
            this.star.Location = new System.Drawing.Point(121, 71);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(102, 22);
            this.star.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 22);
            this.textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.star);
            this.Controls.Add(this.ENname);
            this.Controls.Add(this.fm);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.hellow_but);
            this.Controls.Add(this.name);
            this.Controls.Add(this.hi_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hi_button1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button hellow_but;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Label b2;
        private System.Windows.Forms.Label fm;
        private System.Windows.Forms.Label ENname;
        private System.Windows.Forms.TextBox star;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

