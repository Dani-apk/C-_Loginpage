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
    
    public partial class DoctorForm : Form
    {
        List<Doctor> doc = new List<Doctor>();
        public delegate void OnSubmitDelegate(string Lung, string Heart, string EmployeeNumber);
        public OnSubmitDelegate OnSubmit;
        public DoctorForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Lu = txtLung.Text;
            string Ha = txtHeart.Text;
            string En = txtEmployeeNumber.Text;

            Doctor doct = new Doctor(Lu, Ha, En);
            doc.Add(doct);
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            dgv2.DataSource = false;
            dgv2.DataSource = doc;
        }
    }
}
