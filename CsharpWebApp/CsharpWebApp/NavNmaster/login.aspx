<%@ Page Title="" Language="C#" MasterPageFile="~/NavNmaster/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CsharpWebApp.NavNmaster.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            height: 23px;
        }
        .auto-style12 {
            width: 289px;
            height: 14px;
        }
        .auto-style13 {
            width: 795px;
        }
        .auto-style14 {
            width: 795px;
            height: 14px;
        }
        .auto-style15 {
            width: 289px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Login...</p>
    <table border="1" width="100">
        <tr>
            <td class="auto-style12">User Name</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtUsr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Password</td>
            <td class="auto-style13">
                <asp:TextBox ID="txtPss" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Button ID="btbLog" runat="server" Text="Login" OnClick="btbLog_Click" />
            </td>
            <td class="auto-style13">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
