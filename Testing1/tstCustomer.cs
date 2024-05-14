using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerConfirmedPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean TestData = true;

            AnCustomer.CustomerConfirmed = TestData;

            Assert.AreEqual(AnCustomer.CustomerConfirmed, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnCustomer.DateOfBirth = TestData;

            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.CustomerId = TestData;

            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void BankDetailsPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.BankDetails = TestData;

            Assert.AreEqual(AnCustomer.BankDetails, TestData);
        }

        [TestMethod]
        public void CustomerUsernamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Charlie";

            AnCustomer.CustomerUsername = TestData;

            Assert.AreEqual(AnCustomer.CustomerUsername, TestData);
        }

        [TestMethod]
        public void CustomerPassPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Password";

            AnCustomer.CustomerPass = TestData;

            Assert.AreEqual(AnCustomer.CustomerPass, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Charlie";

            AnCustomer.CustomerEmail = TestData;

            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;
       
            Boolean OK = true;
         
            Int32 CustomerId = 8;
       
            Found = AnCustomer.Find(CustomerId);
          
            if (AnCustomer.CustomerId != 8)
            {
                OK = false;
            }
         
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound() 
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            if(AnCustomer.DateOfBirth != Convert.ToDateTime("10/10/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerUsernameFound()
        {
           
            clsCustomer AnCustomer = new clsCustomer();
           
            Boolean Found = false;
           
            Boolean OK = true;
            
            Int32 CustomerId = 8;
          
            Found = AnCustomer.Find(CustomerId);
          
            if (AnCustomer.CustomerUsername != "Username")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPassFound()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            if (AnCustomer.CustomerPass != "Password")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            if (AnCustomer.CustomerEmail != "Hello@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBankDetailsFound()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            if (AnCustomer.BankDetails != 100100)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerConfirmedFound()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 8;

            Found = AnCustomer.Find(CustomerId);

            if (AnCustomer.CustomerConfirmed != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }
}
