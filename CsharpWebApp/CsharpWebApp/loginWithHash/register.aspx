<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CsharpWebApp.loginWithHash.register" %>

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
        <div><h2>Register Page:</h2>
        </div>
        <table border="1">
            <tr>
                <td>User Name :</td>
                <td>
                    <asp:TextBox ID="TxtUsr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password :</td>
                <td>
                    <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Re-Password :</td>
                <td>
                    <asp:TextBox ID="TxtRPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnRegister" runat="server" Text="Submit" OnClick="BtnRegister_Click" />
                    <asp:Button ID="BtnBack" runat="server" Text="GoBack" OnClick="BtnBack_Click" />
                </td>
                <td>
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
