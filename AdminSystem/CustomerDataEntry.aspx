<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

        <style>

    @import url('https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap');

    * {
       margin: 0px;
       padding: 0px;
       box-sizing: border-box;
       font-family: "Poppins", sans-serif;
    }

    body{
       display: flex;
       justify-content: center;
       align-items: center;
       min-height: 100vh;
       background: url(https://images.hdqwalls.com/download/ferrari-458-italia-rear-cgi-pm-1440x900.jpg) no-repeat;
       background-size: cover;
       background-position: center;
    }

    .DataEntry{
       width: 520px;
       background: transparent;
       border: 2px solid rgba(0, 0, 0, 0.2);
       backdrop-filter: blur(20px);
       box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
       color: #fff;
       border-radius: 10px;
       padding: 30px 40px;
       display: flex;
       flex-direction: column;
    }

    .CustomerDataEntry{
       font-size: 36px;
       font-weight: 500;
       text-align:center;
    }

    .Labels{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        padding: 20px;
    }

    .CustomerId{
        display: flex;
        flex-direction: row;
        gap: 20px;
        align-items: center;
    }

    .CustomerUsername{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .CustomerPassword{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .CustomerEmail{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .DateOfBirth{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .BankDetails{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .CustomerConfirmed{
        display: flex;
        justify-content: center;
        gap: 20px;
    }

    .Buttons1{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .Buttons2{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .ButtonOK{
        padding: 10px;
    }

    .ButtonCancel{
        padding: 10px;
    }

    .ButtonFind{
        padding: 10px;
    }

    .ButtonMainMenu{
        padding: 10px;
    }

</style>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="DataEntry">
         <div class="CustomerDataEntry">
         <asp:Label ID="lblDataEntry" runat="server" Text="Customer Data Entry Page"></asp:Label>
         </div>

         <div class="Labels">

             <div class="CustomerId">
             <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 31px; top: 102px; position: absolute; bottom: 742px; width: 102px;" Text="Customer Id" height="19px"></asp:Label>
             <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 169px; top: 96px; position: absolute; right: 268px;" height="22px" width="128px"></asp:TextBox>
             </div>

             <div class="CustomerUsername">
             <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 31px; top: 146px; position: absolute" Text="Username" height="19px" width="102px"></asp:Label>
             <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; top: 143px; position: absolute; left: 169px" height="22px" width="128px"></asp:TextBox>
             </div>

             <div class="CustomerPassword">
             <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 31px; top: 187px; position: absolute" Text="Password" height="19px" width="102px"></asp:Label>
             <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 169px; top: 183px; position: absolute" height="22px" width="128px"></asp:TextBox>
             </div>

             <div class="CustomerEmail">
             <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 31px; top: 233px; position: absolute" Text="Email" height="19px" width="102px"></asp:Label>
             <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 169px; top: 229px; position: absolute" height="22px" width="128px"></asp:TextBox>
             </div>

             <div class="DateOfBirth">
             <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 31px; top: 278px; position: absolute" Text="Date Of Birth" width="102px"></asp:Label>
             <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 169px; top: 274px; position: absolute" height="22px" width="128px"></asp:TextBox>
             </div>

             <div class="BankDetails">
             <asp:Label ID="lblBankDetails" runat="server" style="z-index: 1; left: 31px; top: 324px; position: absolute" Text="Bank Details" height="19px" width="102px"></asp:Label>
             <asp:TextBox ID="txtBankDetails" runat="server" style="z-index: 1; left: 169px; top: 320px; position: absolute" height="22px" width="128px"></asp:TextBox>
             </div>

             </div>
        
             <div class="CustomerConfirmed">
             <asp:CheckBox ID="chkConfirmed" runat="server" style="z-index: 1; left: 195px; top: 373px; position: absolute" Text="Confirmed" />
             </div>
      
             <div class="Error">
                  <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 537px; position: absolute"></asp:Label>
             </div>

             <div class="ButtonsOK">
                 <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 442px; position: absolute; right: 606px;" Text="OK" height="26px" width="60px" />
             </div>

            <div class="ButtonCancel">
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 121px; top: 442px; position: absolute" Text="Cancel" />
            </div>

            <div class="ButtonFind">
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 348px; top: 97px; position: absolute" Text="Find" />
            </div>

            <div class="ButtonMainMenu">
                 <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 280px; top: 442px; position: absolute; width: 163px;" Text="Return to Main Menu" OnClick="BtnMainMenu_Click"/>
            </div>
        
            </div>
    </form>

</body>
</html>
