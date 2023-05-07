namespace PMS
{
    partial class PopupMessage
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
            this.lbl_popup = new System.Windows.Forms.Label();
            this.btn_okpopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_popup
            // 
            this.lbl_popup.AutoSize = true;
            this.lbl_popup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popup.Location = new System.Drawing.Point(99, 69);
            this.lbl_popup.Name = "lbl_popup";
            this.lbl_popup.Size = new System.Drawing.Size(51, 25);
            this.lbl_popup.TabIndex = 0;
            this.lbl_popup.Text = "Text";
            // 
            // btn_okpopup
            // 
            this.btn_okpopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okpopup.Location = new System.Drawing.Point(164, 170);
            this.btn_okpopup.Name = "btn_okpopup";
            this.btn_okpopup.Size = new System.Drawing.Size(96, 28);
            this.btn_okpopup.TabIndex = 1;
            this.btn_okpopup.Text = "OK";
            this.btn_okpopup.UseVisualStyleBackColor = true;
            this.btn_okpopup.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopupMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 250);
            this.Controls.Add(this.btn_okpopup);
            this.Controls.Add(this.lbl_popup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_popup;
        private System.Windows.Forms.Button btn_okpopup;
    }
}