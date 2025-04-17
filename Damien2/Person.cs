using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damien2
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Lung { get; set; }
        public string Heart { get; set; }
        public string Hour { get; set; }
        public string EmployeeNumber { get; set; }
        public string Salery { get; set; }

        public Person(string fn, string ln, string ad, string cu, string dob, string ph, string em, string Lu, string Ha, string Ho, string En, string Sa)
        {
            Firstname = fn;
            Lastname = ln;
            Address = ad;
            County = cu;
            DOB = dob;
            Phone = ph;
            Email = em;
            Lung = Lu;
            Heart = Ha;
            Hour = Ho;
            EmployeeNumber = En;
            Salery = Sa;
        }
    }
}
