<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="CsharpWebApp.StateManagement.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <p>
        <h2>ViewState Example</h2>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;<asp:Label ID="Label1" runat="server" EnableViewState="False" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <asp:Label ID="Label2" runat="server" EnableViewState="False" Text="Label"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:Calendar ID="Calendar1" runat="server" EnableViewState="False" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>&nbsp;</form>
    </p>
</body>
</html>
