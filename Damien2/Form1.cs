using System;
using System.Windows.Forms;

namespace Damien2
{
    public partial class Form1 : Form
    {
        public string FormType = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
 

            if (FormType == "patient")
            {
               PatientForm patient = new PatientForm();
               patient.OnSubmit = OnPatientSubmitted;
               patient.Show();
            }
            else if (FormType == "doctor")
            {
               DoctorForm doctor = new DoctorForm();
               doctor.OnSubmit = OnDoctorSubmitted;
               doctor.Show();
            }
            else if (FormType == "nurse")
            {
                NurseForm nurse = new NurseForm();
                nurse.OnSubmit = OnNurseSubmitted;
                nurse.Show();
            }
            else if (FormType == "parttime")
            {
                PartTimeForm parttime = new PartTimeForm();
                parttime.OnSubmit = OnPartTimeSubmitted;
                parttime.Show();
            }
        }

        private void radiobtnPatient_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnPatient.Checked)
            {
                FormType = "patient";
            }
        }

        private void OnPatientSubmitted(string fn, string ln, string dob, string County, string Email, string Phone)
        {
            
        }
        //  DOCTOR
      

        private void OnDoctorSubmitted(string Lung, string Heart, string EmployeeNumber)
        {

        }

        private void radioBtnDoctor_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                FormType = "doctor";
            }
        }
        //Nurse
        private void OnNurseSubmitted(string Firstname, string Salery, string EmployeeNumber)
        {

        }

        private void BtnNurse_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                FormType = "nurse";
            }
        }
        //Part Time
        private void OnPartTimeSubmitted(string Firstname, string Lastname, string Phone, string Hourse, string EmployeeNumber)
        {

        }
        private void radioBtnPartTime_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                FormType = "parttime";
            }
        }
        

    }
}
