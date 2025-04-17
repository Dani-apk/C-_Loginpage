using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damien2
{
    public partial class PatientForm : Form
    {
        List<Patient> pan = new List<Patient>();

        public delegate void OnSubmitDelegate(string FirstName, string LastName, string dob, string County, string Email, string Phone);
        public OnSubmitDelegate OnSubmit;
        public PatientForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
                string fn = txtFirstname.Text;
                string ln = txtSurname.Text;
                string dob = dtpdob.Text;
                string cu = comboBoxCounty.Text;
                string em = txtEmail.Text;
                string ph = txtPhone.Text;
            
            Patient pant = new Patient(fn, ln, dob, cu, em, ph);
            pan.Add(pant);
        }

         private void btnPatient_Click(object sender, EventArgs e)
         {
            dgv.DataSource = false;
            dgv.DataSource = pan;
         }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            comboBoxCounty.DataSource = Enum.GetValues(typeof(Counties));
        }

        private void lblPay_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
