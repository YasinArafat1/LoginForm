namespace WindowsFormsApp1_making_simple_login_page
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Username = new System.Windows.Forms.TextBox();
            this.textBox2_Password = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "User_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // textBox1_Username
            // 
            this.textBox1_Username.Location = new System.Drawing.Point(336, 138);
            this.textBox1_Username.Multiline = true;
            this.textBox1_Username.Name = "textBox1_Username";
            this.textBox1_Username.Size = new System.Drawing.Size(274, 47);
            this.textBox1_Username.TabIndex = 0;
            // 
            // textBox2_Password
            // 
            this.textBox2_Password.Location = new System.Drawing.Point(336, 218);
            this.textBox2_Password.Multiline = true;
            this.textBox2_Password.Name = "textBox2_Password";
            this.textBox2_Password.Size = new System.Drawing.Size(274, 48);
            this.textBox2_Password.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(357, 309);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(192, 64);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(187, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 67);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox2_Password);
            this.Controls.Add(this.textBox1_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Username;
        private System.Windows.Forms.TextBox textBox2_Password;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

