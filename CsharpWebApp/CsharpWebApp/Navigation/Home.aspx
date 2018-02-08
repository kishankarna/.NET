<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CsharpWebApp.Navigation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 402px;
            height: 405px;
        }
        .auto-style3 {
            height: 405px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Welcome to School Management System

        </h1></div>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="LogOut" />
    <br /><br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="347px" ImageUrl="~/Images/school.jpg" Width="394px" />
                </td>
                <td class="auto-style3">&nbsp;<p>In the U.S, public schools belong to school districts, which are governed by school boards. Each district is an independent special-purpose government, or dependent school systems, under the guidelines of each U.S. state government and local school boards. A school district is a legally separate body corporate and politic. School districts are local governments with powers similar to that of a town or a county including taxation and eminent domain, except in Virginia, whose school divisions have no taxing authority and must depend on another local government (county, city, or town) for funding. Its governing body, which is typically elected by direct popular vote but may be appointed by other governmental officials, is called a school board, board of trustees, board of education, school committee, or the like. This body appoints a superintendent, usually an experienced public school administrator, to function as the district's chief executive for carrying out day-to-day decisions and policy implementations. The school board may also exercise a quasi-judicial function in serious employee or student discipline matters.

<</p><p>School districts in the Midwest and West tend to cross municipal boundaries, while school districts in New England and the Mid-Atlantic regions tend to adhere to city, township, and/or county boundaries.[1] As of 1951 school districts were independent governmental units in 26 states, while in 17 states there were mixes of independent school districts and school districts subordinate to other local governments. In nine states there were only school districts subordinate to local governments.[2]</p></td>
            </tr>
        </table>
    </form>
    <br /><br /><br /><br /><br /><br /><br />

    <footer>Admin: Karna Thapa<br />
            Address: Euless, TX<br />
            E-mail: kisanthapamagar@gmail.com
    </footer>
</body>
</html>
