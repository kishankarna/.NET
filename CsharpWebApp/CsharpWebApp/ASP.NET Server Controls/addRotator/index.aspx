<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.addRotator.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This webpage has ads form XML File<br />
            <br />
        </div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLDATA/webads.xml" />
    </form>
</body>
</html>
