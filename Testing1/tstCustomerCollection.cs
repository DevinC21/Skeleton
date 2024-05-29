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

            //List<clsCustomer> TestCustomer = new List<clsCustomer>();

            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.CustomerConfirmed = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.BankDetails = 1;
            TestCustomer.DateOfBirth = DateTime.Now;
            TestCustomer.CustomerUsername = "Name";
            TestCustomer.CustomerPass = "Password";
            TestCustomer.CustomerEmail = "word@gmail.com";

            //TestCustomer.Add(TestCustomer);

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

        [TestMethod]
        public void AddMethodOK()
        {
            // Create a new instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Variable to store the primary Key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";
            // Set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomer.Add();
            // set the primary key for test data
            TestItem.CustomerId = PrimaryKey;
            // find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            // test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create a new instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Variable to store the primary Key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";
            // Set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomer.Add();
            // set the primary key for test data
            TestItem.CustomerId = PrimaryKey;
            // Modify the test record
            TestItem.CustomerConfirmed = false;
            TestItem.CustomerId = 2;
            TestItem.BankDetails = 2;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Another Name";
            TestItem.CustomerPass = "Another Password";
            TestItem.CustomerEmail = "Another@gmail.com";
            // set the record based on new test data
            AllCustomer.ThisCustomer = TestItem;
            // updates record
            AllCustomer.Update();
            // find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            // test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create a new instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            // Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // Variable to store the primary Key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";
            // Set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            // Add the record
            PrimaryKey = AllCustomer.Add();
            // set the primary key for test data
            TestItem.CustomerId = PrimaryKey;

            AllCustomer.ThisCustomer.Find(PrimaryKey);

            AllCustomer.Delete();

            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            // test to see if ThisCustomer matches the test data
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerUsernameMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            // Create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            // apply a blank string (Should return all records)
            FilteredCustomer.ReportByCustomerUsername("");
            // test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerUsernameNoneFound()
        {
            // create an instance of the class we want to create
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            // apply a post code that doesnt exist
            FilteredCustomer.ReportByCustomerUsername("xxx xxx");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerUsernameTestDataFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomer.ReportByCustomerUsername("dfdf");

            if (FilteredCustomer.Count == 2)
            {
                if (FilteredCustomer.CustomerList[0].CustomerId != 4)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[1].CustomerId != 87)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
