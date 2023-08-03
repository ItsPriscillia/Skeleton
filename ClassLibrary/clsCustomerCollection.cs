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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
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

      


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByPostcode(string Postcode)
        {
            //filters the records based on a full or partial postcode
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Postcode", Postcode);
            DB.Execute("sproc_tblCustomer_FilterByPostcode");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
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

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("Firstname", mThisCustomer.Firstname);
            DB.AddParameter("Lastname", mThisCustomer.Lastname);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("Postcode", mThisCustomer.Postcode);
            DB.AddParameter("DOB", mThisCustomer.DOB);
            DB.AddParameter("Active", mThisCustomer.Active);
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
      
    
}