<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <style>

  @import url('https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap');

  * {
     margin: 0px;
     padding: 0px;
     box-sizing: border-box;
     font-family: "Poppins", sans-serif;
  }

  text{
     display: flex;
     justify-content: center;
     align-items: center;
  }

  body{
     display: flex;
     justify-content: center;
     align-items: center;
     min-height: 100vh;
     background: url(https://i.ebayimg.com/00/s/NTc2WDEwMjQ=/z/MnMAAOSwuENePCf7/$_86.JPG) no-repeat;
     background-size: cover;
     background-position: center;
  }

  .List{
     display: flex;
     justify-content: center;
     flex-direction: column;
     width: 520px;
     background: transparent;
     border: 2px solid rgba(0, 0, 0, 0.4);
     backdrop-filter: blur(30px);
     box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
     color: #fff;
     border-radius: 10px;
     padding: 40px 40px;
  }

  .Label{
     font-size: 36px;
     font-weight: 500;
     text-align:center;
  }

  .CustomerList{
     display: flex;
     justify-content: center;
     align-items: center;
  }

  .Buttons{
     display: flex;
     flex-direction: row;
     justify-content: center;
     align-items: center;
     gap: 20px;
     padding-top: 20px;
  }

  .Buttons2{
     display: flex;
     flex-direction: row;
     justify-content: center;
     align-items: center;
     gap: 20px;
     padding-top: 20px;
  }

  .Filter{
     display: flex;
     flex-direction: row;
     justify-content: center;
     align-items: center;
     gap: 20px;
     padding-top: 20px;
  }

 .Customer{
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    padding-top: 20px;
 }

  </style>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="List">

        <div class="Label">
        <asp:Label ID="lblCustomer" runat="server" Text="Customer List Page"></asp:Label>
        </div>

        <div class="CustomerList">
        <asp:ListBox ID="lstCustomerList" runat="server" Height="250px" Width="500px" BackColor="Transparent" ForeColor="White"></asp:ListBox>
        </div>

        <div class="Buttons">
        <asp:Button ID="btnAdd" runat="server" Width="60px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"  Text="Add" OnClick="btnAdd_Click"/>
        <asp:Button ID="btnEdit" runat="server" Width="60px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Text="Edit" OnClick="btnEdit_Click"/>
        <asp:Button ID="btnDelete" runat="server" Width="60px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Text="Delete" OnClick="btnDelete_Click"/>
        </div>

        <div class="Filter">
        <asp:Label ID="lblFilter" runat="server"  Text="Enter a Username" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Buttons2">
        <asp:Button ID="btnApplyFilter" runat="server" Width="140px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" Width="140px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <asp:Button ID="BtnMainMenu" runat="server" Width="140px" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Text="Return to Main Menu" OnClick="BtnMainMenu_Click" />
        </div>

         <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>