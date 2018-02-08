<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserTemplate.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CsharpWebApp.MasterPages.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style10 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <h3>This is Login Page</h3>
    <table class="auto-style10">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="Submit" OnClick="btnLogin_Click" />
            </td>
        </tr>
</table>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
