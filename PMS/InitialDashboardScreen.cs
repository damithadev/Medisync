using Guna.UI2.WinForms;
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
      
        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pnl_tabs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetDefaultButtonImages()
        {
            // Set the default images for all buttons
            overviewButton.Image = Properties.Resources.overviewDefaultImg;
            patientButton.Image = Properties.Resources.patientDefaultImg;
            appointmentButton.Image = Properties.Resources.appointmentDefaultImg;
            prescriptionButton.Image = Properties.Resources.prescriptionDefaultImg;
            settingssButton.Image = Properties.Resources.settingssDefaultImg;

        }

        private void SetSelectedButtonImage(Guna2ImageButton button)
        {
            // Set the selected image for the specified button
            if (button == overviewButton)
            {
                button.Image = Properties.Resources.overviewSetImg;
            }
            else if (button == patientButton)
            {
                button.Image = Properties.Resources.patientSetImg;
            }
            else if (button == appointmentButton)
            {
                button.Image = Properties.Resources.appointmentSetImg;
            }
            else if (button == prescriptionButton)
            {
                button.Image = Properties.Resources.prescriptionSetImg;
            }
            else
            {
                button.Image = Properties.Resources.settingstSetImg;
            }
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
            SetDefaultButtonImages(); // Reset all buttons to default images
            SetSelectedButtonImage(overviewButton); // Set selected image for the clicked button
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientScreen());
            SetDefaultButtonImages(); // Reset all buttons to default images
            SetSelectedButtonImage(patientButton); // Set selected image for the clicked button
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentScreen());
            SetDefaultButtonImages(); // Reset all buttons to default images
            SetSelectedButtonImage(appointmentButton); // Set selected image for the clicked button
        }

        private void Prescriptionbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new PerceptionScreen());
            SetDefaultButtonImages(); // Reset all buttons to default images
            SetSelectedButtonImage(prescriptionButton); // Set selected image for the clicked button
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsScreen());
            SetDefaultButtonImages(); // Reset all buttons to default images
            SetSelectedButtonImage(settingssButton); // Set selected image for the clicked button
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
