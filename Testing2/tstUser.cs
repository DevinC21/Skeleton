using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User ID
            if (AnUser.UserID !=1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserContactnumberFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User Contact Number
            if (AnUser.UserContactNumber != 999)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserPrivilegesFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User Privileges
            if (AnUser.UserPrivileges != "Admin")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserDobFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User DOB
            if (AnUser.UserDob != Convert.ToDateTime("26/11/2003"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the Customer ID
            if (AnUser.CustomerID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLoggedInFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the Logged In
            if (AnUser.LoggedIn != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 UserID = 1;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the Username
            if (AnUser.UserName != "MazdaZohaib")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}