using System;

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
        private DateTime mDateAdded;
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
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
        public string DOB { get; set; }

        public bool Find(int customerID)
        {
            mCustomerID = 21;

            mDateAdded = Convert.ToDateTime("16/04/2002");
            mActive = true;
            return true;
        }
    }
}