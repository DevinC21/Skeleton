using System;

namespace ClassLibrary
{
    public class clsStockLogin
    {
        //private data member for the login id property
        private Int32 mLoginID;

        //private data member for the login name property
        private string mLoginName;

        //private data member for the login password property
        private string mLoginPassword;

        //private data member for the login department property
        private string mLoginDepartment;

        public int LoginID
        {
            get
            {
                //return the private data
                return mLoginID;
            }
            set
            {
                //set the private data
                mLoginID = value;
            }
        }

        public string LoginName
        {
            get
            {
                //return the private data
                return mLoginName;
            }
            set
            {
                //set the private data
                mLoginName = value;
            }
        }

        public string LoginPassword
        {
            get
            {
                //return the private data
                return mLoginPassword;
            }
            set
            {
                //set the private data
                mLoginPassword = value;
            }
        }

        public string LoginDepartment
        {
            get
            {
                //return the private data
                return mLoginDepartment;
            }
            set
            {
                //set the private data
                mLoginDepartment = value;
            }
        }

        public bool FindStock(string LoginName, string LoginPassword)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the stock login name and login password to search for
            DB.AddParameter("@LoginName", LoginName);
            DB.AddParameter("@LoginPassword", LoginPassword);
            //execute the stored procedure
            DB.Execute("sproc_tblLogin_FindLoginNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mLoginID = Convert.ToInt32(DB.DataTable.Rows[0]["LoginID"]);
                mLoginName = Convert.ToString(DB.DataTable.Rows[0]["LoginName"]);
                mLoginPassword = Convert.ToString(DB.DataTable.Rows[0]["LoginPassword"]);
                mLoginDepartment = Convert.ToString(DB.DataTable.Rows[0]["LoginDepartment"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}