using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        // create some test data to pass the method
        string CustomerUsername = "Username";
        string CustomerPass = "Password";
        string CustomerEmail = "test@gmail.com";
        string DateOfBirth = "11/11/1990";
        string BankDetails = "100";


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

            if (AnCustomer.DateOfBirth != Convert.ToDateTime("10/10/2000"))
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "a";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "aa";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(20, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(19, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(21, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(10, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(500, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadLeft(500, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "a";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerpassMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "aa";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(16, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(15, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(17, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "aaaaaaaa";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(500, 'a');
            Error = AnCustomer.Valid(CustomerPass, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadLeft(500, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "a";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aa";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a');
            Error = AnCustomer.Valid(CustomerPass, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(500, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-1000);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-100);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(1);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-12).AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-12);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddYears(-12).AddDays(1);
            string DateOfBirth = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //string variable to store any error message
            String Error = "";

            //set the DateOfBirth to a non date value
            string DateOfBirth = "this is not a date!";

            //invoke the method
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "a";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "aa";
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadRight(50, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadRight(25, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadRight(500, 'a');
            Error = AnCustomer.Valid(CustomerPass, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BankDetailsExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string BankDetails = "";
            BankDetails = BankDetails.PadLeft(500, 'a');
            Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
            Assert.AreNotEqual(Error, "");
        }
    }
}