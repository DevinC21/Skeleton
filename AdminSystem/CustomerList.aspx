<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ListBox ID="lstCustomerList" runat="server" Height="239px" Width="294px"></asp:ListBox>
        
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 54px; top: 290px; position: absolute;" width="60px" Text="Add" height="26px" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 163px; top: 290px; position: absolute;" width="60px" Text="Edit" OnClick="btnEdit_Click" height="26px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 266px; top: 290px; position: absolute;" width="60px" Text="Delete" OnClick="btnDelete_Click" height="26px" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 47px; top: 362px; position: absolute" Text="Enter a Username"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 191px; top: 361px; position: absolute; width: 161px;"></asp:TextBox>

        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 34px; top: 426px; position: absolute" width="120px" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 188px; top: 426px; position: absolute" width="120px" Text="Clear Filter" OnClick="btnClearFilter_Click" />
         <asp:Button ID="BtnMainMenu" runat="server" style="z-index: 1; left: 365px; top: 426px; position: absolute; width: 163px;" Text="Return to Main Menu" OnClick="BtnMainMenu_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 488px; position: absolute;"></asp:Label>
        
    </form>
</body>
</html>
