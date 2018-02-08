<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="CsharpWebApp.Navigation.AllNavigations.form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>This is page 2, Welcome!!</h2>
        </div>


        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Name :
            <asp:Label ID="lblName" runat="server"></asp:Label>
&nbsp;</p>
        <p>
            Email :
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
        </p>
        <p>
            using hyperlink here,</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Navigation/AllNavigations/form1.aspx">Goto Page1</asp:HyperLink>


    </form>
</body>
</html>
