using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public class Student
    {
        private String mNum;
        private String fName;
        private String lName;
        private String midName;
        private String email;
        private String mStAddress;
        private String mCity;
        private String mState;
        private String mZip;
        private String nStAddress;
        private String nCity;
        private String nState;
        private String nZip;
        private String nCountry;
        private DateTime dateAdded;

        public Student()
        {

        }

        public Student(String mnum, String fn, String ln, String mn, String em, String mAdd, String mC, String mSt, String mZ, String nAdd, String nC, String nSt, String nZ, String nCountry, DateTime now)
        {
            mNum = mnum;
            fName = fn;
            lName = ln;
            midName = mn;
            email= em;
            mStAddress = mAdd;
            mCity = mC;
            mState = mSt;
            mZip = mZ;
            nStAddress = nAdd;
            nCity = nC;
            nState = nSt; 
            nZip = nZ;
            this.nCountry = nCountry;
            dateAdded = now;
        }

        public override string ToString()
        {
            String r ="";
            r += "First Name: " + fName + System.Environment.NewLine;
            r += "Middle Name: " + midName + System.Environment.NewLine;
            r += "Last Name: " + lName + System.Environment.NewLine;
            r += "New Address: " + nStAddress + "," + System.Environment.NewLine;
            r += "                  " + nCity + "," + System.Environment.NewLine;

            if(nZip != "")
            {
                r += "                  " + nZip + "," + System.Environment.NewLine;
            }

            r += "                  " + nCountry + System.Environment.NewLine;
            r += "MSU Address: " + mStAddress + "," + System.Environment.NewLine;
            r += "                      " + mCity + "," + System.Environment.NewLine;
            r += "                      " + mState + "," + System.Environment.NewLine;
            r += "                      " + mZip + "," + System.Environment.NewLine;
            r += "Date Added: " + dateAdded.Date.ToString("d") + System.Environment.NewLine;
            return r;
        }

        public String NMum
        {
            get
            {
                return mNum;
            }

            set
            {
                mNum = value;
            }
        }

        public String FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public String LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public String MidName
        {
            get
            {
                return midName;
            }

            set
            {
                midName = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public String MStAddress
        {
            get
            {
                return mStAddress;
            }
            set
            {
                mStAddress= value;
            }
        }
        public String MCity
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }
        public String MState
        {
            get
            {
                return mState;
            }
            set
            {
                mState = value;
            }
        }
        public String MZip
        {
            get
            {
                return mZip;
            }
            set
            {
                mZip = value;
            }
        }
        public String NStAddress
        {
            get
            {
                return nStAddress;
            }
            set
            {
                nStAddress = value;
            }
        }
        public String NCity
        {
            get
            {
                return nCity;
            }
            set
            {
                nCity = value;
            }
        }
        public String NState
        {
            get
            {
                return nState;
            }
            set
            {
                nState = value;
            }
        }
        public String NZip
        {
            get
            {
                return nZip;
            }
            set
            {
                nZip = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return dateAdded;
            }
            set
            {
                dateAdded = value;
            }
        }
        
        public String MNum
        {
            get
            {
                return mNum;
            }

            set
            {
                mNum = value;
            }
        }

        public String NCountry
        {
            get
            {
                return nCountry;
            }

            set
            {
                nCountry = value;
            }
        }
    }
}
