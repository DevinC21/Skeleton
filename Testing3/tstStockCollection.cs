using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();

            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();

            //set its properties
            TestItem.Gearbox = true;
            TestItem.StockID = 1;
            TestItem.Brand = "Toyota";
            TestItem.Colour = "Red";
            TestItem.TypeOfCar = "Saloon";
            TestItem.YearOfCar = DateTime.Now;
            TestItem.Prices = 1000;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllStocks.StockList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create some test data to assign to the property
            clsStock TestStock = new clsStock();

            //set the properties of the test object
            TestStock.Gearbox = true;
            TestStock.StockID = 1;
            TestStock.Brand = "Toyota";
            TestStock.Colour = "Red";
            TestStock.TypeOfCar = "Saloon";
            TestStock.YearOfCar = DateTime.Now;
            TestStock.Prices = 1000;

            //assign the data to the property
            AllStocks.ThisStock = TestStock;

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();

            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();

            //set its properties
            TestItem.Gearbox = true;
            TestItem.StockID = 1;
            TestItem.Brand = "Toyota";
            TestItem.Colour = "Red";
            TestItem.TypeOfCar = "Saloon";
            TestItem.YearOfCar = DateTime.Now;
            TestItem.Prices = 1000;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllStocks.StockList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Gearbox = true;
            TestItem.StockID = 1;
            TestItem.Prices = 100000;
            TestItem.TypeOfCar = "Super Car";
            TestItem.Brand = "Ferrari";
            TestItem.Colour = "Red";
            TestItem.YearOfCar = DateTime.Now.AddYears(-10);

            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;

            //add the record
            PrimaryKey = AllStocks.Add();

            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;

            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Gearbox = true;
            TestItem.Prices = 75000;
            TestItem.TypeOfCar = "SUV";
            TestItem.Brand = "Audi";
            TestItem.Colour = "Blue";
            TestItem.YearOfCar = DateTime.Now.AddYears(-1);

            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;

            //add the record
            PrimaryKey = AllStocks.Add();

            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;

            //modify the test record
            TestItem.Gearbox = true;
            TestItem.Prices = 50000;
            TestItem.TypeOfCar = "Sports Car";
            TestItem.Brand = "Lotus";
            TestItem.Colour = "Yellow";
            TestItem.YearOfCar = DateTime.Now.AddYears(-2);

            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;

            //update the record
            AllStocks.Update();

            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Gearbox = true;
            TestItem.StockID = 1;
            TestItem.Prices = 100000;
            TestItem.TypeOfCar = "Super Car";
            TestItem.Brand = "Ferrari";
            TestItem.Colour = "Red";
            TestItem.YearOfCar = DateTime.Now.AddYears(-10);

            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;

            //add the record
            PrimaryKey = AllStocks.Add();

            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;

            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);

            //deletd the record
            AllStocks.Delete();

            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByBrandMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();

            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();

            //apply a blank string (should return all records)
            FilteredStocks.ReportByBrand("");

            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByBrandNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();

            //apply a brand that doesn't exist
            FilteredStocks.ReportByBrand("xxxxx");

            //test to see that there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByBrandTestDataFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply a Brand that doesn't exist
            FilteredStocks.ReportByBrand("Hello");

            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredStocks.StockList[0].StockID != 25)
                {
                    OK = false;
                }

                //check to see that the first record is 26
                if (FilteredStocks.StockList[0].StockID != 26)
                {
                    OK = false;
                }
            }
            else
            {
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}
