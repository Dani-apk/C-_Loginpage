using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damien2
{
    internal class Patient : Person
    {
        public Patient(string fn, string ln, string dob, string cu, string ph, string em)
         : base(fn, ln, dob, cu, ph, em, "", "", "", "","","")
        { 

        }
       
    }
}
