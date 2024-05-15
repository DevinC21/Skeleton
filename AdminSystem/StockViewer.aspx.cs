using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];

        //display the stock ID for this entry
        Response.Write(AnStock.StockID);

        //display the brand for this entry
        Response.Write(AnStock.Brand);

        //display the colour for this entry
        Response.Write(AnStock.Colour);

        //display the type of car for this entry
        Response.Write(AnStock.TypeOfCar);

        //display the year of car for this entry
        Response.Write(AnStock.YearOfCar);

        //display the gearbox for this entry
        Response.Write(AnStock.Gearbox);

        //display the price for this entry
        Response.Write(AnStock.Prices);
    }
}