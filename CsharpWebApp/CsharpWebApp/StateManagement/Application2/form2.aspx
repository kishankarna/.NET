<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="CsharpWebApp.StateManagement.Application2.form2" %>

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
        <p>
            Name:
            <asp:Label ID="lblName" runat="server"></asp:Label>
        </p>
        <p>
            Address:
            <asp:Label ID="lblAdd" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
