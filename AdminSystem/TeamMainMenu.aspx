<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 200px; top: 30px; position: absolute" Text="Team Auto Main Menu"></asp:Label>

        <asp:Button ID="btnUser" runat="server" style="z-index: 1; left: 225px; top: 60px; position: absolute;" width="100px" Text="Users" OnClick="btnUser_Click" />
        <asp:Button ID="btnOrders" runat="server" style="z-index: 1; left: 225px; top: 90px; position: absolute" width="100px" Text="Orders" OnClick="btnOrders_Click" />
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 225px; top: 120px; position: absolute" width="100px" Text="Customers" OnClick="btnCustomer_Click" />
        <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 225px; top: 150px; position: absolute" width="100px" Text="Stock" OnClick="btnStock_Click" />
    
    </form>
</body>
</html>
