
namespace homework
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.butguess = new System.Windows.Forms.Button();
            this.butshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "0-100猜數字";
            // 
            // butguess
            // 
            this.butguess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butguess.Location = new System.Drawing.Point(163, 106);
            this.butguess.Name = "butguess";
            this.butguess.Size = new System.Drawing.Size(109, 32);
            this.butguess.TabIndex = 1;
            this.butguess.Text = "guess";
            this.butguess.UseVisualStyleBackColor = true;
            this.butguess.Click += new System.EventHandler(this.butguess_Click);
            // 
            // butshow
            // 
            this.butshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butshow.Location = new System.Drawing.Point(323, 106);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(130, 32);
            this.butshow.TabIndex = 2;
            this.butshow.Text = "showanswer";
            this.butshow.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.butguess);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butguess;
        private System.Windows.Forms.Button butshow;
    }
}