<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="CsharpWebApp.ADO.NET.querystring.form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 85px;
        }
        .auto-style3 {
            width: 206px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><h3>queryString example, receving data form</h3>
        </div>
        <p>
            Received Data from form1:</p>
        <table border="1">
            <tr>
                <td class="auto-style2">Name :</td>
                <td class="auto-style3">
        <asp:Label ID="lblNameResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address :</td>
                <td class="auto-style3">
                    <asp:Label ID="lblResultAdd" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />
    </form>
</body>
</html>
