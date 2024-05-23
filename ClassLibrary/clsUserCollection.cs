using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        //private data member for the list
        List<clsUser> mUserList = new List<clsUser>();

        //private data member for ThisUser
        clsUser mThisUser = new clsUser();

        //public property for the user list
        public List<clsUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mUserList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisUser
        public clsUser ThisUser
        {
            get
            {
                //return the private data
                return mThisUser;
            }
            set
            {
                //set the private data
                mThisUser = value;
            }
        }

        //constructor for the class
        public clsUserCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblUser_SelectAll");

            //populate the array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@UserContactNumber", mThisUser.UserContactNumber);
            DB.AddParameter("@CustomerID", mThisUser.CustomerID);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@UserPrivileges", mThisUser.UserPrivileges);
            DB.AddParameter("@UserDob", mThisUser.UserDob);
            DB.AddParameter("@LoggedIn", mThisUser.LoggedIn);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblUser_Insert");
        }

        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.AddParameter("@UserContactNumber", mThisUser.UserContactNumber);
            DB.AddParameter("@CustomerID", mThisUser.CustomerID);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@UserPrivileges", mThisUser.UserPrivileges);
            DB.AddParameter("@UserDob", mThisUser.UserDob);
            DB.AddParameter("@LoggedIn", mThisUser.LoggedIn);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblUser_Update");
        }

        public void Delete ()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Delete");
        }

        public void ReportByUserName(string UserName)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@UserName", UserName);

            //execute the stored procedure
            DB.Execute("sproc_tblUser_FilterByUserName");

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
            mUserList = new List<clsUser>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank user object
                clsUser AnUser = new clsUser();

                //read in the fields from the current record
                AnUser.LoggedIn = Convert.ToBoolean(DB.DataTable.Rows[Index]["LoggedIn"]);
                AnUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AnUser.UserContactNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["UserContactNumber"]);
                AnUser.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AnUser.UserPrivileges = Convert.ToString(DB.DataTable.Rows[Index]["UserPrivileges"]);
                AnUser.UserDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["UserDob"]);

                //add the record to the private data member
                mUserList.Add(AnUser);

                //point at the next record
                Index++;
            }
        }
    }
}