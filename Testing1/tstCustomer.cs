using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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
            AnCustomer.DateAdded = TestData;
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 1;
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
            string TestData = "Alice001@gmail.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "LE1 3EE";
            AnCustomer.Postcode = TestData;
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "12/04/2002";
            AnCustomer.DOB = TestData;
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }
        [TestMethod]

        public void FindMethodOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
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
            Int32 Firstname = 21;
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
            Int32 Lastname = 21;
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
            Int32 Email = 21;
            Found = AnCustomer.Find(Email);
            if (AnCustomer.Email != "Alice001@gmail.com")
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
            Int32 Postcode = 21;
            Found = AnCustomer.Find(Postcode);
            if (AnCustomer.Postcode != "LE1 3EE")
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
            Int32 DateAdded = 21;
            Found = AnCustomer.Find(DateAdded);
            if (AnCustomer.DateAdded != Convert.ToDateTime("16/02/2002"))
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
            Int32 Active = 21;
            Found = AnCustomer.Find(Active);
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
    
    