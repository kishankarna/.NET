<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="errorPage.aspx.cs" Inherits="CsharpWebApp.Error_Handling_in_ASP.NET.error" %>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="errorPage.aspx.cs" Inherits="BankSoftware.errors.errorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" >
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
      <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="../scripts/jquery-3.3.1.js"></script>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <div class="container">
    <p>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td><h1 style="color:red">Application Error</h1>&nbsp;</td>
        </tr>
        <tr>
            <td>An unknown error has occured. We are aware of it and IT Team is working on this issue. Sorry for the inconvinience occured.</td>
        </tr>
    </table>
    <form id="form1" runat="server">
        <div>
            If you need further assistant, please contact our helpdesk at helpdesk@karnaCompany.com</div>
    </form>
        </div>
</body>
</html>
