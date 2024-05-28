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

        // capture the Confirmed
        String CustomerConfirmed = chkConfirmed.Text;

        //capture the UserDob
        String DateOfBirth = txtDateOfBirth.Text;

        //capture the CustomerID
        String CustomerId = txtCustomerId.Text;

        // Variable to store error messages
        String Error = "";
        //Validates the data
        Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, BankDetails, DateOfBirth);
        if (Error == "")
        {
            AnCustomer.CustomerUsername = CustomerUsername;
            AnCustomer.CustomerPass = CustomerPass;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.BankDetails = Convert.ToInt32(BankDetails);
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);

            //Creates new instance of Customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //Set the ThisCustomer property
            CustomerList.ThisCustomer = AnCustomer;
            // add new record
            CustomerList.Add();

            // navigate to the view page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        Int32 CustomerId;

        Boolean Found = false;

        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        Found = AnCustomer.Find(CustomerId);

        if (Found == true)
        {
            txtUsername.Text = AnCustomer.CustomerUsername;
            txtPassword.Text = AnCustomer.CustomerPass;
            txtEmail.Text = AnCustomer.CustomerEmail;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtBankDetails.Text = AnCustomer.BankDetails.ToString();
            chkConfirmed.Checked = AnCustomer.CustomerConfirmed;
        }
    }
}