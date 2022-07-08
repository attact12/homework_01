
namespace homework
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.entxt = new System.Windows.Forms.TextBox();
            this.chinatxt = new System.Windows.Forms.TextBox();
            this.mathtxt = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.maxgrade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "英文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "國文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "數學";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(117, 29);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(125, 22);
            this.nametxt.TabIndex = 6;
            // 
            // entxt
            // 
            this.entxt.Location = new System.Drawing.Point(117, 70);
            this.entxt.Name = "entxt";
            this.entxt.Size = new System.Drawing.Size(125, 22);
            this.entxt.TabIndex = 7;
            // 
            // chinatxt
            // 
            this.chinatxt.Location = new System.Drawing.Point(117, 128);
            this.chinatxt.Name = "chinatxt";
            this.chinatxt.Size = new System.Drawing.Size(125, 22);
            this.chinatxt.TabIndex = 8;
            // 
            // mathtxt
            // 
            this.mathtxt.Location = new System.Drawing.Point(117, 185);
            this.mathtxt.Name = "mathtxt";
            this.mathtxt.Size = new System.Drawing.Size(125, 22);
            this.mathtxt.TabIndex = 9;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grade.Location = new System.Drawing.Point(6, 18);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(70, 27);
            this.grade.TabIndex = 10;
            this.grade.Text = "姓名";
            this.grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxgrade
            // 
            this.maxgrade.AutoSize = true;
            this.maxgrade.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maxgrade.Location = new System.Drawing.Point(6, 164);
            this.maxgrade.Name = "maxgrade";
            this.maxgrade.Size = new System.Drawing.Size(102, 21);
            this.maxgrade.TabIndex = 11;
            this.maxgrade.Text = "最高最低";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxgrade);
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Location = new System.Drawing.Point(442, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 261);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "最高分/最低分";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mathtxt);
            this.Controls.Add(this.chinatxt);
            this.Controls.Add(this.entxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox entxt;
        private System.Windows.Forms.TextBox chinatxt;
        private System.Windows.Forms.TextBox mathtxt;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label maxgrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}