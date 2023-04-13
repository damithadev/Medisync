namespace PMS
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
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_sidebar.Controls.Add(this.pnl_logo);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(249, 663);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(249, 143);
            this.pnl_logo.TabIndex = 0;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(249, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(904, 43);
            this.pnl_top.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(249, 43);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(904, 620);
            this.pnl_body.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 663);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_sidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management System";
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_body;
    }
}

