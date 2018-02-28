<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="transaction.aspx.cs" Inherits="BankSoftware.bank.transaction" %>

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
            width: 98px;
        }
        .auto-style8 {
            height: 32px;
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
                <li><a href="BillPayment.aspx">Bill Payment</a></li>
                
            </ul>
            <ul class="nav navbar-nav navbar-right">
              
                <li><a href="../logout.aspx">&nbsp;
            &nbsp;<span class="glyphicon glyphicon-log-in"></span>Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <asp:Label ID="lblUsr" runat="server" ForeColor="Black"></asp:Label>
    <form id="form2" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/customer/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/customer/BillPayment.aspx">Pay Bill</asp:HyperLink>
                <br />
            </td>
            <td class="auto-style6">
                <br />
                <br />
                <br />
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnDeposit" runat="server" Text="Deposit" OnClick="BtnDeposit_Click" Width="120px" class="btn btn-primary" />
                        </td>
                        <td rowspan="3">
                                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                        <br />
                            <asp:Panel ID="PanelDeposit" runat="server" class="panel panel-info">
                                 <div class="panel-heading">Deposit</div>
                                <div class="panel-body">
                                
                                <asp:Label ID="lblDepDate" runat="server"></asp:Label>
                                <br />
                                <table class="auto-style4" title="Deposit">
                                    <tr>
                                        <td>User ID :</td>
                                        <td>
                                            <asp:TextBox ID="DepositTxtCustID" runat="server" Enabled="False" Width="130px"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrDeposit" runat="server" Text="Are you Cashier?" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DepositTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Transaction Description :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLDepositDescrip" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                                <asp:ListItem>Teller</asp:ListItem>
                                                <asp:ListItem Value="Self">Online / ATM</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DDLDepositDescrip" ErrorMessage="Required Selection" ForeColor="#FF3300" ValidationGroup="deposit" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Deposit To :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLDepositTo" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DDLDepositTo" ErrorMessage="Required Account" ForeColor="#FF3300" ValidationGroup="deposit" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountDeposit" runat="server" TextMode="Number" Width="130px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAmountDeposit" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="deposit">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitDeposit" runat="server" Text="Submit" OnClick="btnSubmitDeposit_Click" ValidationGroup="deposit" class="btn btn-info" />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelDeposit" runat="server" Text="Cancel" OnClick="btnCancelDeposit_Click" class="btn btn-info" />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                        <td>
                                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" ValidationGroup="deposit" />
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                    </div>
                            </asp:Panel>
                            <br />
                            <asp:Panel ID="PanelWithdraw" runat="server" class="panel panel-info">
                                <asp:Label ID="lblDateW" runat="server"></asp:Label>
                                  <div class="panel-heading">Withdraw</div>
                                <div class="panel-body">
                                <table class="auto-style4">
                                    <tr>
                                        <td class="auto-style8">User ID : </td>
                                        <td class="auto-style8">
                                            <asp:TextBox ID="WithdrawTxtCustID" runat="server" Enabled="False" Width="130px"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrWithdraw" runat="server" Text="Are you Cashier?" />
                                        </td>
                                        <td class="auto-style8">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="WithdrawTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style8">Transacation Description :</td>
                                        <td class="auto-style8">
                                            <asp:DropDownList ID="DDLWithdrawDescrip" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                                <asp:ListItem>Teller</asp:ListItem>
                                                <asp:ListItem Value="Self">Online / ATM</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style8">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DDLWithdrawDescrip" ErrorMessage="Required Selection" ForeColor="#FF3300" ValidationGroup="withdraw" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Withdraw From :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLWithdrawFrom" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDLWithdrawFrom" ErrorMessage="Required Account Type Selection" ForeColor="#FF3300" ValidationGroup="withdraw" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountWithdraw" runat="server" TextMode="Number" Width="130px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAmountWithdraw" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="withdraw">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitWithdraw" runat="server" Text="Submit" ValidationGroup="withdraw" OnClick="btnSubmitWithdraw_Click" class="btn btn-info"/>
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelWithdraw" runat="server" Text="Cancel" OnClick="btnCancelWithdraw_Click"  class="btn btn-info"/>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                        <td>
                                            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="#FF3300" ValidationGroup="withdraw" />
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                <br />
                                    </div>
                            </asp:Panel>
                            <br />
                            <asp:Panel ID="PanelTransfer" runat="server"  class="panel panel-info">
                                <asp:Label ID="lblDateT" runat="server"></asp:Label>
                                 <div class="panel-heading">Transfer</div>
                                <div class="panel-body">
                                <table class="auto-style4">
                                    <tr>
                                        <td>User ID :</td>
                                        <td>
                                            <asp:TextBox ID="TransferTxtCustID" runat="server" Enabled="False" Width="130px"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrTrans" runat="server" Enabled="False" Text="Are you Cashier?" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TransferTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>From :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLTransFrom" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DDLTransFrom" ErrorMessage="Required Selection" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Transfer To :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLTransTo" runat="server" Width="130px">
                                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDLTransTo" ErrorMessage="Required Account Type" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountTransfer" runat="server" TextMode="Number" Width="130px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAmountTransfer" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="transfer">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitTransfer" runat="server"  Text="Submit" ValidationGroup="transfer" OnClick="btnSubmitTransfer_Click" class="btn btn-info" />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelTransfer" runat="server" Text="Cancel" OnClick="btnCancelTransfer_Click" class="btn btn-info" />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            &nbsp;</td>
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
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnWithdraw" runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" Width="120px" class="btn btn-primary"/>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnTransfer" runat="server" Text="Tranfer" OnClick="BtnTransfer_Click" Width="120px" class="btn btn-primary"/>
                        </td>
                    </tr>
                </table>
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
