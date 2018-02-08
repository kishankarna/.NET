<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="control1.aspx.cs" Inherits="CsharpWebApp.ValidatiionControl.control1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" >

        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            }
            else
            {
                if (args.Value % 2 == 0) {
                    args.IsValid = true;

                }
                else
                {
                    args.IsValid = false;
                    //source.Empty();
                }
            }


        }
    </script>
    </head>
<body>
    <h1>This is validation control in c sharp</h1>
    <form id="form1" runat="server">
        <table border="2">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Must Enter Name" ForeColor="Red" ToolTip="Only String Value">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Enter Marks</td>
                <td>
                    <asp:TextBox ID="txtMark" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtMark" ErrorMessage="Only from (0-100)" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Email Address</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Not Valid E-mail ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Re-Enter Email Address</td>
                <td>
                    <asp:TextBox ID="txtEmailReent" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtEmailReent" ErrorMessage="E-mail Id not Matched" ForeColor="Red">Warning!!</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Submit" />
                </td>
                <td>
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
                </td>
            </tr>
        </table>
        <div>
        </div>
        <p>
            This is custom validator using client side technique: see in the html source/ we can also do using server side technique&nbsp;&nbsp; </p>
        <p>
            Enter Even Number :
            <asp:TextBox ID="txtEvenNumber" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="EvenValidator" runat="server" ControlToValidate="txtEvenNumber" ErrorMessage="Invalid Even Number" ClientValidationFunction="IsEven"></asp:CustomValidator>
        </p>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click" />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </form>
</body>
</html>
