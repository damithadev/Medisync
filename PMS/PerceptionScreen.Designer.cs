namespace PMS
{
    partial class PerceptionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerceptionScreen));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nicbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drugbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dosebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.testbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.billbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1228, 859);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prescription Dashboard";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton1.Location = new System.Drawing.Point(143, 656);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton1.Size = new System.Drawing.Size(124, 54);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.Click += new System.EventHandler(this.createbtnclick);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton2.Location = new System.Drawing.Point(325, 656);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton2.Size = new System.Drawing.Size(124, 54);
            this.guna2ImageButton2.TabIndex = 3;
            this.guna2ImageButton2.Click += new System.EventHandler(this.cancelbtnclick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIC";
            // 
            // nicbox
            // 
            this.nicbox.BorderRadius = 10;
            this.nicbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nicbox.DefaultText = "";
            this.nicbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nicbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nicbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.nicbox.ForeColor = System.Drawing.Color.Black;
            this.nicbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicbox.Location = new System.Drawing.Point(288, 177);
            this.nicbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nicbox.Name = "nicbox";
            this.nicbox.PasswordChar = '\0';
            this.nicbox.PlaceholderText = "";
            this.nicbox.SelectedText = "";
            this.nicbox.Size = new System.Drawing.Size(340, 37);
            this.nicbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Drug";
            // 
            // drugbox
            // 
            this.drugbox.BorderRadius = 10;
            this.drugbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drugbox.DefaultText = "";
            this.drugbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.drugbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.drugbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.drugbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.drugbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.drugbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.drugbox.ForeColor = System.Drawing.Color.Black;
            this.drugbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.drugbox.Location = new System.Drawing.Point(288, 251);
            this.drugbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.drugbox.Name = "drugbox";
            this.drugbox.PasswordChar = '\0';
            this.drugbox.PlaceholderText = "";
            this.drugbox.SelectedText = "";
            this.drugbox.Size = new System.Drawing.Size(340, 37);
            this.drugbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dose";
            // 
            // dosebox
            // 
            this.dosebox.BorderRadius = 10;
            this.dosebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dosebox.DefaultText = "";
            this.dosebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dosebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dosebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dosebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dosebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dosebox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dosebox.ForeColor = System.Drawing.Color.Black;
            this.dosebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dosebox.Location = new System.Drawing.Point(288, 326);
            this.dosebox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dosebox.Name = "dosebox";
            this.dosebox.PasswordChar = '\0';
            this.dosebox.PlaceholderText = "";
            this.dosebox.SelectedText = "";
            this.dosebox.Size = new System.Drawing.Size(340, 37);
            this.dosebox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duration";
            // 
            // durationbox
            // 
            this.durationbox.BorderRadius = 10;
            this.durationbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.durationbox.DefaultText = "";
            this.durationbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.durationbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.durationbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.durationbox.ForeColor = System.Drawing.Color.Black;
            this.durationbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationbox.Location = new System.Drawing.Point(288, 397);
            this.durationbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.durationbox.Name = "durationbox";
            this.durationbox.PasswordChar = '\0';
            this.durationbox.PlaceholderText = "";
            this.durationbox.SelectedText = "";
            this.durationbox.Size = new System.Drawing.Size(340, 37);
            this.durationbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tests";
            // 
            // testbox
            // 
            this.testbox.BorderRadius = 10;
            this.testbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.testbox.DefaultText = "";
            this.testbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.testbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.testbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.testbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.testbox.ForeColor = System.Drawing.Color.Black;
            this.testbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.testbox.Location = new System.Drawing.Point(288, 473);
            this.testbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.testbox.Name = "testbox";
            this.testbox.PasswordChar = '\0';
            this.testbox.PlaceholderText = "";
            this.testbox.SelectedText = "";
            this.testbox.Size = new System.Drawing.Size(340, 37);
            this.testbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bill Amount";
            // 
            // billbox
            // 
            this.billbox.BorderRadius = 10;
            this.billbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billbox.DefaultText = "";
            this.billbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.billbox.ForeColor = System.Drawing.Color.Black;
            this.billbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billbox.Location = new System.Drawing.Point(288, 552);
            this.billbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.billbox.Name = "billbox";
            this.billbox.PasswordChar = '\0';
            this.billbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.billbox.PlaceholderText = "Rs:";
            this.billbox.SelectedText = "";
            this.billbox.Size = new System.Drawing.Size(340, 37);
            this.billbox.TabIndex = 20;
            // 
            // PerceptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 869);
            this.Controls.Add(this.billbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.durationbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dosebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drugbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nicbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "PerceptionScreen";
            this.Text = "PerceptionScreen";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nicbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox drugbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox dosebox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox durationbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox testbox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox billbox;
    }
}