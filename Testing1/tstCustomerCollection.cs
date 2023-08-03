using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "Princess";
            TestItem.Lastname = "Daniels";
            TestItem.Email = "P.daneils@gmail.com";
            TestItem.Postcode = "LE5 5KJ";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 2;
            TestCustomer.DOB = DateTime.Now.Date;
            TestCustomer.Firstname = "Princess";
            TestCustomer.Lastname = "Daniels";
            TestCustomer.Email = "P.daneils@gmail.com";
            TestCustomer.Postcode = "LE5 5KJ";
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListandCountOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "Princess";
            TestItem.Lastname = "Daniels";
            TestItem.Email = "P.daneils@gmail.com";
            TestItem.Postcode = "LE5 5KJ";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "Princess";
            TestItem.Lastname = "Daniels";
            TestItem.Email = "P.daneils@gmail.com";
            TestItem.Postcode = "LE5 5KJ";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

       [TestMethod]
       public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers =  new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "Princess";
            TestItem.Lastname = "Daniels";
            TestItem.Email = "P.daneils@gmail.com";
            TestItem.Postcode = "LE5 5KJ";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.Active = false;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "123b";
            TestItem.Lastname = "another street";
            TestItem.Email = "another@gmail.com";
            TestItem.Postcode = "LE2 2WE";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);



        }
        
           

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Firstname = "Princess";
            TestItem.Lastname = "Daniels";
            TestItem.Email = "P.daneils@gmail.com";
            TestItem.Postcode = "LE5 5KJ";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostcodeMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByPostcode("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByPostcode("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean Ok = true;
            FilteredCustomers.ReportByPostcode("LE5 5KJ");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 12)
                {
                    Ok = false;
                }
                if (FilteredCustomers.Count == 2)
                {
                    if (FilteredCustomers.CustomerList[0].CustomerID != 13)
                    {
                        Ok = false;
                    }
                    Assert.IsTrue(Ok);

                }
            }
        }
    }
}
