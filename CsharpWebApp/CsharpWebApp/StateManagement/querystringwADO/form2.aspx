<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="CsharpWebApp.StateManagement.querystringwADO.form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>Form2,  List of tables from the selected database:</h2>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateManagement/querystringwADO/form1.aspx">Go back</asp:HyperLink>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>
