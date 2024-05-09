<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 501px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 31px; top: 102px; position: absolute; bottom: 742px; width: 102px;" Text="Customer Id" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 169px; top: 96px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 31px; top: 146px; position: absolute" Text="Username" height="19px" width="102px"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; top: 143px; position: absolute; left: 169px" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 31px; top: 187px; position: absolute" Text="Password" height="19px" width="102px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 169px; top: 183px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 31px; top: 233px; position: absolute" Text="Email" height="19px" width="102px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 169px; top: 229px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 31px; top: 278px; position: absolute" Text="Date Of Birth" width="102px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 169px; top: 274px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblBankDetails" runat="server" style="z-index: 1; left: 31px; top: 324px; position: absolute" Text="Bank Details" height="19px" width="102px"></asp:Label>
        <asp:TextBox ID="txtBankDetails" runat="server" style="z-index: 1; left: 169px; top: 320px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkConfirmed" runat="server" style="z-index: 1; left: 195px; top: 373px; position: absolute" Text="Confirmed" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 548px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 442px; position: absolute; right: 606px;" Text="OK" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 121px; top: 442px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
