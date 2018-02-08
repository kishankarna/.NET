<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ADO.NET.CRUD_Operation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 192px;
        }
        .auto-style4 {
            width: 192px;
            height: 25px;
        }
        .auto-style5 {
            width: 176px;
            height: 25px;
        }
        .auto-style6 {
            width: 176px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><h2>CRUD Operation in C#</h2>
            <h4>Search Customers Record</h4>
            <table border="1">
                <tr>
                    <td class="auto-style4">ID</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Name</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Address</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Phone</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click" />
                        <asp:Button ID="btnUpdat" runat="server" Text="Update" OnClick="btnUpdat_Click" />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table border="1">
            <tr>
                <td>
                    Customers Record in File:</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
