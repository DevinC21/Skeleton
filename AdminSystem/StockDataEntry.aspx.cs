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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //capture the stock ID 
        AnStock.StockID = Convert.ToInt32(txtStockID.Text);

        //capture the brand
        AnStock.Brand = txtBrand.Text;

        //capture the colour
        AnStock.Colour = txtColour.Text;

        //capture the type of car
        AnStock.TypeOfCar = txtTypeOfCar.Text;

        //capture the year of car
        AnStock.YearOfCar = Convert.ToDateTime(txtYearOfCar.Text);

        //capture the price 
        AnStock.Prices = Convert.ToInt32(txtPrices.Text);

        //capture the gearbox
        AnStock.Gearbox = chkGearbox.Checked;   

        Session["AnStock"] = AnStock;

        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
}