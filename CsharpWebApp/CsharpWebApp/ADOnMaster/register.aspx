<%@ Page Title="" Language="C#" MasterPageFile="~/ADOnMaster/Master.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CsharpWebApp.ADOnMaster.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 505px;
        }
        .auto-style5 {
            width: 141px;
        }
        .auto-style6 {
            width: 322px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <table border="1" class="auto-style4">
        <tr>
            <td class="auto-style5">Create User Name</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtUsr" runat="server" Width="157px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Create Password</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtPss" runat="server" Width="155px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Re-Enter Password</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtRenterPss" runat="server" Width="157px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="chkTerms" runat="server" Text="Accept Terms and Conditions" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                <asp:Button ID="btnLog" runat="server" OnClick="btnLog_Click" Text="Login" />
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblDisp" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
