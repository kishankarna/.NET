<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form1.aspx.cs" Inherits="CsharpWebApp.StateManagement.ViewState.exmp1.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View State , ASP.NET controls by default holds its data</div>
        <p>
            &nbsp;</p>
        <p>
            This is&nbsp; ASP.NET Server Control, TextBox1</p>
        <p>
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            This is standard HTML Control, Text1</p>
        <p>
            Name:
            <input id="Text1" type="text" /></p>
        <asp:Button ID="Button1" runat="server" Text="ASP.NET Control" />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        This are Standard HTML Controls<br />
        <input id="Button2" type="button" value="button" /><input id="Submit1" type="submit" value="submit" /><input id="Reset1" type="reset" value="reset" /></form>
</body>
</html>
