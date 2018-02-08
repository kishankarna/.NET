<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.CascadingDropDwnLstControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ContinentID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cs %>" SelectCommand="spContinent" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </p>
        <div>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </div>
        <p>
            &nbsp;</p>
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
