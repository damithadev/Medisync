using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) 
            { 
                activeForm.Close(); 
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(childForm);
            pnl_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
            


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            openChildForm(new OverviewScreen());
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_appontments_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientScreen());
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_perception_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentScreen());
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            openChildForm(new PerceptionScreen());
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsScreen());
        }

        private void pnl_tabs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            openChildForm(new OverviewScreen());
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OverviewScreen());
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientScreen());
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentScreen());
        }

        private void Prescriptionbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new PerceptionScreen());
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsScreen());
        }
    }
}
