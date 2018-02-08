<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CsharpWebApp.StateManagement.Session3.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 171px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table  border="1" align="center">
            <tr>
                <td colspan="2"><strong>User Login</strong></td>
            </tr>
            <tr>
                <td>User Name :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLog" runat="server" Text="Login" OnClick="btnLog_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    <p align="center">
        Not a User? <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateManagement/Session3/registerPage.aspx">Register</asp:HyperLink>
        </p>
    </form>
    </body>
</html>
