<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ad2.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.addRotator.ad2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is ads display with keywordFilter that keyword is defined in XML</div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLDATA/webads.xml" />
    </form>
</body>
</html>
