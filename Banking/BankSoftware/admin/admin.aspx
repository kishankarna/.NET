<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BankSoftware.admin.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    <table border="1" style="width:400px" align="center">
        <tr>
            <td colspan="2" class="auto-style1"><h2>Admin Users</h2></td>
        </tr>
        <tr>
            <td>Active Application : </td>
            <td>
                <asp:Label ID="lblApp" runat="server" Width="100px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Active Users :</td>
            <td>
                <asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/accountSettings.aspx">Go Back</asp:HyperLink>
            </td>
            <td>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
