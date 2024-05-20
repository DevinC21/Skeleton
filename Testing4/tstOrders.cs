using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string OrderFullName = "Mazda Zob";
        string OrderDescription = "Good";
        string OrderReturn = "No";
        string OrderStatus = "Accepted";
        string OrderDate = "20/05/2024";


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
            string TestData = "Mazda Zob";

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
            string TestData = "Good";

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
            string TestData = "No";

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
            string TestData = "Accepted";

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
            string OrderFullName = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "aaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            OrderFullName = OrderFullName.PadRight(19, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderFullNameMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            OrderFullName = OrderFullName.PadRight(20, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFullNameMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            OrderFullName = OrderFullName.PadRight(21, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderFullNameMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderFullName = "";
            OrderFullName = OrderFullName.PadRight(11, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
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
            string OrderDescription = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDescription = "aaaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            string Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(11, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDescriptionMax()
        {
            clsOrders AnOrders = new clsOrders();
            string Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(12, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            string Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(13, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            clsOrders AnOrders = new clsOrders();
            string Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(7, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
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
            string OrderReturn = "a";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "aaa";
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderReturn = OrderReturn.PadRight(9, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderReturnMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderReturn = OrderReturn.PadRight(10, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderReturn = OrderReturn.PadRight(11, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderReturn = OrderReturn.PadRight(6, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderReturn = "";
            OrderReturn = OrderReturn.PadRight(50, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(5, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(6, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(7, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(14, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(15, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(16, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(10, 'a');
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(50, 'a');
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
            TestDate = DateTime.Now.Date.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMax()
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