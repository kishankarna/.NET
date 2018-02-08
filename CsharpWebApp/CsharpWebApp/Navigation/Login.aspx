<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CsharpWebApp.Navigation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 293px;
        }
        .auto-style3 {
            width: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>School Management</h1>
            <br />
            <br />
            <br />
            <h3>Login</h3><br />
            <table border="1">
                <tr>
                    <td class="auto-style3">User Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Submit" />
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lbl" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
