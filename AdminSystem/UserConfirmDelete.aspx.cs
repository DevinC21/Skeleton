using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 UserID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the user to be deleted from the session object
        UserID = Convert.ToInt32(Session["UserID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the user collection class
        clsUserCollection User = new clsUserCollection();

        //find the record to delete
        User.ThisUser.Find(UserID);

        //delete the record
        User.Delete();

        //redirect back to the main page
        Response.Redirect("UserList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("UserList.aspx");
    }
}