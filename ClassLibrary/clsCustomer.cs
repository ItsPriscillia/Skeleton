using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        private DateTime mDOB;
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private string mFirstname;
        public string Firstname
        {
            get
            {
                return mFirstname;
            }
            set
            {
                mFirstname = value;
            }
        }
        private string mLastname;
        public string Lastname
        {
            get
            {
                return mLastname;
            }
            set
            {
                mLastname = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private string mPostcode;
        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }


        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
            mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
            mLastname = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
            mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
            mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
            mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
            mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
            return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string Firstname, string Lastname, string Email, string Postcode, string DOB)
        {
            String Error = "";
            DateTime DateTemp;
            if(Firstname.Length==0)
            {
                Error = Error + "The firstname may not be blank : ";
            }
            if (Firstname.Length > 50)
            {
                Error = Error + "The firstname must be less than 50 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (Postcode.Length == 0)
            {
                Error = Error + "The post code may not be blank : ";
            }
            if (Postcode.Length > 9)
            {
                Error = Error + "The post code must be less than 9 characters : ";
            }
            if (Email.Length == 0)
            {
                Error = Error + "The street may not be blank : ";
            }
            if (Email.Length > 25)
            {
                Error = Error + "The street must be less than 25 characters : ";
            }
            if (Lastname.Length == 0)
            {
                Error = Error + "The town may not be blank : ";
            }

            if (Lastname.Length > 50)
            {
                Error = Error + "The town must be less than 50 characters : ";
            }
            return Error;
        }

    }
}
