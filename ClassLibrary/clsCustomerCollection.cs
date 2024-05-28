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
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();

                AnCustomer.CustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerConfirmed"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerUsername = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);
                AnCustomer.CustomerPass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["Customeremail"]);
                AnCustomer.BankDetails = Convert.ToInt32(DB.DataTable.Rows[Index]["BankDetails"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
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
    }

   
}