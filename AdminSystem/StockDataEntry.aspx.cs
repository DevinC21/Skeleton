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
        //create a new instance of clsUser
        clsStock AnStock = new clsStock();

        //capture the StockID
        string StockID = txtStockID.Text;

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
            //capture the brand
            AnStock.Brand = txtBrand.Text;

            //capture the colour
            AnStock.Colour = txtColour.Text;

            //capture the type of car
            AnStock.TypeOfCar = txtTypeOfCar.Text;

            //capture the type of car
            AnStock.YearOfCar = Convert.ToDateTime(txtYearOfCar.Text);

            //store the address in the session object
            Session["AnStock"] = AnStock;

            //navigate to the view page
            Response.Redirect("StockViewer.aspx");
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
}