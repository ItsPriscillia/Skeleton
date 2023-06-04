using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Postcode { get; set; }
        public string DOB { get; set; }

        public bool Find(int customerID)
        {
            mCustomerID = 21;
            return true;
        }
    }
}