using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string OrderFullName = "FullName";
        string OrderDescription = "Order Description";
        string OrderReturn = "Order Return";
        string OrderStatus = "Order Status";
        string OrderDate = DateTime.Now.ToShortDateString();





        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void PaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrder.Payment = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Payment, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnOrders.OrderID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderID, TestData);
        }
        [TestMethod]
        public void OrderFullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            string TestData = "Full Name";

            //assign the data to the property
            AnOrders.OrderFullName = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderFullName, TestData);
        }
        [TestMethod]
        public void OrderDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            string TestData = "Order Description";

            //assign the data to the property
            AnOrders.OrderDescription = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderDescription, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnOrders.OrderDate = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderReturnPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            string TestData = "Order Return";

            //assign the data to the property
            AnOrders.OrderReturn = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderReturn, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create some test data to assign to the property
            string TestData = "Order Status";

            //assign the data to the property
            AnOrders.OrderStatus = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderStatus, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the User ID
            if (AnOrders.OrderID != 11)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderFullNameFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the User Contact Number
            if (AnOrders.OrderFullName != "Peter Finkley")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the User Privileges
            if (AnOrders.OrderDescription != "good")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the User DOB
            if (AnOrders.OrderDate != Convert.ToDateTime("03/05/2024"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the Customer ID
            if (AnOrders.Payment != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderReturnFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the Logged In
            if (AnOrders.OrderReturn != "No")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 11;

            //invoke the method
            Found = AnOrders.Find(OrderID);

            //check the Username
            if (AnOrders.OrderStatus != "Accepted")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrders = new clsOrders();
            string Error = "";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "a";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFullNameMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFullNameMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderFullNameExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            OrderFullName = OrderFullName.PadRight(100, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "a";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "";
            OrderFullName = OrderDescription.PadRight(200, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "a";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderFullName = OrderReturn.PadRight(50, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "a";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "aaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderFullName = OrderStatus.PadRight(50, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessThanOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDate = "this is not a date!";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");

        }
    }
}




