using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        //good test data
        //create some test data to pass the method
        string UserPrivileges = "Admin";
        string UserDob = "11/11/1990";
        string UserName = "Justin Dolly";

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
            Int32 UserID = 7;

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
            Int32 UserID = 7;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User ID
            if (AnUser.UserID != 7)
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
            Int32 UserID = 7;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User Contact Number
            if (AnUser.UserContactNumber != 748939456)
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
            Int32 UserID = 7;

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
            Int32 UserID = 7;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the User DOB
            if (AnUser.UserDob != Convert.ToDateTime("18/07/2022"))
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
            Int32 UserID = 7;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the Customer ID
            if (AnUser.CustomerID != 7)
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
            Int32 UserID = 6;

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
            Int32 UserID = 7;

            //invoke the method
            Found = AnUser.Find(UserID);

            //check the Username
            if (AnUser.UserName != "JustinDolly")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            string Error = "";

            //invoke the method
            Error = AnUser.Valid(UserPrivileges,UserDob,UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(1, 'a'); //this should trigger an error

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(4, 'a'); //this should trigger an error

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(5, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(6, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(19, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(20, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(21, 'a'); //this should fail

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(500, 'a'); //this should fail

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(12, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesExtremeMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(1, 'a'); //this should trigger an error

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(3, 'a'); //this should trigger an error

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(4, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(5, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(4, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(5, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(6, 'a'); //this should be ok

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserPrivilegesExtremeMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string UserPrivileges = "";
            UserPrivileges = UserPrivileges.PadRight(10, 'a'); //this should fail

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserDobExtremeMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 500 years ago
            TestDate = DateTime.Now.Date.AddYears(-500);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 100 years and 1 day ago
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(-1);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 100 years ago
            TestDate = DateTime.Now.Date.AddYears(-100);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 99 years and 364 days ago
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(1);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 12 years and 1 day ago
            TestDate = DateTime.Now.Date.AddYears(-12).AddDays(-1);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 12 years ago
            TestDate = DateTime.Now.Date.AddYears(-12);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserDobMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 11 years and 364 days ago
            TestDate = DateTime.Now.Date.AddYears(-12).AddDays(1);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserDobExtremeMax()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 100 years ahead
            TestDate = DateTime.Now.Date.AddYears(100);

            //convert the date variable to a string variable
            string UserDob = TestDate.ToString();

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void UserDobInvalidData()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();

            //string variable to store any error message
            String Error = "";

            //set the User DOB to a non date value
            string UserDob = "this is not a date!";

            //invoke the method
            Error = AnUser.Valid(UserPrivileges, UserDob, UserName);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}