using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the new class we want to create
            clsUser AnUser = new clsUser();

            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void LoggedInPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            Boolean TestData = true;

            //assign the data to the property
            AnUser.LoggedIn = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.LoggedIn, TestData);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnUser.UserID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserContactNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnUser.UserContactNumber = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserContactNumber, TestData);
        }

        [TestMethod]
        public void UserPrivilegesPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            string TestData = "Admin";

            //assign the data to the property
            AnUser.UserPrivileges = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserPrivileges, TestData);
        }

        [TestMethod]
        public void UserDobPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnUser.UserDob = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserDob, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnUser.CustomerID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.CustomerID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create some test data to the property
            string TestData = "MazdaZohaib";

            //assign the data to the property
            AnUser.UserName = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
    }
}