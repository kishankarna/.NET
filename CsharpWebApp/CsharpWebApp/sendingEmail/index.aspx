<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.sendingEmail.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2 class="auto-style2">&nbsp;</h2>
            <h2 class="auto-style2">&nbsp;</h2>
            <h2 class="auto-style2">Send Email:</h2>
        </div>
        <table border="1" align="center">
            <tr>
                <td>From :</td>
                <td>
                    <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>To :</td>
                <td>
                    <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Subject :</td>
                <td>
                    <asp:TextBox ID="txtSubj" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Body :</td>
                <td>
                    <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
                </td>
                <td>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
