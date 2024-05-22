using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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

        public List<clsCustomer> ThisCustomer { get; set; }

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
            
            
            /*
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 1;
            TestItem.BankDetails = 1;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Name";
            TestItem.CustomerPass = "Password";
            TestItem.CustomerEmail = "word@gmail.com";
            mCustomerList.Add(TestItem);

            TestItem = new clsCustomer();
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerId = 2;
            TestItem.BankDetails = 2;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerUsername = "Another Name";
            TestItem.CustomerPass = "Another Password";
            TestItem.CustomerEmail = "email@gmail.com";
            mCustomerList.Add(TestItem);
          */
        }

    }

   
}