<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.Error_Handling_in_ASP.NET.index" %>

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
            This page shows the country list frm XML file</p>
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnCountry" runat="server" OnClick="btnCountry_Click" Text="Display Countries" />
            <asp:Button ID="btnException" runat="server" OnClick="btnException_Click" Text="Exception Handling Button" />
            <asp:Button ID="btnErrorEvent" runat="server" Text="Error Event handling" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
