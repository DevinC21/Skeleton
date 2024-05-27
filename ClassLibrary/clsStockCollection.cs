using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //private data member for ThisStock
        clsStock mThisStock = new clsStock();

        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        //constructor for the class
        public clsStockCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");

            //populate the array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@TypeOfCar", mThisStock.TypeOfCar);
            DB.AddParameter("@YearOfCar", mThisStock.YearOfCar);
            DB.AddParameter("@Gearbox", mThisStock.Gearbox);
            DB.AddParameter("@Prices", mThisStock.Prices);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@TypeOfCar", mThisStock.TypeOfCar);
            DB.AddParameter("@YearOfCar", mThisStock.YearOfCar);
            DB.AddParameter("@Gearbox", mThisStock.Gearbox);
            DB.AddParameter("@Prices", mThisStock.Prices);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByBrand(string Brand)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@Brand", Brand);

            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByBrand");

            //populate the array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mStockList = new List<clsStock>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock object
                clsStock AnStock = new clsStock();

                //read in the fields from the current record
                AnStock.Gearbox = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gearbox"]);
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AnStock.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                AnStock.TypeOfCar = Convert.ToString(DB.DataTable.Rows[Index]["TypeOfCar"]);
                AnStock.YearOfCar = Convert.ToDateTime(DB.DataTable.Rows[Index]["YearOfCar"]);
                AnStock.Prices = Convert.ToInt32(DB.DataTable.Rows[Index]["Prices"]);

                //add the record to the private data member
                mStockList.Add(AnStock);

                //point at the next record
                Index++;
            }
        }
    }
}