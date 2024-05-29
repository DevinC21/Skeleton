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


        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute;"></asp:Label>
        
    </form>
</body>
</html>
