using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AnUser = new clsUser();

        //capture the UserID
        AnUser.UserID = Convert.ToInt32(txtUserID.Text);

        //capture the UserContactNumber
        AnUser.UserContactNumber = Convert.ToInt32(txtUserContactNumber.Text);

        //capture the UserPrivileges
        AnUser.UserPrivileges = txtUserPrivileges.Text;

        //capture the UserDob
        AnUser.UserDob = Convert.ToDateTime(txtUserDob.Text);

        //capture the CustomerID
        AnUser.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        //capture the Username
        AnUser.UserName = txtUserName.Text;

        //capture Logged In check box
        AnUser.LoggedIn = chkLoggedIn.Checked;

        //store the address in the session object
        Session["AnUser"] = AnUser;

        //navigate to the view page
        Response.Redirect("UserViewer.aspx");
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
}