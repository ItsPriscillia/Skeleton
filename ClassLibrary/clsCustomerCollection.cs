using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{

    public class clsCustomerCollection

    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer clsCustomers = new clsCustomer();
        

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                AnCustomer.Lastname = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AnCustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
       
        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
       public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            { 

            }

        }
        private clsCustomer mThisCustomer;
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Firstname", mThisCustomer.Firstname);
            DB.AddParameter("@Lastname", mThisCustomer.Lastname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DOB", mThisCustomer.DOB);
            DB.AddParameter("@Postcode", mThisCustomer.Postcode);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
      
    
}