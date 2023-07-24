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


        public string Valid(string firstname, string lastname, string email, string postcode, string dOB)
        {
            return"";
        }

    }
}
