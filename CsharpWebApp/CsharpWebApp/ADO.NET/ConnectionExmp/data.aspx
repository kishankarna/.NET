<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="CsharpWebApp.ADO.NET.ConnectionExmp.data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lbl" runat="server" ForeColor="#009933"></asp:Label>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            
        </div>
        <p>
            <asp:Button ID="btnCustomer" runat="server" Text="Customer Record" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnMovie" runat="server" Text="Movies Name" OnClick="btnMovie_Click" />
            
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </p>
        <p>
            College Data</p>
        <p>
            <asp:Button ID="btnStudnet" runat="server" OnClick="btnStudnet_Click" Text="Student" />
            <asp:Button ID="btnTeacher" runat="server" OnClick="btnTeacher_Click" Text="Teacher" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
