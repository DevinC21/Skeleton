using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayUsers();
        }

        //create a new instance of clsUserLogin
        //clsUserLogin AnLogin = new clsUserLogin();

        //get data from the session object
        //AnLogin = (clsUserLogin)Session["AnLogin"];

        //display the login name
        //Response.Write("Logged in as: " + AnLogin.LoginName);
    }

    void DisplayUsers()
    {
        //create an instance of the user collection
        clsUserCollection Users = new clsUserCollection();

        //set the data source to list of users in the collection
        lstUserList.DataSource = Users.UserList;

        //set the name of the primary key
        lstUserList.DataValueField = "UserID";

        //set the data field to display
        lstUserList.DataTextField = "UserName";

        //bind the data to the list
        lstUserList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["UserID"] = -1;

        //redirect to the data entry page
        Response.Redirect("UserDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 UserID;

        //if a record has been selected from the list
        if (lstUserList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            UserID = Convert.ToInt32(lstUserList.SelectedValue);

            //store the data in the session object
            Session["UserID"] = UserID;

            //redirect to the edit page
            Response.Redirect("UserDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 UserID;

        //if a record has been selected from the list
        if (lstUserList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            UserID = Convert.ToInt32(lstUserList.SelectedValue);

            //store the data in the session object
            Session["UserID"] = UserID;

            //redirect to the edit page
            Response.Redirect("UserConfirmDelete.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the user object
        clsUserCollection AnUser = new clsUserCollection();

        //retrieve the value of username from tthe presentation layer
        AnUser.ReportByUserName(txtFilter.Text);

        //set the data source to the list of users in the collection
        lstUserList.DataSource = AnUser.UserList;

        //set the name of the primary key
        lstUserList.DataValueField = "UserID";

        //set the name of the field to display
        lstUserList.DataTextField = "UserName";

        //bind the data to the list
        lstUserList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the user object
        clsUserCollection AnUser = new clsUserCollection();

        //clear any existing filter to tidy up the interface
        AnUser.ReportByUserName("");

        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";

        //set the data source to the list of users in the collection
        lstUserList.DataSource = AnUser.UserList;

        //set the name of the primary key
        lstUserList.DataValueField = "UserID";

        //set the name of the field to display
        lstUserList.DataTextField = "UserName";

        //bind the data to the list
        lstUserList.DataBind() ;
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnUser_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUserLogin
        clsUserLogin AnLogin = new clsUserLogin();

        //get data from the session object
        AnLogin = (clsUserLogin)Session["AnLogin"];

        //display the login name
        Response.Write("Logged in as: " + AnLogin.LoginName);
    }
}