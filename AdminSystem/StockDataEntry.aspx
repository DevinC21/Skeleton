<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <p>
        <asp:Label ID="lblStockId" runat="server" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="txtStockId" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblBrand" runat="server" Text="Brand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblColour" runat="server" Text="Colour"></asp:Label>
        <asp:TextBox ID="txtColour" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblTypeOfCar" runat="server" Text="Type Of Car"></asp:Label>
        <asp:TextBox ID="txtTypeOfCar" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblGearbox" runat="server" Text="Gearbox"></asp:Label>
        <asp:TextBox ID="txtGearbox" runat="server" OnTextChanged="txtGearbox_TextChanged"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblYearOfCar" runat="server" Text="Year Of Car"></asp:Label>
        <asp:TextBox ID="txtYearOfCar" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>

        <p>
        
        </p>
    </form>
</body>
</html>

