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
    }
}
