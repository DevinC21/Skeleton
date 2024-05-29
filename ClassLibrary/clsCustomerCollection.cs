using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {


        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
               //
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }



        public clsCustomerCollection()
        {
            // object for data connection
           clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //Connect to the database
           clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerUsername", mThisCustomer.CustomerUsername);
            DB.AddParameter("@CustomerPass", mThisCustomer.CustomerPass);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerConfirmed", mThisCustomer.CustomerConfirmed);
            DB.AddParameter("@BankDetails", mThisCustomer.BankDetails);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //Update an existing record based on the values of ThisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerUsername", mThisCustomer.CustomerUsername);
            DB.AddParameter("@CustomerPass", mThisCustomer.CustomerPass);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerConfirmed", mThisCustomer.CustomerConfirmed);
            DB.AddParameter("@BankDetails", mThisCustomer.BankDetails);
            // Execute stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by thisCustomer
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            //Set the parameters and execute for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerUsername(string CustomerUsername)
        {
            // filters the records based on a full or partial username
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the username parameter to the database
            DB.AddParameter("@CustomerUsername", CustomerUsername);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerUsername");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mCustomerList = new List<clsCustomer>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank Customer object
                clsCustomer AnCustomer = new clsCustomer();
                // read in the firles from the current record
                AnCustomer.CustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerConfirmed"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerUsername = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);
                AnCustomer.CustomerPass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.BankDetails = Convert.ToInt32(DB.DataTable.Rows[Index]["BankDetails"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                // add the record to the private data member
                mCustomerList.Add(AnCustomer);
                // point at the next record
                Index++;
            }
        }
    }

   
}