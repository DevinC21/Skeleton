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
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";

            TestList.Add(TestItem);

            AllCustomer.CustomerList = TestList;

            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestCustomer = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";

            TestCustomer.Add(TestItem);

            AllCustomer.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";

            TestList.Add(TestItem);

            AllCustomer.CustomerList = TestList;

            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        /*[TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";

            AllCustomer.ThisCustomer = TestItem;

            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerId = PrimaryKey;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        */
    }
}
