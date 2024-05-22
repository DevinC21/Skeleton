﻿using System;
using System.Collections.Generic;

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
        public clsOrders ThisOrders { get; set; }

        public clsOrdersCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
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


