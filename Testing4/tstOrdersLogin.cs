using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrdersLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the new class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //test to see that it exists
            Assert.IsNotNull(AnLogin);
        }

        [TestMethod]
        public void LoginIDPropertyOK()
        {
            //create an instance of the new class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create some test data to assign to the property
            Int32 TestData = 2;

            //assign the data to the property
            AnLogin.LoginID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginID, TestData);
        }

        [TestMethod]
        public void LoginNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create some test data to assign to the property
            string TestData = "DevinChohan";

            //assign the data to the property
            AnLogin.LoginName = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginName, TestData);
        }

        [TestMethod]
        public void LoginPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create some test data to assign to the property
            string TestData = "password21";

            //assign the data to the property
            AnLogin.LoginPassword = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginPassword, TestData);
        }

        [TestMethod]
        public void LoginDepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create some test data to assign to the property
            string TestData = "Orders";

            //assign the data to the property
            AnLogin.LoginDepartment = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnLogin.LoginDepartment, TestData);
        }

        [TestMethod]
        public void FindLoginMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            string LoginName = "DevinChohan";
            string LoginPassword = "password21";

            //invoke the method
            Found = AnLogin.FindOrders(LoginName, LoginPassword);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLoginNamePWFound()
        {
            //create an instance of the class we want to create
            clsOrdersLogin AnLogin = new clsOrdersLogin();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)  
            Boolean OK = true;

            //create some test data to use with the method
            string LoginName = "DevinChohan";
            string LoginPassword = "password21";

            //invoke the method
            Found = AnLogin.FindOrders(LoginName, LoginPassword);

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
