<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.HiddenField.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 102px;
        }
        .auto-style3 {
            width: 102px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
            width: 128px;
        }
        .auto-style5 {
            width: 128px;
        }
        .auto-style6 {
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Here, hidden field has ID value and when press button then displayed in lbl</div>
        <table border="1"
            <tr class="auto-style6">
                <td class="auto-style3">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Batch</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtBatch" runat="server"  style="width: 128px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="hiddenIdField" runat="server" />
    </form>
</body>
</html>
