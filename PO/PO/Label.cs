using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    class Label
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
        
        string GetLastName()
        { return LastName; }

        string GetFirstName()
        { return FirstName; }

        string GetMiddleName()
        { return MiddleName; }

        string GetNewStreet()
        { return NewStreet; }

        string GetNewCity()
        { return NewCity; }

        string GetNewState()
        { return NewState; }

        string GetNewZIP()
        { return NewZIP; }

        string GetNewCountry()
        { return NewCountry; }

        DateTime GetDateAdded()
        { return DateAdded; }

        void setLastName(string ln)
        {
            LastName = ln;
            return;
        }

        void setFirstName(string fn)
        {
            FirstName = fn;
            return;
        }

        void setMiddleName(string mn)
        {
            MiddleName = mn;
            return;
        }

        void setNewStreet(string ns)
        {
            NewStreet = ns;
            return;
        }

        void setNewCity(string nc)
        {
            NewCity = nc;
            return;
        }

        void setNewState(string nstate)
        {
            NewState = nstate;
            return;
        }

        void setNewZIP(string nz)
        {
            NewZIP = nz;
            return;
        }

        void setNewCountry(string ncountry)
        {
            NewCountry = ncountry;
            return;
        }
    }
}
