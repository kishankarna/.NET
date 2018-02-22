<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebServiceConsumption.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    </head>
<body>
    <form id="form1" runat="server">
        <div>


        </div>
        <table border="1">
            <tr>
                <td>First Value</td>
                <td>
                    <asp:TextBox ID="txtFirstValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Second Value</td>
                <td>
                    <asp:TextBox ID="txtSecondValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Operation</td>
                <td>
                    <asp:DropDownList ID="DDLOperation" runat="server">
                        <asp:ListItem Value="-1">Select Operation</asp:ListItem>
                        <asp:ListItem Value="+">Add</asp:ListItem>
                        <asp:ListItem Value="-">Subtract</asp:ListItem>
                        <asp:ListItem Value="*">Multiply</asp:ListItem>
                        <asp:ListItem Value="/">Divide</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </form>
</body>
</html>
