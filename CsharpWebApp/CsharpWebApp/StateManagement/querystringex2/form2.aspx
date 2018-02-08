<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="CsharpWebApp.StateManagement.querystringex2.form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            Received data from form1:<br />
        </div>
        <p>
            <asp:Label ID="lbl" runat="server"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateManagement/querystringex2/form1.aspx">Go Back</asp:HyperLink>
        </p>
    </form>
    
</body>
</html>
