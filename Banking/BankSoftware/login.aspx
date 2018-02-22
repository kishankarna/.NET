<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BankSoftware.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <form id="form1" runat="server">
        <div>
    <h2 class="auto-style1">United Local Bank</h2>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
        <div>
            <table border="1" width="500" align="center" style="background-color:cornflowerblue">
                <tr>
                    <td colspan="2"><h2 class="auto-style1">Login Window</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">User ID</td>
                    <td>
                        <asp:TextBox ID="txtUsr" runat="server" TabIndex="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TabIndex="2" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="46px" ImageUrl="~/images/login.png" Width="74px" OnClick="ImageButton1_Click" TabIndex="3" />
                        <asp:HyperLink ID="hyperlnkCusRegister" runat="server" NavigateUrl="~/register/customer.aspx">Not Customer? Register</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
