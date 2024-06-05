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
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayCustomers();
        }

        // create a new instance of clsCustomerLogin
        clsCustomerLogin AnLogin = new clsCustomerLogin();
        // get data from the session object
        AnLogin = (clsCustomerLogin)Session["AnLogin"];
        // display the name
        //Response.Write("Logged in as: " + AnLogin.LoginName);
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "CustomerUsername";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate as a new record
        Session["CustomerId"] = -1;
        // Redirect to the Data Entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerId;
        // If a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            // Get the primary Key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            // store the data in the session object
            Session["CustomerId"] = CustomerId;
            // redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else    // if no record has been selected
        {
            lblError.Text = "Please Select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            // get the primary key value of the record delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            // store the data in the session object
            Session["CustomerId"] = CustomerId;
            // redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            // display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        // retrieve the value of post code from the presentation layer
        AnCustomer.ReportByCustomerUsername(txtFilter.Text);
        // set the data source to the list of Customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        // set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        // set the name of the firled to display
        lstCustomerList.DataTextField = "CustomerUsername";
        // bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        // set an empty string
        AnCustomer.ReportByCustomerUsername("");
        // clear any existing filter ot tidy up the interface
        txtFilter.Text = "";
        // set the data source to the list of Customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        // set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        // set the name of the firled to display
        lstCustomerList.DataTextField = "CustomerUsername";
        // bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void BtnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}