<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BankSoftware.admin.admin" %>

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
            text-align: center;
        }
          .customNav {
        background-color:dodgerblue;
        }
        .customUl {
        color:black;
        }
        .nav.navbar-nav.navbar-right li a {
            color: blue;
        }
        .nav.navbar-nav li a {
            color: blue;
        }  
    </style>
</head>
<body>
      <nav class="navbar navbar-inverse customNav">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">United Local Bank</a>
            </div>
            <ul class="nav navbar-nav">
                <li><a href="../customer/Home.aspx">Home</a></li>
                
            </ul>
           
        </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    <table border="1" style="width:400px" align="center">
        <tr>
            <td colspan="2" class="auto-style1"><h2>Admin Users</h2></td>
        </tr>
        <tr>
            <td>Active Application : </td>
            <td>
                <asp:Label ID="lblApp" runat="server" Width="100px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Active Users :</td>
            <td>
                <asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" class="btn btn-info"/>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/accountSettings.aspx">Go Back</asp:HyperLink>
            </td>
            <td>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
        </div>
    </body>
</html>
