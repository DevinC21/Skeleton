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
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();

        //set the data source to list of users in the collection
        lstStockList.DataSource = Stocks.StockList;

        //set the name of the primary key
        lstStockList.DataValueField = "StockID";

        //set the data field to display
        lstStockList.DataTextField = "Brand";

        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;

        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockID;

        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstStockList.SelectedValue);

            //store the data in the session object
            Session["StockID"] = StockID;

            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
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
        Int32 StockID;

        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstStockList.SelectedValue);

            //store the data in the session object
            Session["StockID"] = StockID;

            //redirect to the edit page
            Response.Redirect("StockConfirmDelete.aspx");
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
        clsStockCollection AnStock = new clsStockCollection();

        //retrieve the value of username from tthe presentation layer
        AnStock.ReportByBrand(txtFilter.Text);

        //set the data source to the list of users in the collection
        lstStockList.DataSource = AnStock.StockList;

        //set the name of the primary key
        lstStockList.DataValueField = "StockID";

        //set the name of the field to display
        lstStockList.DataTextField = "Brand";

        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the user object
        clsStockCollection AnStock = new clsStockCollection();

        //clear any existing filter to tidy up the interface
        AnStock.ReportByBrand("");

        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";

        //set the data source to the list of users in the collection
        lstStockList.DataSource = AnStock.StockList;

        //set the name of the primary key
        lstStockList.DataValueField = "StockID";

        //set the name of the field to display
        lstStockList.DataTextField = "Brand";

        //bind the data to the list
        lstStockList.DataBind();
    }
}