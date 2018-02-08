<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataPage.aspx.cs" Inherits="CsharpWebApp.ADO.NET.ConnectionExmp.DataPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDsply" runat="server" OnClick="btnDsply_Click" Text="Display Data" />
            <asp:Label ID="lblDsply" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="GridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
