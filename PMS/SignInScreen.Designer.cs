namespace PMS
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(828, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t have an account? Sign up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.BorderRadius = 10;
            this.textBoxemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxemail.DefaultText = "";
            this.textBoxemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxemail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.textBoxemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxemail.ForeColor = System.Drawing.Color.Black;
            this.textBoxemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxemail.Location = new System.Drawing.Point(777, 283);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.PasswordChar = '\0';
            this.textBoxemail.PlaceholderText = "";
            this.textBoxemail.SelectedText = "";
            this.textBoxemail.Size = new System.Drawing.Size(351, 37);
            this.textBoxemail.TabIndex = 9;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BorderRadius = 10;
            this.textBoxpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxpassword.DefaultText = "";
            this.textBoxpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.textBoxpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxpassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxpassword.Location = new System.Drawing.Point(777, 423);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '\0';
            this.textBoxpassword.PlaceholderText = "";
            this.textBoxpassword.SelectedText = "";
            this.textBoxpassword.Size = new System.Drawing.Size(351, 37);
            this.textBoxpassword.TabIndex = 10;
            // 
            // closebtn
            // 
            this.closebtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closebtn.ImageRotate = 0F;
            this.closebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Location = new System.Drawing.Point(1178, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Size = new System.Drawing.Size(64, 54);
            this.closebtn.TabIndex = 13;
            this.closebtn.Click += new System.EventHandler(this.closeBtn_click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(96, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(96, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(957, 493);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(96, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(156, 69);
            this.guna2ImageButton1.TabIndex = 12;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.HoverState.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("Loginbtn.Image")));
            this.Loginbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Loginbtn.ImageRotate = 0F;
            this.Loginbtn.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Location = new System.Drawing.Point(777, 493);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.PressedState.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Size = new System.Drawing.Size(143, 69);
            this.Loginbtn.TabIndex = 11;
            this.Loginbtn.Click += new System.EventHandler(this.loginBtn_click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1243, 687);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(821, 91);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(278, 60);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInScreen";
            this.Load += new System.EventHandler(this.SignInScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxemail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxpassword;
        private Guna.UI2.WinForms.Guna2ImageButton Loginbtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton closebtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}