<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.panelcontorl2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Generate the controls dynamically inside the panel:<br />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <br />
            <asp:Button ID="btnLabl" runat="server" OnClick="btnLabl_Click" Text="Create Label" />
            <asp:Button ID="btnCreateTxt" runat="server" OnClick="btnCreateTxt_Click" Text="Create Text" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
