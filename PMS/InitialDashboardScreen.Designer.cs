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
            this.settingssButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.prescriptionButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.appointmentButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.patientButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.overviewButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_tabs.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.pnl_sidebar.Size = new System.Drawing.Size(288, 930);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(75)))), ((int)(((byte)(253)))));
            this.pnl_tabs.Controls.Add(this.guna2ImageButton1);
            this.pnl_tabs.Controls.Add(this.settingssButton);
            this.pnl_tabs.Controls.Add(this.prescriptionButton);
            this.pnl_tabs.Controls.Add(this.appointmentButton);
            this.pnl_tabs.Controls.Add(this.patientButton);
            this.pnl_tabs.Controls.Add(this.overviewButton);
            this.pnl_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_tabs.Location = new System.Drawing.Point(0, 143);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(288, 787);
            this.pnl_tabs.TabIndex = 1;
            this.pnl_tabs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_tabs_Paint);
            // 
            // settingssButton
            // 
            this.settingssButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.settingssButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingssButton.HoverState.Image = global::PMS.Properties.Resources.settingstSetImg;
            this.settingssButton.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.settingssButton.Image = global::PMS.Properties.Resources.settingssDefaultImg;
            this.settingssButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.settingssButton.ImageRotate = 0F;
            this.settingssButton.ImageSize = new System.Drawing.Size(207, 57);
            this.settingssButton.Location = new System.Drawing.Point(0, 320);
            this.settingssButton.Name = "settingssButton";
            this.settingssButton.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.settingssButton.Size = new System.Drawing.Size(288, 80);
            this.settingssButton.TabIndex = 17;
            this.settingssButton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // prescriptionButton
            // 
            this.prescriptionButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.prescriptionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.prescriptionButton.HoverState.Image = global::PMS.Properties.Resources.prescriptionSetImg;
            this.prescriptionButton.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.prescriptionButton.Image = global::PMS.Properties.Resources.prescriptionDefaultImg;
            this.prescriptionButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.prescriptionButton.ImageRotate = 0F;
            this.prescriptionButton.ImageSize = new System.Drawing.Size(207, 57);
            this.prescriptionButton.Location = new System.Drawing.Point(0, 240);
            this.prescriptionButton.Name = "prescriptionButton";
            this.prescriptionButton.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.prescriptionButton.Size = new System.Drawing.Size(288, 80);
            this.prescriptionButton.TabIndex = 16;
            this.prescriptionButton.Click += new System.EventHandler(this.Prescriptionbutton_Click);
            // 
            // appointmentButton
            // 
            this.appointmentButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.appointmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentButton.HoverState.Image = global::PMS.Properties.Resources.appointmentSetImg;
            this.appointmentButton.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.appointmentButton.Image = global::PMS.Properties.Resources.appointmentDefaultImg;
            this.appointmentButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.appointmentButton.ImageRotate = 0F;
            this.appointmentButton.ImageSize = new System.Drawing.Size(207, 57);
            this.appointmentButton.Location = new System.Drawing.Point(0, 160);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.appointmentButton.Size = new System.Drawing.Size(288, 80);
            this.appointmentButton.TabIndex = 15;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.patientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButton.HoverState.Image = global::PMS.Properties.Resources.patientSetImg;
            this.patientButton.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.patientButton.Image = global::PMS.Properties.Resources.patientDefaultImg;
            this.patientButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.patientButton.ImageRotate = 0F;
            this.patientButton.ImageSize = new System.Drawing.Size(207, 57);
            this.patientButton.Location = new System.Drawing.Point(0, 80);
            this.patientButton.Name = "patientButton";
            this.patientButton.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.patientButton.Size = new System.Drawing.Size(288, 80);
            this.patientButton.TabIndex = 14;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // overviewButton
            // 
            this.overviewButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.overviewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewButton.HoverState.Image = global::PMS.Properties.Resources.overviewSetImg;
            this.overviewButton.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.overviewButton.Image = global::PMS.Properties.Resources.overviewDefaultImg;
            this.overviewButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.overviewButton.ImageRotate = 0F;
            this.overviewButton.ImageSize = new System.Drawing.Size(207, 57);
            this.overviewButton.Location = new System.Drawing.Point(0, 0);
            this.overviewButton.Name = "overviewButton";
            this.overviewButton.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.overviewButton.Size = new System.Drawing.Size(288, 80);
            this.overviewButton.TabIndex = 13;
            this.overviewButton.Click += new System.EventHandler(this.overviewButton_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_logo.Controls.Add(this.guna2PictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(288, 143);
            this.pnl_logo.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(288, 143);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(75)))), ((int)(((byte)(253)))));
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(288, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1334, 38);
            this.pnl_top.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_body.Location = new System.Drawing.Point(288, 38);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1334, 892);
            this.pnl_body.TabIndex = 2;
            this.pnl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_body_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ImageButton1.HoverState.Image = global::PMS.Properties.Resources.logoutDefaultImg;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(207, 57);
            this.guna2ImageButton1.Image = global::PMS.Properties.Resources.logoutDefaultImg;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(207, 57);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 707);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(207, 57);
            this.guna2ImageButton1.Size = new System.Drawing.Size(288, 80);
            this.guna2ImageButton1.TabIndex = 18;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 930);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1640, 977);
            this.MinimumSize = new System.Drawing.Size(1640, 977);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management System";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_tabs.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_tabs;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton overviewButton;
        private Guna.UI2.WinForms.Guna2ImageButton patientButton;
        private Guna.UI2.WinForms.Guna2ImageButton appointmentButton;
        private Guna.UI2.WinForms.Guna2ImageButton prescriptionButton;
        private Guna.UI2.WinForms.Guna2ImageButton settingssButton;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

