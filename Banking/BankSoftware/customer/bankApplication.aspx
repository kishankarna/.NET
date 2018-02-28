<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bankApplication.aspx.cs" Inherits="BankSoftware.bank.bankApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="../scripts/jquery-3.3.1.js"></script>

    <style type="text/css">
        
        .customNav {
            background-color: dodgerblue;
        }

        .customUl {
            color: black;
        }

        .nav.navbar-nav.navbar-right li a {
            color: blue;
        }

        .nav.navbar-nav li a {
            color: blue;
        }
        .auto-style9 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 50%;
            text-align: right;
            padding-left: 15px;
            padding-right: 15px;
        }
        </style>
    <script>
        //
        function clearLabel()
        {

            $('#Msg2').html("");

        }
        //

    </script>
</head>
<body>
    <nav class="navbar navbar-inverse customNav">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">United Local Bank</a>
            </div>
            <ul class="nav navbar-nav">
                <li><a href="Home.aspx">Home</a></li>
                <li><a href="transaction.aspx">Transaction</a></li>
                <li><a href="checking.aspx">Checking</a></li>
                <li><a href="saving.aspx">Saving</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">

                <li><a href="../logout.aspx"><span class="glyphicon glyphicon-log-in"></span>Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <form id="form1" runat="server">
            <asp:Label ID="lblUsr" runat="server"></asp:Label>



            <h2 class="text-center">Account Details</h2>

            <br />
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th class="col-md-6">Accounts</th>
                        <th class="auto-style9">Balance</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <asp:Label ID="lblCheck0" runat="server" ForeColor="#0066FF">Checking Balance :</asp:Label>
                        </td>
                        <td class="text-right">
                            <asp:Label ID="lblCheck" runat="server" ForeColor="#0066FF"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSaving0" runat="server" ForeColor="#CC9900">Saving Balance :</asp:Label>
                        </td>
                        <td class="text-right">
                            <asp:Label ID="lblSaving" runat="server" ForeColor="#CC9900"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCredit0" runat="server" ForeColor="#006600">Credit Balance :</asp:Label>
                        </td>
                        <td class="text-right">
                            <asp:Label ID="lblCredit" runat="server" ForeColor="#006600"></asp:Label>
                        </td>
                    </tr>
                </tbody>
            </table>

            
            <div class="well">
                <h3> Statements</h3><asp:Label ID="Msg2" runat="server"></asp:Label>
                
                <table class="table">
                    <tr>
                        <td>
                            <asp:Label ID="LstMonth" runat="server" class="label label-info" Width="150px" Height="30px"></asp:Label>
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                        </td>
                        <td>
                          
                            <asp:DropDownList ID="DDLLstMnth" runat="server" class="form-control">
                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                            </asp:DropDownList>
                          
                        </td>
                        <td>
                            <asp:Button ID="btn1Month" runat="server" Text="View" Width="100px" class="btn btn-default" OnClick="btn1Month_Click" OnClientClick="clearLabel()"/>
                        </td>
                        <td>

                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Lst2Mnth" runat="server" class="label label-info" Width="150px" Height="30px" ></asp:Label>
                            <asp:HiddenField ID="HiddenField2" runat="server" />
                        </td>
                        <td>

                            <asp:DropDownList ID="DDL2LstMnth" runat="server" class="form-control">
                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                        <td>
                            <asp:Button ID="btn2Month" runat="server" Text="View" Width="100px" class="btn btn-default" OnClick="btn2Month_Click" OnClientClick="clearLabel()"  />
                        </td>
                        <td>

                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Lst3rdMnth" runat="server" class="label label-info" Width="150px" Height="30px"></asp:Label>
                            <asp:HiddenField ID="HiddenField3" runat="server" />
                        </td>
                        <td>

                            <asp:DropDownList ID="DDL3rdLstMnth" runat="server" class="form-control">
                                <asp:ListItem Value="-1">Select Account</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                        <td>
                            <asp:Button ID="btn3Month" runat="server" Text="View" Width="100px" class="btn btn-default" OnClick="btn3Month_Click" OnClientClick="clearLabel()"/>
                        </td>
                        <td>

                            &nbsp;</td>
                    </tr>
                </table>
               
            </div>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br /><br />
            <br /><br /><br />


            <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/adsXML/bankads.xml" Height="50px" Width="300px" Target="_blank" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/adsXML/googleads.xml" Height="50px" Width="200px" Target="_blank" />
            &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/adsXML/youtubeads.xml" Height="50px" Width="200px" Target="_blank" />


            <br />
            <br />
            <br />
           

        </form>
    </div>
</body>
</html>
