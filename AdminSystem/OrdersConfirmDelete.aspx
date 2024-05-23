<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
             <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 43px; top: 184px; position: absolute; width: 57px;" Text="Yes" />
        </p>
        <p>
            &nbsp;</p>
             <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 138px; top: 185px; position: absolute; width: 73px;" Text="No" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDeleteRecord" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
