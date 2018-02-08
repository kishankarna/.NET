<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CsharpWebApp.ASP.NET_Server_Controls.MultiView.indexz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <br />
                    <br />
                    <br />
                    <table border="1">
                        <tr>
                            <td>First Name</td>
                            <td>
                                <asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Last Name</td>
                            <td>
                                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Gender</td>
                            <td>
                                <asp:RadioButton ID="rdMale" runat="server" GroupName="gender" Text="Male" />
                                <asp:RadioButton ID="rdFemale" runat="server" GroupName="gender"  Text="Female" OnCheckedChanged="rdFemale_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btn1Next" runat="server" Text="Next" OnClick="btn1Next_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <table border="1">
                        <tr>
                            <td>Address</td>
                            <td>
                                <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Email :</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Phone :</td>
                            <td>
                                <asp:TextBox ID="txtPhn" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btn1Previous" runat="server" Text="Previous" OnClick="btn1Previous_Click" />
                            </td>
                            <td>
                                <asp:Button ID="btn2Next" runat="server" Text="Next" Width="41px" OnClick="btn2Next_Click" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <br />
                    <br />
                    <br />
                    <table border="1">
                        <tr>
                            <td colspan="2"><strong>Personal Info: </strong></td>
                        </tr>
                        <tr>
                            <td>First Name :</td>
                            <td class="auto-style1">
                                <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Last Name : </td>
                            <td class="auto-style1">
                                <asp:Label ID="lblLast" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Gender : </td>
                            <td class="auto-style1">
                                <asp:Label ID="lblGender" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2"><strong>Contact Details:</strong> </td>
                        </tr>
                        <tr>
                            <td>Address : </td>
                            <td class="auto-style1">
                                <asp:Label ID="lblAdd" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Email : </td>
                            <td class="auto-style1">
                                <asp:Label ID="lblEmai" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Phone : </td>
                            <td class="auto-style1">
                                <asp:Label ID="lblPhn" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btn2Previous" runat="server" OnClick="btn2Previous_Click" Text="Previous" />
                            </td>
                            <td class="auto-style1">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
