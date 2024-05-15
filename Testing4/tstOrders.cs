using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
    {
    [TestClass]
    public class tstOrder
    {
       
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
    }
}