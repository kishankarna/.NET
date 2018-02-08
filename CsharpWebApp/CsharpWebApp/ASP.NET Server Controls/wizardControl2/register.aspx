<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.wizardControl2.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 90px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" CancelDestinationPageUrl="~/ASP.NET Server Controls/wizardControl2/login.aspx" DisplayCancelButton="True" Font-Bold="False" Height="103px" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick" Width="441px">
                <FinishNavigationTemplate>
                    <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                    <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" onClientClick="return confirm('Do you want to Submit this Form!!')"/>
                    <asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </FinishNavigationTemplate>
                <SideBarStyle VerticalAlign="Top" />
                <StartNavigationTemplate>
                    <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" onClientClick="return confirm('Are you sure want to go to next step??')"/>
                    <asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </StartNavigationTemplate>
                <StepNavigationTemplate>
                    <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                    <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" onClientClick="return confirm('Are you sure??')"/>
                    <asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </StepNavigationTemplate>
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Step 1">
                        <table class="auto-style1">
                            <tr>
                                <td>First Name</td>
                                <td>
                                    <asp:TextBox ID="TxtFname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Last Name</td>
                                <td>
                                    <asp:TextBox ID="TxtLname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>
                                    <asp:RadioButton ID="rdMale" runat="server" Text="Male" />
                                    <asp:RadioButton ID="rdFemale" runat="server" Text="Female" />
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Step 2">
                        <table class="auto-style2">
                            <tr>
                                <td class="auto-style3">Address</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TxtAdd" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Email</td>
                                <td>
                                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Phone</td>
                                <td>
                                    <asp:TextBox ID="TxtPhn" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Step 3">
                        <table class="auto-style2">
                            <tr>
                                <td>First Name</td>
                                <td>
                                    <asp:Label ID="lblFName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Last Name</td>
                                <td>
                                    <asp:Label ID="LblLname" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>
                                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Address</td>
                                <td>
                                    <asp:Label ID="lblAdd" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Email</td>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Phone</td>
                                <td>
                                    <asp:Label ID="lblPhn" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
