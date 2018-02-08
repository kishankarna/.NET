<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="BankSoftware.logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
        <div class="auto-style1">
        </div>
        <h3 class="auto-style2">Thank you for Banking with us!!</h3>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/images/login.png" Width="83px" OnClick="ImageButton2_Click" />
        </div>
    </form>
</body>
</html>
