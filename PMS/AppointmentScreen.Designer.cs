namespace PMS
{
    partial class AppointmentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nicbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.diagnosisbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.snotesbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textBoxTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.ampmcmbbox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment Dashboard";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1228, 859);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Diagnosis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Special Notes";
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
            this.nicbox.Location = new System.Drawing.Point(369, 197);
            this.nicbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nicbox.Name = "nicbox";
            this.nicbox.PasswordChar = '\0';
            this.nicbox.PlaceholderText = "";
            this.nicbox.SelectedText = "";
            this.nicbox.Size = new System.Drawing.Size(340, 37);
            this.nicbox.TabIndex = 7;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(75)))), ((int)(((byte)(253)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(369, 275);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(340, 36);
            this.guna2DateTimePicker1.TabIndex = 8;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // diagnosisbox
            // 
            this.diagnosisbox.BorderRadius = 10;
            this.diagnosisbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diagnosisbox.DefaultText = "";
            this.diagnosisbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.diagnosisbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.diagnosisbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diagnosisbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diagnosisbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diagnosisbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.diagnosisbox.ForeColor = System.Drawing.Color.Black;
            this.diagnosisbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diagnosisbox.Location = new System.Drawing.Point(369, 443);
            this.diagnosisbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.diagnosisbox.Name = "diagnosisbox";
            this.diagnosisbox.PasswordChar = '\0';
            this.diagnosisbox.PlaceholderText = "";
            this.diagnosisbox.SelectedText = "";
            this.diagnosisbox.Size = new System.Drawing.Size(340, 37);
            this.diagnosisbox.TabIndex = 10;
            // 
            // snotesbox
            // 
            this.snotesbox.BorderRadius = 10;
            this.snotesbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.snotesbox.DefaultText = "";
            this.snotesbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.snotesbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.snotesbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.snotesbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.snotesbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.snotesbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.snotesbox.ForeColor = System.Drawing.Color.Black;
            this.snotesbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.snotesbox.Location = new System.Drawing.Point(369, 524);
            this.snotesbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.snotesbox.Name = "snotesbox";
            this.snotesbox.PasswordChar = '\0';
            this.snotesbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.snotesbox.PlaceholderText = "*Optional ";
            this.snotesbox.SelectedText = "";
            this.snotesbox.Size = new System.Drawing.Size(340, 97);
            this.snotesbox.TabIndex = 11;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(369, 691);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton1.Size = new System.Drawing.Size(125, 54);
            this.guna2ImageButton1.TabIndex = 12;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
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
            this.guna2ImageButton2.Location = new System.Drawing.Point(559, 691);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(95, 35);
            this.guna2ImageButton2.Size = new System.Drawing.Size(125, 54);
            this.guna2ImageButton2.TabIndex = 13;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.BorderRadius = 10;
            this.textBoxTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTime.DefaultText = "10:45";
            this.textBoxTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTime.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxTime.ForeColor = System.Drawing.Color.Black;
            this.textBoxTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTime.Location = new System.Drawing.Point(369, 360);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.PasswordChar = '\0';
            this.textBoxTime.PlaceholderText = "";
            this.textBoxTime.SelectedText = "";
            this.textBoxTime.Size = new System.Drawing.Size(340, 48);
            this.textBoxTime.TabIndex = 15;
            // 
            // ampmcmbbox
            // 
            this.ampmcmbbox.BackColor = System.Drawing.Color.Transparent;
            this.ampmcmbbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ampmcmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ampmcmbbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ampmcmbbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ampmcmbbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ampmcmbbox.ForeColor = System.Drawing.Color.Black;
            this.ampmcmbbox.ItemHeight = 30;
            this.ampmcmbbox.Items.AddRange(new object[] {
            "A.M.",
            "P.M."});
            this.ampmcmbbox.Location = new System.Drawing.Point(591, 361);
            this.ampmcmbbox.Name = "ampmcmbbox";
            this.ampmcmbbox.Size = new System.Drawing.Size(118, 36);
            this.ampmcmbbox.StartIndex = 0;
            this.ampmcmbbox.TabIndex = 16;
            // 
            // AppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 845);
            this.Controls.Add(this.ampmcmbbox);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.snotesbox);
            this.Controls.Add(this.diagnosisbox);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.nicbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "AppointmentScreen";
            this.Text = "frm_appointment";
            this.Load += new System.EventHandler(this.frm_appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox nicbox;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox diagnosisbox;
        private Guna.UI2.WinForms.Guna2TextBox snotesbox;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTime;
        private Guna.UI2.WinForms.Guna2ComboBox ampmcmbbox;
    }
}