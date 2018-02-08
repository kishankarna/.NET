<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="CsharpWebApp.ADO.NET.datasetNdatatable.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnM" runat="server" OnClick="btnM_Click" Text="Display Movies" />
            <asp:Label runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnC" runat="server" OnClick="btnC_Click" Text="Display Customer" />
            Dataset example with data table<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
