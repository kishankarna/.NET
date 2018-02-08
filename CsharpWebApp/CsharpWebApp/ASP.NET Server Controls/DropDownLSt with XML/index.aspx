<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.DropDownLSt_with_XML.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Example for XML file linking with DropDownList Server control</h3><br />
            <br />
            This has data from XMl FIle<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            This has data from HTML or from design time<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="-1">Select</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>Nepal</asp:ListItem>
                <asp:ListItem>Canada</asp:ListItem>
            </asp:DropDownList>
            <br />
        </div>
        <asp:Button ID="btnClick" runat="server" Text="Click" OnClick="btnClick_Click" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="lbl" runat="server"></asp:Label>
    </form>
</body>
</html>
