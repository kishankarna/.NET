<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.panelControl.index" %>

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
            Example for using panel control, it is a container for controls<br />
            <br />
            <br />
            <br />
            Login as: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Guest</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Panel ID="PanelAdmin" runat="server" Height="164px">
            <asp:Label ID="Label1" runat="server" Text="Admin User" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:TextBox ID="TxtAdmnName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address : </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phone : </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td>
                        <asp:Label ID="lblAdmin" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelGuest" runat="server">
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Guest User"></asp:Label>
            <table class="auto-style1">
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:TextBox ID="TxtGuestName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address : </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phone : </td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                    </td>
                    <td>
                        <asp:Label ID="lblGuest" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
