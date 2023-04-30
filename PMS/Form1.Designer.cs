namespace PMS
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_tabs = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_perception = new System.Windows.Forms.Button();
            this.btn_appontments = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(228)))));
            this.pnl_sidebar.Controls.Add(this.pnl_tabs);
            this.pnl_sidebar.Controls.Add(this.pnl_logo);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(288, 771);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(236)))));
            this.pnl_tabs.Controls.Add(this.pictureBox3);
            this.pnl_tabs.Controls.Add(this.pictureBox6);
            this.pnl_tabs.Controls.Add(this.btn_settings);
            this.pnl_tabs.Controls.Add(this.pictureBox5);
            this.pnl_tabs.Controls.Add(this.pictureBox4);
            this.pnl_tabs.Controls.Add(this.pictureBox2);
            this.pnl_tabs.Controls.Add(this.btn_about);
            this.pnl_tabs.Controls.Add(this.btn_perception);
            this.pnl_tabs.Controls.Add(this.btn_appontments);
            this.pnl_tabs.Controls.Add(this.btn_patients);
            this.pnl_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_tabs.Location = new System.Drawing.Point(0, 143);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(288, 628);
            this.pnl_tabs.TabIndex = 1;
            this.pnl_tabs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_tabs_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(21, 312);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_settings.Location = new System.Drawing.Point(0, 292);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(288, 73);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_about
            // 
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_about.Location = new System.Drawing.Point(0, 219);
            this.btn_about.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_about.Size = new System.Drawing.Size(288, 73);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "About";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // btn_perception
            // 
            this.btn_perception.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_perception.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_perception.FlatAppearance.BorderSize = 0;
            this.btn_perception.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_perception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perception.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perception.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_perception.Location = new System.Drawing.Point(0, 146);
            this.btn_perception.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btn_perception.Name = "btn_perception";
            this.btn_perception.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_perception.Size = new System.Drawing.Size(288, 73);
            this.btn_perception.TabIndex = 2;
            this.btn_perception.Text = "Prescriptions";
            this.btn_perception.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perception.UseVisualStyleBackColor = true;
            this.btn_perception.Click += new System.EventHandler(this.btn_perception_Click);
            // 
            // btn_appontments
            // 
            this.btn_appontments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_appontments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_appontments.FlatAppearance.BorderSize = 0;
            this.btn_appontments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_appontments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appontments.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appontments.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_appontments.Location = new System.Drawing.Point(0, 73);
            this.btn_appontments.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btn_appontments.Name = "btn_appontments";
            this.btn_appontments.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_appontments.Size = new System.Drawing.Size(288, 73);
            this.btn_appontments.TabIndex = 1;
            this.btn_appontments.Text = "Appointments";
            this.btn_appontments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appontments.UseVisualStyleBackColor = true;
            this.btn_appontments.Click += new System.EventHandler(this.btn_appontments_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_patients.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.btn_patients.FlatAppearance.BorderSize = 0;
            this.btn_patients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patients.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_patients.Location = new System.Drawing.Point(0, 0);
            this.btn_patients.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_patients.Size = new System.Drawing.Size(288, 73);
            this.btn_patients.TabIndex = 0;
            this.btn_patients.Text = "Patients";
            this.btn_patients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patients.UseVisualStyleBackColor = true;
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(288, 143);
            this.pnl_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 10F);
            this.label1.Location = new System.Drawing.Point(0, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(236)))));
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(288, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(899, 38);
            this.pnl_top.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_body.Location = new System.Drawing.Point(288, 38);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(899, 733);
            this.pnl_body.TabIndex = 2;
            this.pnl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_body_Paint);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 771);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management System";
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_tabs;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_perception;
        private System.Windows.Forms.Button btn_appontments;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

