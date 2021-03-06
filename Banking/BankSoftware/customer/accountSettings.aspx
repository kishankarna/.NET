﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accountSettings.aspx.cs" Inherits="BankSoftware.bank.accountSettings" %>

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
                <li><a href="Home.aspx">Home</a></li>
               
            </ul>
            <ul class="nav navbar-nav navbar-right">
               
                <li><a href="../logout.aspx"><span class="glyphicon glyphicon-log-in"></span>Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            
            <td>&nbsp;<asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/admin/admin.aspx">Check Users</asp:HyperLink>
                <asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <br />
            </td>
            <td class="auto-style6">

                <h2 class="auto-style7">Account Settings</h2>
                <br /><h2>Personal Details</h2>
                <table class="table">
                    <tr class="info">
                        <td>Name</td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr class="info">
                        <td>Address</td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAddress" ErrorMessage="Required New Address" ForeColor="Red" ValidationGroup="Update">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr class="info">
                        <td>Phone</td>
                        <td>
                            <asp:TextBox ID="txtPhone" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPhone" ErrorMessage="Required New Phone number" ForeColor="Red" ValidationGroup="Update">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr class="info">
                        <td>Email</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required New Email Address" ForeColor="Red" ValidationGroup="Update">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr class="info">
                        <td>Password :</td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr class="info">
                        <td>
                            <asp:Button ID="btnEdit" runat="server" Text="EDIT" OnClick="btnEdit_Click" class="btn btn-warning" />
                            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Enabled="False" OnClick="btnUpdate_Click" ValidationGroup="Update" class="btn btn-success" />
                            <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Enabled="False" OnClick="btnCancel_Click" class="btn btn-success" />
                        </td>
                        <td>
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Update" />
                        </td>
                    </tr>
                </table>
                <br />
                <br /><h2>Account Summary</h2>
                <table class="table">
                    <tr class="success">
                        <td>
                            Account Id :
                            <asp:Label ID="lblCustID" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnDisplayInfo" runat="server" OnClick="btnDisplayInfo_Click" Text="Display Information" Width="145px" class="btn btn-success" />
                        </td>
                    </tr>
                    <tr class="success">
                        <td>Checking Account :</td>
                        <td>
                            <asp:Label ID="lblChecking" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr class="success">
                        <td>Saving Account :</td>
                        <td>
                            <asp:Label ID="lblSaving" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr class="success">
                        <td>Credit Card :</td>
                        <td>
                            <asp:Label ID="lblCredit" runat="server"></asp:Label>
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
       
    </table>
    </form>
        </div>
    </body>
</html>
