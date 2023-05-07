namespace PMS
{
    partial class SignUpScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.textBoxfname = new System.Windows.Forms.TextBox();
            this.textBoxlname = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxpassword1 = new System.Windows.Forms.TextBox();
            this.textBoxpassword2 = new System.Windows.Forms.TextBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(438, 153);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 16);
            this.label.TabIndex = 2;
            this.label.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Re-type Password";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(601, 455);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(81, 30);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // textBoxfname
            // 
            this.textBoxfname.Location = new System.Drawing.Point(601, 147);
            this.textBoxfname.Name = "textBoxfname";
            this.textBoxfname.Size = new System.Drawing.Size(153, 22);
            this.textBoxfname.TabIndex = 6;
            // 
            // textBoxlname
            // 
            this.textBoxlname.Location = new System.Drawing.Point(601, 202);
            this.textBoxlname.Name = "textBoxlname";
            this.textBoxlname.Size = new System.Drawing.Size(153, 22);
            this.textBoxlname.TabIndex = 7;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(601, 256);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(153, 22);
            this.textBoxemail.TabIndex = 8;
            // 
            // textBoxpassword1
            // 
            this.textBoxpassword1.Location = new System.Drawing.Point(601, 306);
            this.textBoxpassword1.Name = "textBoxpassword1";
            this.textBoxpassword1.Size = new System.Drawing.Size(153, 22);
            this.textBoxpassword1.TabIndex = 9;
            // 
            // textBoxpassword2
            // 
            this.textBoxpassword2.Location = new System.Drawing.Point(601, 367);
            this.textBoxpassword2.Name = "textBoxpassword2";
            this.textBoxpassword2.Size = new System.Drawing.Size(153, 22);
            this.textBoxpassword2.TabIndex = 10;
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(931, 25);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(80, 27);
            this.Close_btn.TabIndex = 11;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 619);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.textBoxpassword2);
            this.Controls.Add(this.textBoxpassword1);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxlname);
            this.Controls.Add(this.textBoxfname);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox textBoxfname;
        private System.Windows.Forms.TextBox textBoxlname;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxpassword1;
        private System.Windows.Forms.TextBox textBoxpassword2;
        private System.Windows.Forms.Button Close_btn;
    }
}