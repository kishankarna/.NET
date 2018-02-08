<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="CsharpWebApp.loginWithHash.logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>You are Logged Out!! Thank you for joining us.</h2>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/loginWithHash/login.aspx">Log Back</asp:HyperLink>
    </form>
</body>
</html>
