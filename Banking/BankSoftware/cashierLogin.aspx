<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cashierLogin.aspx.cs" Inherits="BankSoftware.cashierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" >
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
      <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="../scripts/jquery-3.3.1.js"></script>

    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 287px;
        }
    </style>
    </head>
<body>
    <div class="container">
    <h2 class="auto-style1">United Local Bank</h2>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <form id="form1" runat="server">
        <div>
            <table border="1" width="500" align="center" style="background-color:cornflowerblue">
                <tr>
                    <td class="auto-style2">User ID</td>
                    <td>
                        <asp:TextBox ID="txtUsr" runat="server" TabIndex="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TabIndex="2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="46px" ImageUrl="~/images/login.png" Width="74px" OnClick="ImageButton1_Click" TabIndex="3" />
                        <asp:HyperLink ID="hyperlnkRegister" runat="server" NavigateUrl="~/register/cashier.aspx">Not Cashier? Register</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
        </div>
</body>
</html>
