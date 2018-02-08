<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listBox.aspx.cs" Inherits="CsharpWebApp.ListControls.listBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>ListBox example in c sharp</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Bullet List</td>
                <td>CheckBox List</td>
                <td>DropDown List</td>
                <td>ListBox</td>
                <td>RadioButton List</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
                    </asp:BulletedList>
                </td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    </asp:CheckBoxList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
                </td>
                <td colspan="2">
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
