namespace PMS
{
    partial class frm_patient
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
            this.grid_patient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grid_patient
            // 
            this.grid_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patient.Location = new System.Drawing.Point(17, 86);
            this.grid_patient.Name = "grid_patient";
            this.grid_patient.RowHeadersWidth = 51;
            this.grid_patient.RowTemplate.Height = 24;
            this.grid_patient.Size = new System.Drawing.Size(1249, 489);
            this.grid_patient.TabIndex = 1;
            // 
            // frm_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 587);
            this.Controls.Add(this.grid_patient);
            this.Controls.Add(this.label1);
            this.Name = "frm_patient";
            this.Text = "frm_patient";
            this.Load += new System.EventHandler(this.frm_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_patient;
    }
}