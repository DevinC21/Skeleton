using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string Brand = "Toyota";
        string Colour = "Red";
        string TypeOfCar = "Saloon";
        string YearOfCar = "19/10/2004";

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of thhe validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StockID = 9;
            //invoke the method
            Found = AnStock.Find(StockID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.StockID != 9)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.Brand != "Ford")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.Colour != "Green")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTypeOfCarFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.TypeOfCar != "Pick Up")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGearboxFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.Gearbox != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestYearOfCarFound()
        {
            //create an instance of the class we create
            clsStock AnStock = new clsStock();
            //create a boolean varible to store the result of the seach
            Boolean Found = false;
            //create a Boolean variable to record if the date is OK (ASUMEITIS)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 9;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the dateAdded property
            if (AnStock.YearOfCar != Convert.ToDateTime("25/01/2000"))
            {

                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPricesFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //create a Boolean variable to store te results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockID = 9;

            //invoke the method
            Found = AnStock.Find(StockID);

            //check the Stock ID
            if (AnStock.Prices != 7000)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            string Error = "";

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String Brand = "a"; //this should trigger an error

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "aa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "aaa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(19, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(20, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(21, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(50, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(11, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String Colour = "a"; //this should trigger an error

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "aa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "aaa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(11, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(12, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(13, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(50, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(11, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String TypeOfCar = "aa"; //this should trigger an error

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "aaa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "aaaa"; //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "";
            TypeOfCar = TypeOfCar.PadRight(14, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "";
            TypeOfCar = TypeOfCar.PadRight(15, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "";
            TypeOfCar = TypeOfCar.PadRight(16, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "";
            TypeOfCar = TypeOfCar.PadRight(50, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeOfCarMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TypeOfCar = "";
            TypeOfCar = TypeOfCar.PadRight(9, 'a'); //this should be ok

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearOfCarMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is 100 years ago
            TestDate = DateTime.Now.Date.AddYears(-100);

            //convert the date variable to a string variable
            string YearOfCar = TestDate.ToString();

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearOfCarMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string YearOfCar = TestDate.ToString();

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearOfCarInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            //string variable to store any error message
            String Error = "";

            //set the User DOB to a non date value
            string YearOfCar = "this is not a date!";

            //invoke the method
            Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}