<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accountCreations.aspx.cs" Inherits="BankSoftware.bank.accountCreations" %>

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
        .auto-style7 {
            height: 26px;
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
            <td>&nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style6">
                <br />
                <asp:Wizard ID="Wizard1" runat="server" OnFinishButtonClick="Wizard1_FinishButtonClick" ActiveStepIndex="0" CancelDestinationPageUrl="~/bank/bankApplication.aspx" DisplayCancelButton="True" Height="151px" OnCancelButtonClick="Wizard1_CancelButtonClick" Width="532px" OnNextButtonClick="Wizard1_NextButtonClick" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
                    <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                    <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
                    <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
                    <StepNavigationTemplate>
                        <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                        <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" />
                    </StepNavigationTemplate>
                    <StepStyle Font-Size="0.8em" ForeColor="#333333" />
                    <WizardSteps>
                        <asp:WizardStep runat="server" title="Account Information">
                            <table class="auto-style4">
                                <tr>
                                    <td>A/C No: </td>
                                    <td>
                                        <asp:TextBox ID="txtAccn" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAccn" ErrorMessage="Required Account Number" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Opening Balance : </td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBalance" ErrorMessage="Required Opening Balance" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Preparer :</td>
                                    <td>
                                        <asp:DropDownList ID="DDLPreparer" runat="server">
                                            <asp:ListItem Value="-1">Select</asp:ListItem>
                                            <asp:ListItem>Bank Staff</asp:ListItem>
                                            <asp:ListItem>Self/Online</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DDLPreparer" ErrorMessage="Required Preparer" ForeColor="Red" InitialValue="-1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Account Type :</td>
                                    <td>
                                        <asp:DropDownList ID="DDLAccnType" runat="server">
                                            <asp:ListItem Value="-1">Select</asp:ListItem>
                                            <asp:ListItem>Checking</asp:ListItem>
                                            <asp:ListItem>Saving</asp:ListItem>
                                            <asp:ListItem>Credit</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DDLAccnType" ErrorMessage="Required Account Type" ForeColor="Red" InitialValue="-1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                                    </td>
                                </tr>
                            </table>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" title="Summary">
                            <table class="auto-style4">
                                <tr>
                                    <td>Name :</td>
                                    <td>
                                        <asp:Label ID="lblName" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Account No :</td>
                                    <td>
                                        <asp:Label ID="lblAccount" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Amount : </td>
                                    <td>
                                        <asp:Label ID="lblAmount" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Preparer : </td>
                                    <td>
                                        <asp:Label ID="lblPreparer" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Account Type :</td>
                                    <td>
                                        <asp:Label ID="lblAccType" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Date :</td>
                                    <td>
                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/bank/Home.aspx">Home</asp:HyperLink>
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
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                <address class="auto-style1">Contact: Karna Thapa
    </table>
    </form>
    
</body>
</html>
