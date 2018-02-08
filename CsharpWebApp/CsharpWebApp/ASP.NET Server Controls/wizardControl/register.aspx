<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.wizardControl.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 89%;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style5 {
            width: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Height="65px" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick" Width="520px">
                <HeaderStyle BackColor="#FFFF66" BorderColor="#FF9900" />
                <SideBarStyle VerticalAlign="Top" />
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Step 1- Personal Details">
                        <table class="auto-style1">
                            <tr>
                                <td>First Name</td>
                                <td>
                                    <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Last Name</td>
                                <td>
                                    <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>
                                    <asp:RadioButton ID="rdMale" runat="server" GroupName="gender" Text="Male" />
                                    <asp:RadioButton ID="rdFemale" runat="server" GroupName="gender" Text="Female" />
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Step 2 - Contact Details">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style5">Address</td>
                                <td>
                                    <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">E-mail</td>
                                <td>
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Phone</td>
                                <td>
                                    <asp:TextBox ID="txtPhn" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Step 3 - Summary">
                        <table class="auto-style3">
                            <tr>
                                <td><strong>Personal Info:</strong></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>First Name</td>
                                <td>
                                    <asp:Label ID="lblFname" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Last Name</td>
                                <td>
                                    <asp:Label ID="lblLname" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>
                                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td><strong>Contact Info:</strong></td>
                                <td>&nbsp;</td>
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
                        <br />
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
