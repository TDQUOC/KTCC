namespace KTCC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textboxusernam = new System.Windows.Forms.TextBox();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textboxusernam
            // 
            this.textboxusernam.Location = new System.Drawing.Point(169, 67);
            this.textboxusernam.Name = "textboxusernam";
            this.textboxusernam.Size = new System.Drawing.Size(316, 23);
            this.textboxusernam.TabIndex = 1;
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(169, 123);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(316, 23);
            this.textboxmatkhau.TabIndex = 3;
            this.textboxmatkhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(212, 163);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(197, 84);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 270);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxusernam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textboxusernam;
        private TextBox textboxmatkhau;
        private Label label2;
        private Button btnlogin;
    }
}