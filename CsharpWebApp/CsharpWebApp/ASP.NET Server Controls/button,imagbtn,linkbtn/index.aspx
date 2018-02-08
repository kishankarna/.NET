<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.CommandBtn.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Button Control,&nbsp; here button has onClickEvent(this is client side event)<br />
            <br />
            here, onClientClick has alert method<br />
            <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" OnClientClick="alert(&quot;Do you want to submit&quot;)" Text="Click" />
            <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            <br />
            <br />
            LinkButton control<br />
            here, onClienClick has confirm method ( make sure confirm method has return key in front&nbsp; of it, of it returns the value</div>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnClientClick="return confirm(&quot;Are you sure??&quot;)">GOTO</asp:LinkButton>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            ImageButton control</p>
        <p>
            here, onClientClick has confirm method</p>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/btn.png" OnClick="ImageButton1_Click" OnClientClick="return confirm(&quot;Are you sure??&quot;)" Width="129px" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
