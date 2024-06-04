<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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

    body{
       display: flex;
       justify-content: center;
       align-items: center;
       min-height: 100vh;
       background: url(https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/6cac3c7e-7310-4788-a635-e9e6b224b84d/dhj6faq-bf02d0f8-ab92-4010-9f1d-75406cc0ac63.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzZjYWMzYzdlLTczMTAtNDc4OC1hNjM1LWU5ZTZiMjI0Yjg0ZFwvZGhqNmZhcS1iZjAyZDBmOC1hYjkyLTQwMTAtOWYxZC03NTQwNmNjMGFjNjMuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.v-izH8RtoOyy3q6SjfDp7lE9XY-cRdKmUiVviKoZL1E) no-repeat;
       background-size: cover;
       background-position: center;
    }

    .DataEntry{
       width: 520px;
       background: transparent;
       border: 2px solid rgba(0, 0, 0, 0.2);
       backdrop-filter: blur(20px);
       box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
       color: yellow;
       border-radius: 10px;
       padding: 30px 40px;
       display: flex;
       flex-direction: column;
    }

    .StockDataEntry{
       font-size: 36px;
       font-weight: 500;
       text-align:center;
    }

    .Labels{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        padding: 20px;
    }

    .StockID{
        display: flex;
        flex-direction: row;
        gap: 20px;
        align-items: center;
    }

    .Brand{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .Colour{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .TypeOfCar{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .YearOfCar{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .Prices{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .Gearbox{
        display: flex;
        justify-content: center;
        gap: 20px;
    }

    .Buttons1{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .Buttons2{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .ButtonOK{
        padding: 10px;
    }

    .ButtonCancel{
        padding: 10px;
    }

    .ButtonFind{
        padding: 10px;
    }

    .ButtonMainMenu{
        padding: 10px;
    }

</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="DataEntry">

        <div class="StockDataEntry">
        <asp:Label ID="lblDataEntry" runat="server" Text="Stock Data Entry Page"></asp:Label>
        </div>

        <div class="Labels">

        <div class="StockID">
        <asp:Label ID="lblStockID" runat="server" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Brand">
        <asp:Label ID="lblBrand" runat="server" Text="Brand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Colour">
        <asp:Label ID="lblColour" runat="server" Text="Colour"></asp:Label>
        <asp:TextBox ID="txtColour" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="TypeOfCar">
        <asp:Label ID="lblTypeOfCar" runat="server" Text="Type Of Car"></asp:Label>
        <asp:TextBox ID="txtTypeOfCar" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="YearOfCar">
        <asp:Label ID="lblYearOfCar" runat="server" Text="Year Of Car"></asp:Label>
        <asp:TextBox ID="txtYearOfCar" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Prices">
        <asp:Label ID="lblPrices" runat="server" Text="Prices"></asp:Label>
        <asp:TextBox ID="txtPrices" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        </div>

        <div class="Gearbox">
        <asp:CheckBox ID="chkGearbox" runat="server" Text="Gearbox" />
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

        <div class="Buttons1">

        <div class="ButtonOK">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="60px" />
        </div>

        <div class="ButtonCancel">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="100px" />
        </div>

        </div>

        <div class="Buttons2">

        <div class="ButtonFind">
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
        </div>

        <div class="ButtonMainMenu">
        <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="160px" />
        </div>

        </div>

    </div>
    </form>
</body>
</html>