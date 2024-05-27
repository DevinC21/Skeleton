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
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockID = Convert.ToInt32(Session["StockID"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StockID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock
        clsStockCollection Stock = new clsStockCollection();

        //find the record to update
        Stock.ThisStock.Find(StockID);

        //display the data for the record
        txtStockID.Text = Stock.ThisStock.StockID.ToString();
        txtBrand.Text = Stock.ThisStock.Brand.ToString();
        txtColour.Text = Stock.ThisStock.Colour.ToString();
        txtTypeOfCar.Text = Stock.ThisStock.TypeOfCar.ToString();
        txtYearOfCar.Text = Stock.ThisStock.YearOfCar.ToString();
        chkGearbox.Checked = Stock.ThisStock.Gearbox;
        txtPrices.Text = Stock.ThisStock.Prices.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsStock AnStock = new clsStock();

        //capture the Brand
        string Brand = txtBrand.Text;

        //capture the Colour
        string Colour = txtColour.Text;

        //capture the TypeOfCar
        string TypeOfCar = txtTypeOfCar.Text;

        //capture the Gearbox
        string Gearbox = chkGearbox.Text;

        //capture the YearOfCar
        string YearOfCar = txtYearOfCar.Text;

        //capture the Prices
        string Prices = txtPrices.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnStock.Valid(Brand, Colour, TypeOfCar, YearOfCar);
        if (Error == "")
        {
            //capture the StockID
            AnStock.StockID = StockID;

            //capture the brand
            AnStock.Brand = txtBrand.Text;

            //capture the colour
            AnStock.Colour = txtColour.Text;

            //capture the type of car
            AnStock.TypeOfCar = txtTypeOfCar.Text;

            //capture the type of car
            AnStock.YearOfCar = Convert.ToDateTime(txtYearOfCar.Text);

            //capture the Gearbox
            AnStock.Gearbox = chkGearbox.Checked;

            //capture the Prices
            AnStock.Prices = Convert.ToInt32(Prices);

            //create a new instance of the user collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. UserID = -1 then add the data
            if (StockID == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AnStock;

                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockID);

                //set the ThisStock property
                StockList.ThisStock = AnStock;

                //update the record
                StockList.Update();
            }

            //navigate to the view page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the User class
        clsStock AnStock = new clsStock();

        //create a variable to store the primary key
        Int32 StockID;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        StockID = Convert.ToInt32(txtStockID.Text);

        //find the record
        Found = AnStock.Find(StockID);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockID.Text = AnStock.StockID.ToString();
            txtBrand.Text = AnStock.Brand;
            txtColour.Text = AnStock.Colour;
            txtTypeOfCar.Text = AnStock.TypeOfCar;
            txtYearOfCar.Text = AnStock.YearOfCar.ToString();
            chkGearbox.Checked = AnStock.Gearbox;
            txtPrices.Text = AnStock.Prices.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}