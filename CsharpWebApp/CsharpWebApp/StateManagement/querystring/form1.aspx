<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form1.aspx.cs" Inherits="CsharpWebApp.ADO.NET.querystring.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2>QueryString example 1</h2>
        </div>
        <p>
            Enter Name<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Address<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" style="height: 26px" />
    </form>
</body>
</html>
