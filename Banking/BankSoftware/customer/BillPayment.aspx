<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillPayment.aspx.cs" Inherits="BankSoftware.customer.BillPayment" %>

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
        .auto-style8 {
            width: 146px;
            height: 49px;
        }
        .auto-style10 {
            height: 49px;
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
                <li><a href="bankApplication">Summary</a></li>
                
            </ul>
            <ul class="nav navbar-nav navbar-right">
               
                <li><a href="../logout.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4" >
        <tr>
            <td class="auto-style8"></td>
           
            <td class="auto-style10">
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/customer/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/bankApplication.aspx">Accounts Summary</asp:HyperLink>
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
                &nbsp;<br />
                <table class="auto-style4" style="background-color:aquamarine">
                    <tr>
               <td>
                            <asp:Panel ID="PanelTransfer" runat="server" class="panel panel-info">
                                    <div class="panel-heading">Payments</div>
                                <div class="panel-body">
                                <table>
                                    <tr>
                                        <td>User ID :</td>
                                        <td>
                                            <asp:TextBox ID="TxtCustID" runat="server" Enabled="False" Width="130px"></asp:TextBox>
                                        </td>
                                        <td>
                                            Payment required: $0.00</td>
                                    </tr>
                                    <tr>
                                        <td>From :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLpaymentFrom" runat="server" Width="130px" CausesValidation="True">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DDLpaymentFrom" ErrorMessage="Required Selection" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Payment To :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLpaymentTo" runat="server" Width="130px" CausesValidation="True">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDLpaymentTo" ErrorMessage="Required Account" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmount" runat="server" TextMode="Number" Width="130px" CausesValidation="True"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAmount" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="transfer">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmit" runat="server"  Text="Submit" ValidationGroup="transfer" OnClick="btnSubmit_Click" class="btn btn-primary"/>
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" class="btn btn-primary"/>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:ValidationSummary ID="ValidationSummary3" runat="server" ForeColor="#FF3300" ValidationGroup="transfer" />
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                <br />
                                <br />
                                    </div>
                            </asp:Panel>
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
       
    </table>
    </form>
        </div>
</body>
</html>
