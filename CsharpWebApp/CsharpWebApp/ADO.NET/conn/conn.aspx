﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="conn.aspx.cs" Inherits="CsharpWebApp.ADO.NET.conn.conn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <asp:Button ID="btnMovie" runat="server" OnClick="btnMovie_Click" Text="Display Movie" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
