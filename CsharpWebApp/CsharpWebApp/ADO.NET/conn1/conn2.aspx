<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="conn2.aspx.cs" Inherits="CsharpWebApp.ADO.NET.conn1.conn2" %>

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
        <div>
        </div>
        <table border="1">
            <tr>
                <td>Movie ID</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
               
            </tr>
            <tr>
                <td>Movie Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td>Duration</td>
                <td>
                    <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Release Date</td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                </td>
                
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
