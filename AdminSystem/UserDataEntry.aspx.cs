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

        //capture the CustomerID
        AnUser.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        //capture Logged In check box
        AnUser.LoggedIn = chkLoggedIn.Checked;

        //store the address in the session object
        Session["AnUser"] = AnUser;

        //navigate to the view page
        Response.Redirect("UserViewer.aspx");
    }
}