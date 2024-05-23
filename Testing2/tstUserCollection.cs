using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }

        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();

            //add an item to the list
            //create the item of test data
            clsUser TestItem = new clsUser();

            //set its properties
            TestItem.LoggedIn = true;
            TestItem.UserID = 1;
            TestItem.UserContactNumber = 777777777;
            TestItem.CustomerID = 1;
            TestItem.UserName = "MazdaZohaib";
            TestItem.UserPrivileges = "Admin";
            TestItem.UserDob = DateTime.Now;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllUsers.UserList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create some test data to assign to the property
            clsUser TestUser = new clsUser();

            //set the properties of the test object
            TestUser.LoggedIn = true;
            TestUser.UserID = 1;
            TestUser.UserContactNumber = 777777777;
            TestUser.CustomerID = 1;
            TestUser.UserName = "MazdaZohaib";
            TestUser.UserPrivileges = "Admin";
            TestUser.UserDob = DateTime.Now;

            //assign the data to the property
            AllUsers.ThisUser = TestUser;

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();

            //add an item to the list
            //create the item of test data
            clsUser TestItem = new clsUser();

            //set its properties
            TestItem.LoggedIn = true;
            TestItem.UserID = 1;
            TestItem.UserContactNumber = 777777777;
            TestItem.CustomerID = 1;
            TestItem.UserName = "MazdaZohaib";
            TestItem.UserPrivileges = "Admin";
            TestItem.UserDob = DateTime.Now;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllUsers.UserList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create the item of test data
            clsUser TestItem = new clsUser();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.LoggedIn = true;
            TestItem.UserID = 1;
            TestItem.UserContactNumber = 777777777;
            TestItem.CustomerID = 1;
            TestItem.UserName = "Suiiiiiii";
            TestItem.UserPrivileges = " Adds";
            TestItem.UserDob = DateTime.Now;

            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;

            //add the record
            PrimaryKey = AllUsers.Add();

            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;

            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create the item of test data
            clsUser TestItem = new clsUser();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.LoggedIn = true;
            TestItem.UserContactNumber = 777777777;
            TestItem.CustomerID = 1;
            TestItem.UserName = "Suiiiiiii";
            TestItem.UserPrivileges = "Edit";
            TestItem.UserDob = DateTime.Now.AddYears(-12);

            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;

            //add the record
            PrimaryKey = AllUsers.Add();

            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;

            //modify the test record
            TestItem.LoggedIn = false;
            TestItem.UserContactNumber = 75726725;
            TestItem.CustomerID = 12;
            TestItem.UserName = "Unsuiiiiiii";
            TestItem.UserPrivileges = "Edits";
            TestItem.UserDob = DateTime.Now.AddYears(-20);

            //set the record based on the new test data
            AllUsers.ThisUser = TestItem;

            //update the record
            AllUsers.Update();

            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();

            //create the item of test data
            clsUser TestItem = new clsUser();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.LoggedIn = true;
            TestItem.UserID = 1;
            TestItem.UserContactNumber = 777777777;
            TestItem.CustomerID = 1;
            TestItem.UserName = "Suiiiiiii";
            TestItem.UserPrivileges = "Admin";
            TestItem.UserDob = DateTime.Now;

            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;

            //add the record
            PrimaryKey = AllUsers.Add();

            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;

            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);

            //deletd the record
            AllUsers.Delete();

            //now find the record
            Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByUserNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsUserCollection AllUsers = new clsUserCollection();

            //create an instance of the filtered data
            clsUserCollection FilteredUsers = new clsUserCollection();

            //apply a blank string (should return all records)
            FilteredUsers.ReportByUserName("");

            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, FilteredUsers.Count);
        }

        [TestMethod]
        public void ReportByUserNameNoneFound()
        {
            //create an instance of the class we want to create
            clsUserCollection FilteredUsers = new clsUserCollection();

            //apply a username that doesn't exist
            FilteredUsers.ReportByUserName("xxxxx");

            //test to see that there are no records
            Assert.AreEqual(0, FilteredUsers.Count);
        }

        [TestMethod]
        public void ReportByUserNameTestDataFound()
        {
            //create an instance of the class we want to create
            clsUserCollection FilteredUsers = new clsUserCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply a username that doesn't exist
            FilteredUsers.ReportByUserName("Hello");

            //check that the correct number of records are found
            if (FilteredUsers.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredUsers.UserList[0].UserID != 25)
                {
                    OK = false;
                }

                //check to see that the first record is 26
                if (FilteredUsers.UserList[0].UserID != 26)
                {
                    OK = false;
                }
            }
            else
            {
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}
