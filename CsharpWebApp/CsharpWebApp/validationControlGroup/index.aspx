<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.validationControlGroup.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 202px;
        }
        .auto-style5 {
            width: 120px;
        }
        .auto-style6 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Validation Groups: 
            here I have 2 group name: one for login controls and another is for registration controls<br />
            <br />
            <h2>Login:</h2>
            <table border="1">
                <tr>
                    <td>User Name :</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtLusr" runat="server" Width="109px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtLusr" ErrorMessage="Required User Name" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtLPwd" runat="server" Width="112px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtLPwd" ErrorMessage="Required Password" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnLog" runat="server" Text="Login" OnClick="BtnLog_Click" ValidationGroup="Login" />
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="lblLog" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Login" />
                    </td>
                </tr>
            </table>
        </div>
        <h2>Registration Form:</h2>
        <table border="1" width="500" >
            <tr>
                <td class="auto-style5">User Name : </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtRusr" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtRusr" ErrorMessage="Required User Name" ForeColor="Red" ValidationGroup="Registration">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password : </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtRPwd" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtRPwd" ErrorMessage="Required Password" ForeColor="Red" ValidationGroup="Registration">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Confirm Password : </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtRCpss" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtRPwd" ControlToValidate="TxtRCpss" ErrorMessage="Password is not matched" ForeColor="Red" ValidationGroup="Registration">*</asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtRCpss" ErrorMessage="Required Confirm Password" ForeColor="Red" ValidationGroup="Registration">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">E-Mail : </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtREmail" runat="server" Width="118px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtREmail" ErrorMessage="Email address Invalid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" ValidationGroup="Registration">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtREmail" ErrorMessage="Required Email address" ForeColor="Red" ValidationGroup="Registration">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="BtnRegst" runat="server" Text="Register" OnClick="BtnRegst_Click" ValidationGroup="Registration" />
                &nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblR" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="Registration" />
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
