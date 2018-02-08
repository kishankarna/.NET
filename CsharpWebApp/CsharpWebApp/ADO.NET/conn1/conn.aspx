<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="conn.aspx.cs" Inherits="CsharpWebApp.ADO.NET.conn1.conn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table border="1" >
            <tr>
                <td>Movie Id</td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td>Movie Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Movie Duration</td>
                <td>
                    <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Release Date</td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
