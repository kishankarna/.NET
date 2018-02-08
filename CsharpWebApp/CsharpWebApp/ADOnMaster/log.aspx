<%@ Page Title="" Language="C#" MasterPageFile="~/ADOnMaster/Master.Master" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="CsharpWebApp.ADOnMaster.log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 158px;
        }
        .auto-style5 {
            width: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        Login Credential</p>
    <table border="1">
        <tr>
            <td class="auto-style5">User Name</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnLogin" runat="server" Text="Log-in" OnClick="btnLogin_Click" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="lbl" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
