<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.FileUpload.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            File upload<br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
            <br />
            <br />
            <br />
            <asp:Label ID="lbl" runat="server"></asp:Label>
            
        </div>
        <p>
            &nbsp;</p>
        <p>
            File Upload with restrictions: if it is more than 5 mb than do try catch</p>
        <p>
            <asp:FileUpload ID="FileUpload2" runat="server" />
            <asp:Button ID="btn2Upload" runat="server" OnClick="btn2Upload_Click" Text="Upload" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
