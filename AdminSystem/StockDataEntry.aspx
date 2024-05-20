<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 120px; top: 30px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute" Text="Brand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 120px; top: 60px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute" Text="Colour"></asp:Label>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 120px; top: 90px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblTypeOfCar" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute" Text="Type Of Car"></asp:Label>
        <asp:TextBox ID="txtTypeOfCar" runat="server" style="z-index: 1; left: 120px; top: 120px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblYearOfCar" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Year Of Car"></asp:Label>
        <asp:TextBox ID="txtYearOfCar" runat="server" style="z-index: 1; left: 120px; top: 150px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblPrices" runat="server" style="z-index: 1; left: 10px; top: 180px; position: absolute" Text="Prices"></asp:Label>
        <asp:TextBox ID="txtPrices" runat="server" style="z-index: 1; left: 120px; top: 180px; position: absolute"></asp:TextBox>

        <asp:CheckBox ID="chkGearbox" runat="server" style="z-index: 1; left: 120px; top: 210px; position: absolute" Text="Gearbox" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 240px; position: absolute" Text=""></asp:Label>

        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 270px; width: 40px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 65px; top: 270px; width: 70px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 300px; top: 30px; width: 60px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        
    </form>
</body>
</html>