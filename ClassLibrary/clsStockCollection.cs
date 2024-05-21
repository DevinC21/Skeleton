using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

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

        public clsStock ThisStock { get; set; }
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

        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank user
                clsStock AnStock = new clsStock();

                //read in the fields for the current record
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