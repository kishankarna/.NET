﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checking.aspx.cs" Inherits="BankSoftware.bank.checking" %>

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

        .auto-style2 {
            text-align: right;
        }
        .auto-style4 {
            width: 100%;
            
        }
        .auto-style5 {
            width: 146px;
        }
        .auto-style6 {
            width: 814px;
        }
        .auto-style1 {
            text-align: center;
             background-color:cornflowerblue;
        }
        .auto-style7 {
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
            text-align: right;
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
                <li><a href="Home.aspx">Home</a></li>
                <li><a href="transaction.aspx">Transaction</a></li>
               <li><a href="saving.aspx">Saving Account</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
               
                <li><a href="../logout.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4" >
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
         
            <td>
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/customer/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/transaction.aspx">Transaction</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/customer/saving.aspx">Saving Account</asp:HyperLink>
                <br />
            </td>
            <td class="auto-style6">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                Checking
                Account Activities:<asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
                <table class="table">
                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label1" runat="server" ForeColor="#00CCFF" Text="Available Balance : $"></asp:Label>
&nbsp;<asp:Label ID="lblCheck" runat="server" ForeColor="#0099FF"></asp:Label>
                        </td>
                        <td class="auto-style7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" BorderStyle="None" Caption="Account Summary">
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </td>
                    </tr>
                    </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;<p>&nbsp;</p></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/adsXML/bankads.xml" Height="50px" Width="300px" Target="_blank" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/adsXML/googleads.xml" Height="50px" Width="200px" Target="_blank" />&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/adsXML/youtubeads.xml" Height="50px" Width="200px" Target="_blank" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            
        </tr>
    </table>
    </form>
        </div>
    </body>
</html>
