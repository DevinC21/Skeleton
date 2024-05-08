using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnStock.StockID = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockID, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            String TestData = "Toyota";

            //assign the data to the property
            AnStock.Brand = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Brand, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            String TestData = "Red";

            //assign the data to the property
            AnStock.Colour = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Colour, TestData);
        }

        [TestMethod]
        public void TypeOfCarPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            String TestData = "Coupe";

            //assign the data to the property
            AnStock.TypeOfCar = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.TypeOfCar, TestData);
        }

        [TestMethod]
        public void GearboxPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnStock.Gearbox = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Gearbox, TestData);
        }

        [TestMethod]
        public void YearOfCarPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnStock.YearOfCar = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.YearOfCar, TestData);
        }

        [TestMethod]
        public void PricesPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnStock.Prices = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Prices, TestData);
        }
    }
}
