<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form1.aspx.cs" Inherits="CsharpWebApp.StateManagement.querystringwADO.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>Form1, Displays all the databases from the system</h2>
        </div>
        <asp:DropDownList ID="DrpListDatabases" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpListDatabases_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
