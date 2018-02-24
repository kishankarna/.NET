<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BankSoftware.bank.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style1 {
            text-align: center;
            background-color:cornflowerblue;
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

</head>
<body>
    <form id="form2" runat="server">
        <div class="auto-style2">
        <div>
           
        </div>
        </div>
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/logout.aspx">LogOut</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/customer/bankApplication.aspx">Accounts Summary</asp:HyperLink><br />
                </td>
            <td class="auto-style6">
                <h2 class="auto-style1">United Local Bank</h2><h3 class="auto-style7">
                <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/customer/accountCreations.aspx">Create New Account</asp:HyperLink>
                </h3></td>
            
            <td>
                &nbsp;<asp:Label ID="lblUsr" runat="server"></asp:Label>
                <br />
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/customer/accountSettings.aspx">Profile &amp; Settings</asp:HyperLink>
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
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                Your Available Accounts:<br />
                <asp:Label ID="lblChk" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblSav" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblCredit" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;
                <div id="showWeather">
                    
                </div>
                
                <p>&nbsp;</p></td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/adsXML/bankads.xml" Height="50px" Width="300px" Target="_blank" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/adsXML/googleads.xml" Height="50px" Width="200px" Target="_blank" />&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/adsXML/youtubeads.xml" Height="50px" Width="200px" Target="_blank" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                <address class="auto-style1">Contact: Karna Thapa<br/>
                         Address: Euless, TX <br/>
                         Email: kisanthapamagar@gmail.com
                </address><br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    
</body>
</html>
