using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private Boolean mActive;
        private string mFirstname;
        private string mLastname;
        private string mPostcode;
        private string mEmail;
        private DateTime mDOB;
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

     

        public bool Find(int customerID)
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
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["D0B"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Firstname"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string firstname, string lastname, string email, string postcode, string dateAdded, string dOB)
        {
            return"";
        }
    }
}
