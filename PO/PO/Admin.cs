using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public class Admin : User
    {
        private String fName;
        private String lName;
        private String username;

        public Admin()
        {
            fName = "";
            lName = "";
        }

        public Admin(String f, String l, String u)
        {
            fName = f;
            lName = l;
            username = u;
        }

        public override bool isAdmin()
        {
            return true;
        }

        public override String FName
        {
            get
            {
                return fName;
            }
        }

        public override String LName
        {
            get
            {
                return lName;
            }
        }

        public override String Username
        {
            get
            {
                return username;
            }
        }
        
    }
}
