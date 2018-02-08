<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.wizardControl2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table border="1">
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="TxtUsr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ASP.NET Server Controls/wizardControl2/register.aspx">Not User?Register</asp:HyperLink>
                </td>
                <td>
                    <asp:Label ID="Lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
