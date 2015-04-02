using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    class Admin : User
    {
        private String fName;
        private String lName;

        public Admin()
        {

        }

        public Admin(String f, string l)
        {
            fName = f;
            lName = l;
        }

        public override bool isAdmin()
        {
            return true;
        }
    }
}
