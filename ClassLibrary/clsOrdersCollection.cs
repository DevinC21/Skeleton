﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();

        //private data member for ThisOrders
        clsOrders mThisOrders = new clsOrders();

        //public property for the Order list
        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrders ThisOrders
        {
            get
            {
                return mThisOrders;
            }
            set
            {
                mThisOrders = value;
            }
        }

        public clsOrdersCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }
     

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderFullName", mThisOrders.OrderFullName);
            DB.AddParameter("@OrderDescription", mThisOrders.OrderDescription);
            DB.AddParameter("@OrderDate", mThisOrders.OrderDate);
            DB.AddParameter("@Payment", mThisOrders.Payment);
            DB.AddParameter("@OrderReturn", mThisOrders.OrderReturn);
            DB.AddParameter("@OrderStatus", mThisOrders.OrderStatus);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisOrders.OrderID);
            DB.AddParameter("@OrderFullName", mThisOrders.OrderFullName);
            DB.AddParameter("@OrderDescription", mThisOrders.OrderDescription);
            DB.AddParameter("@OrderDate", mThisOrders.OrderDate);
            DB.AddParameter("@Payment", mThisOrders.Payment);
            DB.AddParameter("@OrderReturn", mThisOrders.OrderReturn);
            DB.AddParameter("@OrderStatus", mThisOrders.OrderStatus);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrders.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderFullName(string OrderFullName)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderFullName", OrderFullName);
            DB.Execute("sproc_tblOrder_FilterbyOrderFullName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrdersList = new List<clsOrders>();
            while (Index < RecordCount)
            {
                clsOrders AnOrders = new clsOrders();
                AnOrders.Payment = Convert.ToBoolean(DB.DataTable.Rows[Index]["Payment"]);
                AnOrders.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrders.OrderFullName = Convert.ToString(DB.DataTable.Rows[Index]["OrderFullName"]);
                AnOrders.OrderDescription = Convert.ToString(DB.DataTable.Rows[Index]["OrderDescription"]);
                AnOrders.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrders.OrderReturn = Convert.ToString(DB.DataTable.Rows[Index]["OrderReturn"]);
                AnOrders.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);

                mOrdersList.Add(AnOrders);
                Index++;

            }

        }
    }
}






