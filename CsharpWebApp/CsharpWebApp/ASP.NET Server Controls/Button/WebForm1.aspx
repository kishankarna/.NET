<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.Button.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Here is the Demo of click event and command event<br />
            <br />
            <br />
            This button method is defined on HTML</div>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" OnCommand="btnClick_Command" Text="Click" />
        <p>
            &nbsp;</p>
        <p>
            This button method is defined in page load dynamically using Delegates, instead of HTML</p>
        <p>
            <asp:Button ID="btnDynamic" runat="server" Text="Click"  />
        </p>
    </form>
</body>
</html>
