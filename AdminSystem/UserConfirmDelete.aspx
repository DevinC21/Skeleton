<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 55px; top: 60px; position: absolute; width: 45px; right: 504px;" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 135px; top: 60px; position: absolute; width: 40px;" Text="No" OnClick="btnNo_Click" />
    </form>
    </body>
</html>
