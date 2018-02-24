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
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/logout.aspx">LogOut</asp:HyperLink>
            </td>
            <td class="auto-style6">
                <h2 class="auto-style1">Your Account Details</h2></td>
            <td>
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/customer/Home.aspx">Home</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/transaction.aspx">Transaction</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/customer/checking.aspx">Checking Account</asp:HyperLink>
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
                Accounts Portfolio:<asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
                <table class="auto-style4" style="background-color:aquamarine" border="2">
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="lblCheck0" runat="server" ForeColor="#0066FF">Checking Balance :</asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:Label ID="lblCheck" runat="server" ForeColor="#0066FF"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="lblSaving0" runat="server" ForeColor="#CC9900">Saving Balance :</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblSaving" runat="server" ForeColor="#CC9900"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCredit0" runat="server" ForeColor="#006600">Credit Balance :</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblCredit" runat="server" ForeColor="#006600"></asp:Label>
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
