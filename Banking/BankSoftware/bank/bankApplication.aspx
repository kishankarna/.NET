<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bankApplication.aspx.cs" Inherits="BankSoftware.bank.bankApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            background-color:cornflowerblue;
        }
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
        .auto-style7 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">

        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                <h2 class="auto-style1">Your Account Details</h2></td>
            <td>
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/bank/accountSettings.aspx">Profile &amp; Settings</asp:HyperLink>
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/bank/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/bank/transaction.aspx">Transaction</asp:HyperLink>
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
                <br />
                <br />
                <br />
                <br />
                <br />
                Accounts:<asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
                <table class="auto-style4" style="background-color:aquamarine">
                    <tr>
                        <td class="auto-style7">Checking :</td>
                        <td class="auto-style7">
                            <asp:Label ID="lblCheck" runat="server" ForeColor="#0066FF"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Saving : </td>
                        <td>
                            <asp:Label ID="lblSaving" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
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
