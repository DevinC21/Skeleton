using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrderss = new clsOrdersCollection();

            //test to see that it exists
            Assert.IsNotNull(AllOrderss);
        }
        [TestMethod]
        public void OrdersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrderss = new clsOrdersCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();

            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();

            //set its properties
            TestItem.Payment = true;
            TestItem.OrderID = 1;
            TestItem.OrderFullName = "Mazda Zob";
            TestItem.OrderDescription = "good";
            TestItem.OrderReturn = "No";
            TestItem.OrderStatus = "Accepted";
            TestItem.OrderDate = DateTime.Now;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllOrderss.OrdersList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrderss.OrdersList, TestList);
       
        }
        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrderss = new clsOrdersCollection();

            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();

            //set the properties of the test object
            TestOrders.Payment = true;
            TestOrders.OrderID = 1;
            TestOrders.OrderFullName = "Mazda Zob";
            TestOrders.OrderDescription = "good";
            TestOrders.OrderReturn = "No";
            TestOrders.OrderStatus = "Accepted";
            TestOrders.OrderDate = DateTime.Now;

            //assign the data to the property
            AllOrderss.ThisOrders = TestOrders;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrderss.ThisOrders, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrderss = new clsOrdersCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();

            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();

            //set its properties
            TestItem.Payment = true;
            TestItem.OrderID = 1;
            TestItem.OrderFullName = "Mazda Zob";
            TestItem.OrderDescription = "good";
            TestItem.OrderReturn = "No";
            TestItem.OrderStatus = "Accepted";
            TestItem.OrderDate = DateTime.Now;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllOrderss.OrdersList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrderss.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrdersCollection AllOrderss = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.Payment = true;
            TestItem.OrderID = 1;
            TestItem.OrderFullName = "Mazda Zob";
            TestItem.OrderDescription = "good";
            TestItem.OrderReturn = "No";
            TestItem.OrderStatus = "Accepted";
            TestItem.OrderDate = DateTime.Now;
            AllOrderss.ThisOrders = TestItem;
            PrimaryKey = AllOrderss.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrderss.ThisOrders.Find(PrimaryKey);
            Assert.AreEqual(AllOrderss.ThisOrders, TestItem);
        }
    }
}
