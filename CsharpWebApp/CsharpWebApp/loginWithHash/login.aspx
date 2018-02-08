<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CsharpWebApp.loginWithHash.login" %>

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
        <div><h2>Login with hashing technique</h2>
            <table border="1">
            <tr>
                <td>User Name : </td>
                <td>
                    <asp:TextBox ID="TxtUsr" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password : </td>
                <td>
                    <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnLog" runat="server" Text="Login" OnClick="BtnLog_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/loginWithHash/register.aspx">Not a User?Register</asp:HyperLink>
                </td>
                <td>
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
