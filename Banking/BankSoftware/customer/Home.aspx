<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BankSoftware.bank.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" >
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
      <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="../scripts/jquery-3.3.1.js"></script>
    <style type="text/css">

        .auto-style2 {
            text-align: right;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 146px;
        }
        .auto-style6 {
            width: 814px;
        }
        .auto-style7 {
            text-align: center;
        }
        #showWeather {
        
            color:cornflowerblue;
        }
        </style>
    <script>
        //Get weather API from :https://openweathermap.org/current#parameter
        $(function () {

            getWeather();
        });
        
        function getWeather() {

            //var city = $('#city').val();
            var city = "Euless";
            if (city != '') {

                $.ajax({

                    url: 'http://api.openweathermap.org/data/2.5/weather?q=' + city + "&units=Imperial" +
                    "&APPID=c10bb3bd22f90d636baa008b1529ee25",

                    type: "GET",
                    dataType: "jsonp",
                    success: function (data) {
                        var widget = showResults(data);
                        $("#showWeather").html(widget);
                    }                    

                });
            }
            
        }
        //http://openweathermap.org/img/w/10d.png  link for weather icon
        function showResults(data) {
            return "<strong>Current Weather: " + data.name + ", " + data.sys.country + "</strong><br/>" +
                "Weather: " + data.weather[0].main + "<br/>" +
                "Description: <img src='http://openweathermap.org/img/w/" + data.weather[0].icon + ".png'>" +
                data.weather[0].description + "<br/>" +
                "Temperature: " + data.main.temp + " &deg;F<br/>" +
                "Pressure: " + data.main.pressure + "hpa" + "<br/>" +
                "Humidity: " + data.main.humidity + "%" + "<br/>" +
                "Min Temperature: " + data.main.temp_min + " &deg;F<br/>" +
                "Max Temperature: " + data.main.temp_max + " &deg;F<br/>" +
                "Wind Speed: " + data.wind.speed + "m/s<br/>" +
                "Wind Direction: " + data.wind.deg + "&deg;<br/>";


        }
</script>
    <style>
         .customNav {
        background-color:dodgerblue;
        }
        .customUl {
        color:black;
        }
        .nav.navbar-nav.navbar-right li a {
            color: blue;
        }
        .nav.navbar-nav li a {
            color: blue;
        }  
    </style>
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
                <li><a href="Credit.aspx">Credit</a></li>
                <li><a href="accountSettings.aspx"><span class="glyphicon glyphicon-cog"></span>Settings</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
               
                <li><a href="../logout.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
    <form id="form2" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/customer/bankApplication.aspx">Accounts Summary</asp:HyperLink><br />
                </td>
            <td class="auto-style6">
               <%-- <h2 class="auto-style1">United Local Bank</h2>--%>
                <h3 class="auto-style7">
                <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/customer/accountCreations.aspx">Create New Account</asp:HyperLink>
                </h3></td>
            
            <td>
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer/transaction.aspx">Transaction</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/customer/checking.aspx">Checking Account</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/customer/saving.aspx">Saving Account</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/customer/Credit.aspx">Credit Account</asp:HyperLink>
                <br />
                <br />
            </td>
            <td class="auto-style6">
                <br />
                <br />
               <div class="well">
                <p>A bank is a financial institution that accepts deposits from the public and creates credit. Lending activities
                   can be performed either directly or indirectly through capital markets. Due to their importance in the financial
                   stability of a country, banks are highly regulated in most countries. Most nations have institutionalized a system
                   known as fractional reserve banking under which banks hold liquid assets equal to only a portion of their current 
                   liabilities. In addition to other regulations intended to ensure liquidity, banks are generally subject to minimum 
                   capital requirements based on an international set of capital standards, known as the Basel Accords.</p>
                Your Available Accounts:<br />
                </div>
                <div class="well">
                   <ul>
                <li>
                    <asp:Label ID="lblChk" runat="server"></asp:Label>
                </li>
                <li>
                    <asp:Label ID="lblSav" runat="server"></asp:Label>
                </li>
                <li>
                    <asp:Label ID="lblCredit" runat="server"></asp:Label>
                </li>
                </ul>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
               </div>
               
                    <br />
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;
                <div class="well" id="showWeather">
                    
                </div>
                
                <p>&nbsp;</p></td>
        </tr>
         </table>
      
            <div class="alert alert-info">
           
                <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/adsXML/bankads.xml" Height="50px" Width="300px" Target="_blank" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/adsXML/googleads.xml" Height="50px" Width="200px" Target="_blank" />&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/adsXML/youtubeads.xml" Height="50px" Width="200px" Target="_blank" />
          
                </div>
           
      
          
              
           
   
    </form>
    </div>

</body>
</html>
