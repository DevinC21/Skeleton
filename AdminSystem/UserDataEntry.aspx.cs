using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the user to be processed
        UserID = Convert.ToInt32(Session["UserID"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (UserID != -1)
            {
                //display the current data for the record
                DisplayUser();
            }
        }
    }

    void DisplayUser()
    {
        //create an instance of the user
        clsUserCollection User = new clsUserCollection();

        //find the record to update
        User.ThisUser.Find(UserID);

        //display the data for the record
        txtUserID.Text = User.ThisUser.UserID.ToString();
        txtUserContactNumber.Text = User.ThisUser.UserContactNumber.ToString();
        txtCustomerID.Text = User.ThisUser.CustomerID.ToString();
        txtUserName.Text = User.ThisUser.UserName.ToString();
        txtUserPrivileges.Text = User.ThisUser.UserPrivileges.ToString();
        txtUserDob.Text = User.ThisUser.UserDob.ToString();
        chkLoggedIn.Checked = User.ThisUser.LoggedIn;


    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AnUser = new clsUser();

        //capture the UserContactNumber
        string UserContactNumber = txtUserContactNumber.Text;

        //capture the UserPrivileges
        string UserPrivileges = txtUserPrivileges.Text;

        //capture the UserDob
        string UserDob = txtUserDob.Text;

        //capture the CustomerID
        string CustomerID = txtCustomerID.Text;

        //capture the Username
        string UserName = txtUserName.Text;

        //capture Logged In check box
        string LoggedIn = chkLoggedIn.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnUser.Valid(UserPrivileges, UserDob, UserName, UserContactNumber);
        if (Error == "")
        {
            //capture the UserID
            AnUser.UserID = UserID;

            //capture the UserPrivileges
            AnUser.UserPrivileges = UserPrivileges;

            //capture the UserDob
            AnUser.UserDob = Convert.ToDateTime(UserDob);

            //capture the Username
            AnUser.UserName = UserName;

            //capture the UserContactNumber
            AnUser.UserContactNumber = Convert.ToInt32(UserContactNumber);

            //capture the CustomerID
            AnUser.CustomerID = Convert.ToInt32(CustomerID);

            //capture the LoggedIn
            AnUser.LoggedIn = chkLoggedIn.Checked;

            //create a new instance of the user collection
            clsUserCollection UserList = new clsUserCollection();

            //if this is a new record i.e. UserID = -1 then add the data
            if (UserID == -1)
            {
                //set the ThisUser property
                UserList.ThisUser = AnUser;

                //add the new record
                UserList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                UserList.ThisUser.Find(UserID);

                //set the ThisUser property
                UserList.ThisUser = AnUser;

                //update the record
                UserList.Update();
            }

            //navigate to the view page
            Response.Redirect("UserList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creat an instance of the User class
        clsUser AnUser = new clsUser();

        //create a variable to store the primary key
        Int32 UserID;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        UserID = Convert.ToInt32(txtUserID.Text);

        //find the record
        Found = AnUser.Find(UserID);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUserID.Text = AnUser.UserID.ToString();
            txtUserContactNumber.Text = AnUser.UserContactNumber.ToString();
            txtCustomerID.Text = AnUser.CustomerID.ToString();
            txtUserPrivileges.Text = AnUser.UserPrivileges;
            txtUserName.Text = AnUser.UserName;
            txtUserDob.Text = AnUser.UserDob.ToString();
            chkLoggedIn.Checked = AnUser.LoggedIn;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("UserList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}