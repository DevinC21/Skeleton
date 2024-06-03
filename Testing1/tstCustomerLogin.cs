using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomerLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // test to see it exists
            Assert.IsNotNull(AnLogin);
        }

        [TestMethod]
        public void LoginIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // create some test data to assign to property
            Int32 TestData = 1;
            // assign the data to the property
            AnLogin.LoginID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginID, TestData);
        }

        [TestMethod]
        public void LoginNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // create some test data to assign to property
            string TestData = "CharlieWhiting";
            // assign the data to the property
            AnLogin.LoginName = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginName, TestData);
        }

        [TestMethod]
        public void LoginPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // create some test data to assign to property
            string TestData = "password321";
            // assign the data to the property
            AnLogin.LoginPassword = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginPassword, TestData);
        }

        [TestMethod]
        public void LoginDepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // create some test data to assign to property
            string TestData = "User";
            // assign the data to the property
            AnLogin.LoginDepartment = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginDepartment, TestData);
        }

        [TestMethod]
        public void FindLoginMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();
            // create a boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to assign to property
            string LoginName = "CharlieWhiting";
            string LoginPassword = "password321";
            // invoke the method
            Found = AnLogin.FindCustomer(LoginName, LoginPassword);
            // test to see the results are true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLoginNamePWFound()
        {
            //create an instance of the class we want to create
            clsCustomerLogin AnLogin = new clsCustomerLogin();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK 
            Boolean OK = true;

            //create some test data to use with the method
            string LoginName = "CharlieWhiting";
            string LoginPassword = "password321";

            //invoke the method
            Found = AnLogin.FindCustomer(LoginName, LoginPassword);
            //check the Login ID property

            if (AnLogin.LoginName != LoginName && AnLogin.LoginPassword != LoginPassword)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
