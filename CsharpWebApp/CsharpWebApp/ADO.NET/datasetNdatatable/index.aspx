<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ADO.NET.datasetNdatatable.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnD" runat="server" OnClick="btnD_Click" Text="Display Movies" />
            <asp:Label ID="lbl" runat="server"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display Customer" />
            <asp:Label ID="Label1" runat="server" Text="DataTable Example"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
