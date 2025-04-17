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
    public partial class PartTimeForm : Form
    {
        List<PartTime> par = new List<PartTime>();
        public delegate void OnSubmitDelegate(string Firstname, string Lastname, string Phone, string Hours, string EmployeeNumber);
        public OnSubmitDelegate OnSubmit;
        public PartTimeForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Fn = txtFirstname.Text;
            string Ln = txtLastname.Text;
            string Ph = txtPhone.Text;
            string Ho = txtHours.Text;
            string En = txtEmployeeNumber.Text;

            PartTime part = new PartTime(Fn, Ln, Ph, Ho, En);
            par.Add(part);
        }

        private void btnPartTime_Click(object sender, EventArgs e)
        {
            dgv4.DataSource = false;
            dgv4.DataSource = par;
        }
    }
}
