<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
     <asp:ListBox ID="lstStockList" runat="server" Height="350px" Width="500px"></asp:ListBox>
         <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 85px; top: 400px; position: absolute;" width="60px" Text="Add" />
         <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 200px; top: 400px; position: absolute;" width="80px" Text="Edit" OnClick="btnEdit_Click" />
         <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 320px; top: 400px; position: absolute" width="100px" Text="Delete" OnClick="btnDelete_Click" />

         <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 115px; top: 460px; position: absolute" Text="Enter a Brand"></asp:Label>
         <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 260px; top: 460px; position: absolute"></asp:TextBox>

         <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 65px; top: 520px; position: absolute" width="120px" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
         <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 210px; top: 520px; position: absolute" width="120px" Text="Clear Filter" OnClick="btnClearFilter_Click" />
         <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 360px; top: 520px; position: absolute" width="160px" Text="Return to Main Menu" OnClick="btnMainMenu_Click"/>


         <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 115px; top: 600px; position: absolute;"></asp:Label>
 </form>
</body>
</html>
