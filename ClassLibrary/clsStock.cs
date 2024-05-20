using System;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the Stock ID property
        private Int32 mStockID;

        //Stock ID public property
        public int StockID
        {
            get
            {
                //this line of code sends data out of the property
                return mStockID;
            }
            set
            {
                //this line of code allows data into the property
                mStockID = value;
            }
        }

        //private data member for the Brand property
        private string mBrand;

        //Brand public property
        public string Brand
        {
            get
            {
                //this line of code sends data out of the property
                return mBrand;
            }
            set
            {
                //this line of code allows data into the property
                mBrand = value;
            }
        }

        //private data member for the Colour property
        private string mColour;

        //Customer ID public property

        public string Colour
        {
            get
            {
                //this line of code sends data out of the property
                return mColour;
            }
            set
            {
                //this line of code allows data into the property
                mColour = value;
            }
        }

        //private data member for the Type Of Car property
        private string mTypeOfCar;

        //Type Of Car public property

        public string TypeOfCar
        {
            get
            {
                //this line of code sends data out of the property
                return mTypeOfCar;
            }
            set
            {
                //this line of code allows data into the property
                mTypeOfCar = value;
            }
        }

        //private data member for the Year Of Car property
        private DateTime mYearOfCar;

        //Username public property
        public DateTime YearOfCar
        {
            get
            {
                //this line of code sends data out of the property
                return mYearOfCar;
            }
            set
            {
                //this line of code allows data into the property
                mYearOfCar = value;
            }
        }

        //private data member for the Gearbox property
        private Boolean mGearbox;

        //User DOB public property
        public bool Gearbox
        {
            get
            {
                //this line of code sends data out of the property
                return mGearbox;
            }
            set
            {
                //this line of code allows data into the property
                mGearbox = value;
            }

        }

        //private data member for the Prices property
        private Int32 mPrices;

        //Logged In public property
        public int Prices
        {
            get
            {
                //this line of code sends data out of the property
                return mPrices;
            }
            set
            {
                //this line of code allows data into the property
                mPrices = value;
            }
        }

        public bool Find(int StockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the Stock ID to search for
            DB.AddParameter("@StockID", StockID);

            //execute the stored  procedure
            DB.Execute("sproc_tblStock_FilterByStockID");

            //if on record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mTypeOfCar = Convert.ToString(DB.DataTable.Rows[0]["TypeOfCar"]);
                mGearbox = Convert.ToBoolean(DB.DataTable.Rows[0]["Gearbox"]);
                mYearOfCar = Convert.ToDateTime(DB.DataTable.Rows[0]["YearOfCar"]);
                mPrices = Convert.ToInt32(DB.DataTable.Rows[0]["Prices"]);

                //return that everything worked okay
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

        public string Valid(string brand, string colour, string typeOfCar, string yearOfCar)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the brand is less than 2 characters
            if (brand.Length <= 1)
            {
                //record the error
                Error = Error + "The brand must contain at least 2 characters. ";
            }

            //if the brand is greater than 20 characters
            if (brand.Length >= 21)
            {
                //record the error
                Error = Error + "The brand cannot be more than 20 characters. ";
            }

            //if the colour is less than 2 characters
            if (colour.Length <= 1)
            {
                //record the error
                Error = Error + "The colour must contain at least 2 characters. ";
            }

            //if the colour is greater than 12 characters
            if (colour.Length >= 13)
            {
                //record the error
                Error = Error + "The colour cannot be more than 12 characters. ";
            }

            //if the type of car is less than 3 characters
            if (typeOfCar.Length <= 2)
            {
                //record the error
                Error = Error + "The type of car must contain at least 3 characters. ";
            }

            //if the type of car is greater than 15 characters
            if (typeOfCar.Length >= 16)
            {
                //record the error
                Error = Error + "The type of car cannot be more than 15 characters. ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the year of car value to the DateTemp variable
                DateTemp = Convert.ToDateTime(yearOfCar);

                //check to see if the date is more than 100 years ago
                if (DateTemp < DateComp.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The Date cannot be more than 100 years ago. ";
                }

                //check to see if the date is less than 12 years ago
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future. ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date. ";
            }

            //return any error messages
            return Error;
        }
    }
}