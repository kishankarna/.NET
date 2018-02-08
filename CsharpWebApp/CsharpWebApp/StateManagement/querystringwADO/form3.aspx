<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form3.aspx.cs" Inherits="CsharpWebApp.StateManagement.querystringwADO.form3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>Form2, Data from the selected table</h2>
        </div>
        <asp:Label ID="lblTable" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateManagement/querystringwADO/form1.aspx">Go Back to First Page</asp:HyperLink>
    </form>
</body>
</html>
