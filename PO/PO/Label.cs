using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public class Label
    {
        string LastName;
        string FirstName;
        string MiddleName;
        string NewStreet;
        string NewCity;
        string NewState;
        string NewZIP;
        string NewCountry;
        DateTime DateAdded;

        public Label()
        { }

        public Label(string ln, string fn, string mn, string ns, string nc, string nstate, string nz, string ncountry, DateTime date)
        {
            LastName = ln;
            FirstName = fn;
            MiddleName = mn;
            NewStreet = ns;
            NewCity = nc;
            NewState = nstate;
            NewZIP = nz;
            NewCountry = ncountry;
            DateAdded = date;
        }
        
        public string GetLastName()
        { return LastName; }

        public string GetFirstName()
        { return FirstName; }

        public string GetMiddleName()
        { return MiddleName; }

        public string GetNewStreet()
        { return NewStreet; }

        public string GetNewCity()
        { return NewCity; }

        public string GetNewState()
        { return NewState; }

        public string GetNewZIP()
        { return NewZIP; }

        public string GetNewCountry()
        { return NewCountry; }

        DateTime GetDateAdded()
        { return DateAdded; }

        public void setLastName(string ln)
        {
            LastName = ln;
            return;
        }

        public void setFirstName(string fn)
        {
            FirstName = fn;
            return;
        }

        public void setMiddleName(string mn)
        {
            MiddleName = mn;
            return;
        }

        public void setNewStreet(string ns)
        {
            NewStreet = ns;
            return;
        }

        public void setNewCity(string nc)
        {
            NewCity = nc;
            return;
        }

        public void setNewState(string nstate)
        {
            NewState = nstate;
            return;
        }

        public void setNewZIP(string nz)
        {
            NewZIP = nz;
            return;
        }

        public void setNewCountry(string ncountry)
        {
            NewCountry = ncountry;
            return;
        }

        public void setDateTime(DateTime dt)
        {
            DateAdded = dt;
            return;
        }
    }
}