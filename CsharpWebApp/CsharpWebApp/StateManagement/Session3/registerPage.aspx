<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerPage.aspx.cs" Inherits="CsharpWebApp.StateManagement.Session3.registerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &quot;<p align="center">Welcome to the Register Section!!</p></div>
        <p align="center">
            &nbsp;</p>
        <p align="center">
            &nbsp;</p>
        <p align="center">
            &nbsp;</p>
        <p align="center">
            &nbsp;</p>
        <p align="center">
            &nbsp;</p>
        <table border="1" align="center">
            <tr>
                <td colspan="2"><strong>User Credentials</strong></td>
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
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Re-Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtRePwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:HyperLink ID="LoginLink" runat="server" NavigateUrl="~/StateManagement/Session3/login.aspx" align="center">Go Back</asp:HyperLink>
    </form>
</body>
</html>
