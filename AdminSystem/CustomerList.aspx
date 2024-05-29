<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ListBox ID="lstCustomerList" runat="server" Height="228px" Width="269px"></asp:ListBox>
        
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 250px; position: absolute;" width="60px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 250px; position: absolute;" width="60px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 150px; top: 250px; position: absolute;" width="60px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 18px; top: 300px; position: absolute" Text="Enter a Username"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 153px; top: 300px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 15px; top: 350px; position: absolute" width="120px" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 165px; top: 350px; position: absolute" width="120px" Text="Clear Filter" OnClick="btnClearFilter_Click" />


        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 400px; position: absolute;"></asp:Label>
        
    </form>
</body>
</html>
