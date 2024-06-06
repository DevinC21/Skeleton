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
       background: url(https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/6cac3c7e-7310-4788-a635-e9e6b224b84d/dhj6oo2-1394d7a6-9f6e-4c73-b6bd-5f8b9be6f965.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzZjYWMzYzdlLTczMTAtNDc4OC1hNjM1LWU5ZTZiMjI0Yjg0ZFwvZGhqNm9vMi0xMzk0ZDdhNi05ZjZlLTRjNzMtYjZiZC01ZjhiOWJlNmY5NjUuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.EOrkuUxlXZpdkdsGYCAPtQHsbBm6bs1vJPFXF5qerwI) no-repeat;
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
       color: dodgerblue;
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
                 <asp:Label ID="lblCustomer" runat="server" Text="Customer Id"></asp:Label>
             <asp:TextBox ID="txtCustomerId" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>

             <div class="CustomerUsername">
                 <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                 <asp:TextBox ID="txtUsername" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>

             <div class="CustomerPassword">
                 <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                 <asp:TextBox ID="txtPassword" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>

             <div class="CustomerEmail">
                 <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                 <asp:TextBox ID="txtEmail" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>

             <div class="DateOfBirth">
                 <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
                 <asp:TextBox ID="txtDateOfBirth" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>

             <div class="BankDetails">
                 <asp:Label ID="lblBankDetails" runat="server" Text="Bank Details"></asp:Label>
                 <asp:TextBox ID="txtBankDetails" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
             </div>
        
             <div class="CustomerConfirmed">
                 <asp:CheckBox ID="chkConfirmed" runat="server" Text="Confirmed?"/>
             </div>
      
             <div class="Error">
                 <asp:Label ID="lblError" runat="server"></asp:Label>
             </div>
            
             </div>

            <div class="Buttons1">

             <div class="ButtonsOK">
                 <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="60px" />
             </div>

            <div class="ButtonCancel">
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="100px" />
            </div>
            </div>

            <div class="Buttons2">

            <div class="ButtonFind">
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
            </div>

            <div class="ButtonMainMenu">
                 <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu"  BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="160px" OnClick="btnMainMenu_Click"/>
            </div>

            </div>
            </div>
    </form>
</body>
</html>