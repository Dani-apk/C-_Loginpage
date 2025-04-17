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
    public partial class NurseForm : Form
    {
        List<Nurse> nur = new List<Nurse>();
        public delegate void OnSubmitDelegate(string Firstname, string Salery, string EmployeeNumber);
        public OnSubmitDelegate OnSubmit;
        public NurseForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Fn = txtFirstname.Text;
            string Sa = txtSalery.Text;
            string En = txtEmployeeNumber.Text;

            Nurse nurs = new Nurse(Fn, Sa, En);
            nur.Add(nurs);
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            dgv3.DataSource = false;
            dgv3.DataSource = nur;
        }
    }
}
