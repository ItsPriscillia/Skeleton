using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string Firstname = "Alice";
        String Lastname = "Smith";
        String Email = "Alice001@yahoo.com";
        String Postcode = "NN1 2EE";
        String DateAdded = DateTime.Now.Date.ToString();
        String DOB =   "01/04/2000";
        
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.DOB = TestData;
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 3;
            AnCustomer.CustomerID = TestData;
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstnamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Alice";
            AnCustomer.Firstname = TestData;
            Assert.AreEqual(AnCustomer.Firstname, TestData);
        }

        [TestMethod]
        public void LastnamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Smith";
            AnCustomer.Lastname = TestData;
            Assert.AreEqual(AnCustomer.Lastname, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Alice001@yahoo.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "NN1 2EE";
            AnCustomer.Postcode = TestData;
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime (12/04/2002);
            AnCustomer.DOB = TestData;
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }
        [TestMethod]

        public void FindMethodOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 3;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstnameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Firstname = 15;
            Found = AnCustomer.Find(Firstname);
            if (AnCustomer.Firstname != "Alice")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastnameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Lastname = 25;
            Found = AnCustomer.Find(Lastname);
            if (AnCustomer.Lastname!= "Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Email = 30;
            Found = AnCustomer.Find(Email);
            if (AnCustomer.Email != "Alice001@yahoo.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostcodeFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Postcode = 6;
            Found = AnCustomer.Find(Postcode);
            if (AnCustomer.Postcode != "LE2 7QQ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 DateAdded = 9;
            Found = AnCustomer.Find(DateAdded);
            if (AnCustomer.DOB != Convert.ToDateTime("01/04/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Active = 5;
            Found = AnCustomer.Find(Active);
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DateAdded, DOB);
            Assert.AreEqual(Error, "");
                }

    }
}
    
    
