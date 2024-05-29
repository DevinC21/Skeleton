﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the new class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //test to see that it exists
            Assert.IsNotNull(AnLogin);
        }

        [TestMethod]
        public void LoginIDPropertyOK()
        {
            //create an instance of the new class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnLogin.LoginID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginID, TestData);
        }

        [TestMethod]
        public void LoginNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create some test data to assign to the property
            string TestData = "Sedique";

            //assign the data to the property
            AnLogin.LoginName = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginName, TestData);
        }

        [TestMethod]
        public void LoginPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create some test data to assign to the property
            string TestData = "password22";

            //assign the data to the property
            AnLogin.LoginPassword = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginPassword, TestData);
        }

        [TestMethod]
        public void LoginDepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create some test data to assign to the property
            string TestData = "Stock";

            //assign the data to the property
            AnLogin.LoginDepartment = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginDepartment, TestData);
        }

        [TestMethod]
        public void FindLoginMethodOK()
        {
            //create an instance of the class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            string LoginName = "Sedique";
            string LoginPassword = "password22";

            //invoke the method
            Found = AnLogin.FindStock(LoginName, LoginPassword);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLoginNamePWFound()
        {
            //create an instance of the class we want to create
            clsStockLogin AnLogin = new clsStockLogin();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)  
            Boolean OK = true;

            //create some test data to use with the method
            string LoginName = "Sedique";
            string LoginPassword = "password22";

            //invoke the method
            Found = AnLogin.FindStock(LoginName, LoginPassword);

            //check the Login ID property
            if (AnLogin.LoginName != LoginName && AnLogin.LoginPassword != LoginPassword)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
