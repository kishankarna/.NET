<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplicationUsing_LINQ.GridView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2> Linq Example 1</h2>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display Name" />
        <asp:Button ID="btnEven" runat="server" OnClick="btnEven_Click" Text="Display Even Numbers" />
        <asp:Button ID="btnOdd" runat="server" OnClick="btnOdd_Click" Text="Display Odd Numbers" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
