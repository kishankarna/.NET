<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CsharpWebApp.ADO.NET.CRUDusingStoredProc.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbl" runat="server"></asp:Label>
        <br />
        <table border="1">
            <tr>
                <td>Resident&#39;s ID</td>
                <td>
                    <asp:TextBox ID="txtResID" runat="server"></asp:TextBox>
                </td>
                <td rowspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td>Resident&#39;s Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Resident&#39;s Apartment No.</td>
                <td>
                    <asp:TextBox ID="txtAptNo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
                </td>
            </tr>
            <tr>
                <td>Resident&#39;s Phone</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td>Resident&#39;s E-Mail</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                &nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                </td>
                <td colspan="2">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <p>
            Records..</p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
