<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.isPostBack.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click" />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
       
       
    </form>
    <p>
        Here Buttton click is automatically post back.</p>
</body>
</html>
