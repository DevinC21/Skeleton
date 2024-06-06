using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        // Create an instance of the customer book
        clsCustomerCollection Customer = new clsCustomerCollection();
        // find the record to update
        Customer.ThisCustomer.Find(CustomerId);

        //display the data for the record
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtUsername.Text = Customer.ThisCustomer.CustomerUsername.ToString();
        txtPassword.Text = Customer.ThisCustomer.CustomerPass.ToString();
        txtEmail.Text = Customer.ThisCustomer.CustomerEmail.ToString();
        txtDateOfBirth.Text = Customer.ThisCustomer.DateOfBirth.ToString();
        txtBankDetails.Text = Customer.ThisCustomer.BankDetails.ToString();
        chkConfirmed.Checked = Customer.ThisCustomer.CustomerConfirmed;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       //create a new instance of clsCustomer
       clsCustomer AnCustomer = new clsCustomer();

        // capture the username
        String CustomerUsername = txtUsername.Text;

        // capture the password
        String CustomerPass = txtPassword.Text;

        // capture the email
        String CustomerEmail = txtEmail.Text;

        // capture the Bank Details
        String BankDetails = txtBankDetails.Text;

        //capture the UserDob
        String DateOfBirth = txtDateOfBirth.Text;

        // capture the Confirmed
        String CustomerConfirmed = chkConfirmed.Text;

        // Variable to store error messages
        String Error = "";
        //Validates the data
        Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, DateOfBirth, BankDetails);
        if (Error == "")
        {
            AnCustomer.CustomerId = CustomerId;
            AnCustomer.CustomerUsername = CustomerUsername;
            AnCustomer.CustomerPass = CustomerPass;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.BankDetails = Convert.ToInt32(BankDetails);
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnCustomer.CustomerConfirmed = chkConfirmed.Checked;

            //Creates new instance of Customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;

                //add the new record
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }

            // navigate to the view page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // display error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the User class
        clsCustomer AnCustomer = new clsCustomer();

        //create a variable to store the primary key
        Int32 CustomerId;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //find the record
        Found = AnCustomer.Find(CustomerId);

        //if found
        if (Found == true)
        {         
            txtCustomerId.Text = AnCustomer.CustomerId.ToString();
            txtUsername.Text = AnCustomer.CustomerUsername;
            txtPassword.Text = AnCustomer.CustomerPass;
            txtEmail.Text = AnCustomer.CustomerEmail;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtBankDetails.Text = AnCustomer.BankDetails.ToString();
            chkConfirmed.Checked = AnCustomer.CustomerConfirmed;
        }
    }

    protected void chkCustomerConfirmed_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}