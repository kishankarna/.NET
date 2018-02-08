<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="CsharpWebApp.security.FormSecurity.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 20%;
            border:solid;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1" align="center">
                <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="txtUsr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password :</td>
                    <td>
                        <asp:TextBox ID="txtRepwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
