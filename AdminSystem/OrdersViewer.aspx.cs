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
            //create a new instance of clsOrders
            clsOrders AnOrders = new clsOrders();
            //get the data from the session object
            AnOrders = (clsOrders)Session["AnOrders"];
            //display the order fullname for this entry
            Response.Write(AnOrders.OrderFullName);
            Response.Write(AnOrders.OrderDescription);
            Response.Write(AnOrders.OrderReturn);
            Response.Write(AnOrders.OrderStatus);

    }

}