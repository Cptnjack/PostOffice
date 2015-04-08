using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    private class Label
    {
        string name;            // First name + last name concatenated
        string addressLine1;    // Street address
        string addressLine2;    // City, State, ZIP Code

        private Label()
        {
        }

        private Label(string nm, string add1, string add2)
        {
            name = nm;
            addressLine1 = add1;
            addressLine2 = add2;
        }

        private void setName(string nm)
        {
            name = nm;
        }

        private void setAdd1(string add1)
        {
            addressLine1 = add1;
        }

        private void setAdd2(string add2)
        {
            addressLine2 = add2;
        }

        private string getName()
        {
            return name;
        }

        private string getAdd1()
        {
            return addressLine1;
        }

        private string getAdd2()
        {
            return addressLine2;
        }
    }
}