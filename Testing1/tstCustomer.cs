using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string Firstname = "Alice";
        String Lastname = "Smith";
        String Email = "Alice001@yahoo.com";
        String Postcode = "NN1 2EE";
        String DOB = DateTime.Now.Date.ToString();

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
        public void DOBOK()
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
            int TestData = 4;
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
            DateTime TestData = new DateTime(01 / 04 / 2000);
            AnCustomer.DOB = TestData;
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 4;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDNotFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 4;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 4)
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
            Int32 Firstname = 4;
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
            Int32 Lastname = 4;
            Found = AnCustomer.Find(Lastname);
            if (AnCustomer.Lastname != "Smith")
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
            Int32 Email = 4;
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
            Int32 Postcode = 4;
            Found = AnCustomer.Find(Postcode);
            if (AnCustomer.Postcode != "NN1 2EE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDOBFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 DOB = 4;
            Found = AnCustomer.Find(DOB);
            if (AnCustomer.DOB != Convert.ToDateTime("2000/04/01"))
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
            Int32 Active = 4;
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
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "a"; // shoauld pass
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; // should pass
            String Firstname = "aa";
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";// should pass
            Firstname = Firstname.PadRight(49, 'a');
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";// should pass
            Firstname = Firstname.PadRight(50, 'a');
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";//should pass
            Firstname = Firstname.PadRight(25, 'a');
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";// should fail
            Firstname = Firstname.PadRight(51, 'a');
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Firstname = "";
            Firstname = Firstname.PadRight(500, 'a');
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String DOB = TestDate.ToString();
            Error = AnCustomer.Valid(Firstname,Lastname,Email,Postcode,DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
         public void DOBMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DOB = TestDate.ToString();
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string DOB = TestDate.ToString();
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DOB = TestDate.ToString();
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DOB = TestDate.ToString();
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DOBInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string DOB = "this is not a date!";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should fail
            string Postcode = "";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostcodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Postcode = "a";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Postcode = "aa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Postcode = "aaaaaaaa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostcodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Postcode = "aaaaaaaaa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should fail
            string Postcode = "aaaaaaaaa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PostcodeMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Postcode = "aaaa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should fail
            string Email = "";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Email = "a";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Email = "aa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Email = "";
            Email = Email.PadRight(24, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should fail
            string Email = "";
            Email = Email.PadRight(26, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; //should pass
            string Email = "";
            Email = Email.PadRight(12, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastnameinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "a"; // shoauld pass
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = ""; // should pass
            String Lastname = "aa";
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "";// should pass
            Lastname = Lastname.PadRight(49, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LasttnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "";// should pass
            Lastname = Lastname.PadRight(50, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "";// should fail
            Lastname = Lastname.PadRight(51, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaststnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String Lastname = "";//should pass
            Lastname = Lastname.PadRight(25, 'a');
            Error = AnCustomer.Valid(Firstname, Lastname, Email, Postcode, DOB);
            Assert.AreEqual(Error, "");
        }
    }

    }

    
    
