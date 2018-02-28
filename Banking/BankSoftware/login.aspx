<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BankSoftware.login" %>

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
        .auto-style2 {
            width: 287px;
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
            color: black;
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
                <li><a href="bank.html">Home</a></li>
                <li><a href="about.html">About</a></li>
                <li><a href="help.html">Help</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
               
                <li><a href="login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div>
   
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style1">&nbsp;</p>
           
    <p class="auto-style1">&nbsp;</p>
        <div>
            <table border="1" width="500" align="center" style="background-color:cornflowerblue">
                <tr>
                    <td colspan="2"><h2 class="auto-style1">User Login</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">User ID</td>
                    <td> 
                        <asp:TextBox ID="txtUsr" runat="server" TabIndex="1" class="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TabIndex="2" TextMode="Password" class="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="46px" ImageUrl="~/images/login.png" Width="74px" OnClick="ImageButton1_Click" TabIndex="3" />
                        <asp:HyperLink ID="hyperlnkCusRegister" runat="server" NavigateUrl="~/register/customer.aspx">Not Customer? Register</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        </div>
    </form>
        </div>
</body>
</html>
