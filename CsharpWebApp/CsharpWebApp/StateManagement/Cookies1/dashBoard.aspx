<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashBoard.aspx.cs" Inherits="CsharpWebApp.StateManagement.Cookies1.dashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUser" runat="server"></asp:Label>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateManagement/Cookies1/LogOut.aspx">LogOut</asp:HyperLink>
    </form>
</body>
</html>
