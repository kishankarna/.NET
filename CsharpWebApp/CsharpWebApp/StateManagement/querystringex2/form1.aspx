<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form1.aspx.cs" Inherits="CsharpWebApp.StateManagement.querystringex2.form1" %>

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
        <div><h1>This is querystring example 2</h1>
        </div>
        <table border="1">
            <tr>
                <td>Enter First Number</td>
                <td>
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Second Number</td>
                <td>
                    <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:DropDownList ID="DrpOperator" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpOperator_SelectedIndexChanged">
                        <asp:ListItem>Select Operation</asp:ListItem>
                        <asp:ListItem>sub</asp:ListItem>
                        <asp:ListItem>add</asp:ListItem>
                        <asp:ListItem>mul</asp:ListItem>
                        <asp:ListItem>div</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
