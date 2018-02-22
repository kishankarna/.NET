<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="transaction.aspx.cs" Inherits="BankSoftware.bank.transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 98px;
        }
        .auto-style8 {
            height: 32px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                <h2 class="auto-style1">United Local Bank</h2></td>
            <td>&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/bank/accountSettings.aspx">Profile &amp; Settings</asp:HyperLink>
                <asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/bank/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/bank/transaction.aspx">Transaction</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/bank/checking.aspx">Checking Account</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/bank/saving.aspx">Saving Account</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/logout.aspx">LogOut</asp:HyperLink>
            </td>
            <td class="auto-style6">
                <br />
                <br />
                <br />
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnDeposit" runat="server" Text="Deposit" OnClick="BtnDeposit_Click" />
                        </td>
                        <td rowspan="3">
                                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                        <br />
                            <asp:Panel ID="PanelDeposit" runat="server" CssClass="auto-style3" style="background-color:aquamarine">
                                <br />
                                <asp:Label ID="lblDepDate" runat="server"></asp:Label>
                                <br />
                                <table class="auto-style4" title="Deposit">
                                    <tr>
                                        <td>User ID :</td>
                                        <td>
                                            <asp:TextBox ID="DepositTxtCustID" runat="server" Enabled="False"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrDeposit" runat="server" Text="Are you Cashier?" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DepositTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Transaction Description :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLDepositDescrip" runat="server">
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
                                            <asp:DropDownList ID="DDLDepositTo" runat="server">
                                                <asp:ListItem Value="-1">Account Type</asp:ListItem>
                                                <asp:ListItem>Checking</asp:ListItem>
                                                <asp:ListItem>Saving</asp:ListItem>
                                                <asp:ListItem>Credit</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DDLDepositTo" ErrorMessage="Required Account" ForeColor="#FF3300" ValidationGroup="deposit" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountDeposit" runat="server" TextMode="Number"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAmountDeposit" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="deposit">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitDeposit" runat="server" Text="Submit" OnClick="btnSubmitDeposit_Click" ValidationGroup="deposit" />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelDeposit" runat="server" Text="Cancel" OnClick="btnCancelDeposit_Click" />
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
                            </asp:Panel>
                            <br />
                            <asp:Panel ID="PanelWithdraw" runat="server" style="background-color:aquamarine">
                                <asp:Label ID="lblDateW" runat="server"></asp:Label>
                                <br />
                                <table class="auto-style4">
                                    <tr>
                                        <td class="auto-style8">User ID : </td>
                                        <td class="auto-style8">
                                            <asp:TextBox ID="WithdrawTxtCustID" runat="server" Enabled="False"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrWithdraw" runat="server" Text="Are you Cashier?" />
                                        </td>
                                        <td class="auto-style8">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="WithdrawTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style8">Transacation Description :</td>
                                        <td class="auto-style8">
                                            <asp:DropDownList ID="DDLWithdrawDescrip" runat="server">
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
                                            <asp:DropDownList ID="DDLWithdrawFrom" runat="server">
                                                <asp:ListItem Value="-1">Account Type</asp:ListItem>
                                                <asp:ListItem>Checking</asp:ListItem>
                                                <asp:ListItem>Saving</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DDLWithdrawFrom" ErrorMessage="Required Account Type Selection" ForeColor="#FF3300" ValidationGroup="withdraw" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountWithdraw" runat="server" TextMode="Number"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAmountWithdraw" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="withdraw">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitWithdraw" runat="server" Text="Submit" ValidationGroup="withdraw" OnClick="btnSubmitWithdraw_Click" />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelWithdraw" runat="server" Text="Cancel" OnClick="btnCancelWithdraw_Click" />
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
                            </asp:Panel>
                            <br />
                            <asp:Panel ID="PanelTransfer" runat="server" style="background-color:aquamarine">
                                <asp:Label ID="lblDateT" runat="server"></asp:Label>
                                <br />
                                <table class="auto-style4">
                                    <tr>
                                        <td>User ID :</td>
                                        <td>
                                            <asp:TextBox ID="TransferTxtCustID" runat="server" Enabled="False"></asp:TextBox>
                                            <asp:CheckBox ID="CheckUsrTrans" runat="server" Enabled="False" Text="Are you Cashier?" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TransferTxtCustID" ErrorMessage="Required Account Selection" ForeColor="#FF3300" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>From :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLTransFrom" runat="server" Enabled="False">
                                                <asp:ListItem Value="-1">Select</asp:ListItem>
                                                <asp:ListItem>Teller</asp:ListItem>
                                                <asp:ListItem Value="Self">Online / ATM</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DDLTransFrom" ErrorMessage="Required Selection" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Transfer To :</td>
                                        <td>
                                            <asp:DropDownList ID="DDLTransTo" runat="server" Enabled="False">
                                                <asp:ListItem Value="-1">Account Type</asp:ListItem>
                                                <asp:ListItem>Checking</asp:ListItem>
                                                <asp:ListItem>Saving</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDLTransTo" ErrorMessage="Required Account Type" ForeColor="#FF3300" ValidationGroup="transfer" InitialValue="-1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txtAmountTransfer" runat="server" Enabled="False" TextMode="Number"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAmountTransfer" ErrorMessage="Required Amount" ForeColor="#FF3300" ValidationGroup="transfer">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSubmitTransfer" runat="server"  Text="Submit" ValidationGroup="transfer" OnClick="btnSubmitTransfer_Click" />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnCancelTransfer" runat="server" Text="Cancel" OnClick="btnCancelTransfer_Click" />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="tranMsg" runat="server" ForeColor="#CC0000" Text="Not maintained as of now"></asp:Label>
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
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnWithdraw" runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="BtnTransfer" runat="server" Text="Tranfer" OnClick="BtnTransfer_Click" />
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
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                  <address class="auto-style1">Contact: Karna Thapa<br/>
                         Address: Euless, TX <br/>
                         Email: kisanthapamagar@gmail.com
                </address><br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
