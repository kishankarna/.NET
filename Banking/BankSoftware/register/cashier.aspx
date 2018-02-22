<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cashier.aspx.cs" Inherits="BankSoftware.register.cashier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
             background-color:cornflowerblue;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            height: 21px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2 class="auto-style1">United Local Bank</h2>
        </div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Width="544px" OnFinishButtonClick="Wizard1_FinishButtonClick" CancelDestinationPageUrl="~/cashierLogin.aspx" DisplayCancelButton="True" OnNextButtonClick="Wizard1_NextButtonClick" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" >
            <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
            <SideBarStyle VerticalAlign="Top" BackColor="#507CD1" Font-Size="0.9em" />
            <StepNavigationTemplate>
                <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" />
                <asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </StepNavigationTemplate>
            <StepStyle Font-Size="0.8em" ForeColor="#333333" />
            <WizardSteps>
                <asp:WizardStep runat="server" title="Cashier Details">
                    <table class="auto-style2">
                        <tr>
                            <td>Name : </td>
                            <td>
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtName" ErrorMessage="Required Name" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Address :</td>
                            <td>
                                <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAdd" ErrorMessage="Required Address" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Phone : </td>
                            <td>
                                <asp:TextBox ID="txtPhn" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPhn" ErrorMessage="Required Phone number" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>E-mail :</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required Email Address" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Date :</td>
                            <td>
                                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="#FF3300" />
                                <br />
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Log in Credentials">
                    <table class="auto-style2">
                        <tr>
                            <td>User ID :</td>
                            <td>
                                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="Required ID" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Password : </td>
                            <td>
                                <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="Required Password" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Re-Password :</td>
                            <td>
                                <asp:TextBox ID="txtRePwd" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRePwd" ErrorMessage="Required Confirm Password" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtRePwd" ErrorMessage="Password  not matched" ForeColor="Red">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Summary">
                    <table class="auto-style2">
                        <tr>
                            <td>User ID :</td>
                            <td>
                                <asp:Label ID="lblUsr" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Password :</td>
                            <td>
                                <asp:Label ID="lblPwd" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Name :</td>
                            <td>
                                <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Address :</td>
                            <td>
                                <asp:Label ID="lblAdd" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Phone :</td>
                            <td class="auto-style4">
                                <asp:Label ID="lblPhn" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Email :</td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server"></asp:Label>
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
        <br />

        <asp:ImageButton ID="BtnLogin" runat="server" Height="61px" ImageUrl="~/images/login.png" OnClick="BtnLogin_Click" Visible="False" Width="97px" />

    </form>
</body>
</html>
