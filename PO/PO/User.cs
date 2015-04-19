using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public class User
    {
        private String fName;
        private String lName;
        private String username;

        public virtual bool isAdmin()
        {
            return false;
        }

        public virtual String FName
        {
            get
            {
                return fName;
            }
        }

        public virtual String LName
        {
            get
            {
                return lName;
            }
        }

        public virtual String Username
        {
            get
            {
                return username;
            }
        }
    }
}
