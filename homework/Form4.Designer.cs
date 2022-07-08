
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
            this.label1_tx = new System.Windows.Forms.Label();
            this.butguess = new System.Windows.Forms.Button();
            this.butshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_tx
            // 
            this.label1_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_tx.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_tx.Location = new System.Drawing.Point(165, 76);
            this.label1_tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_tx.Name = "label1_tx";
            this.label1_tx.Size = new System.Drawing.Size(465, 122);
            this.label1_tx.TabIndex = 0;
            this.label1_tx.Text = "0-100猜數字";
            // 
            // butguess
            // 
            this.butguess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butguess.Location = new System.Drawing.Point(217, 132);
            this.butguess.Margin = new System.Windows.Forms.Padding(4);
            this.butguess.Name = "butguess";
            this.butguess.Size = new System.Drawing.Size(145, 40);
            this.butguess.TabIndex = 1;
            this.butguess.Text = "guess";
            this.butguess.UseVisualStyleBackColor = true;
            this.butguess.Click += new System.EventHandler(this.butguess_Click);
            // 
            // butshow
            // 
            this.butshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butshow.Location = new System.Drawing.Point(431, 132);
            this.butshow.Margin = new System.Windows.Forms.Padding(4);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(173, 40);
            this.butshow.TabIndex = 2;
            this.butshow.Text = "showanswer";
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.butguess);
            this.Controls.Add(this.label1_tx);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_tx;
        private System.Windows.Forms.Button butguess;
        private System.Windows.Forms.Button butshow;
    }
}