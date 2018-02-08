<%@ Page Title="" Language="C#" MasterPageFile="~/NavNmaster/master.Master" AutoEventWireup="true" CodeBehind="curriculumn.aspx.cs" Inherits="CsharpWebApp.NavNmaster.curriculumn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <p align="right"><asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /></p>
        <h2>Welcome to Student Portal
        </h2><br />

        <center style="color: rgb(64, 64, 64); font-family: &quot;Lucida Grande&quot;, verdana, geneva, arial, sans-serif; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;">
            <big style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal; font-size: 13px; line-height: normal; font-family: &quot;Lucida Grande&quot;, verdana, geneva, arial, sans-serif; color: rgb(33, 64, 86);"><b><span dir="ltr"><strong style="color: rgb(79, 0, 0); line-height: 20px; font-family: arial, helvetica, sans-serif; font-size: 14px;">Welcome to the New Horizon English School District Student Portal!<span>&nbsp;</span></strong><br />
            <br />
            </span></b></big>
</center>
<center style="color: rgb(64, 64, 64); font-family: &quot;Lucida Grande&quot;, verdana, geneva, arial, sans-serif; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;">
    <big style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal; font-size: 13px; line-height: normal; font-family: &quot;Lucida Grande&quot;, verdana, geneva, arial, sans-serif; color: rgb(33, 64, 86);"><b><span dir="ltr"><font face="arial, helvetica, sans-serif"><span style="font-size: 14px;">
    <br />
    </span></font></span><span style="font-size: 14px;"><span dir="ltr" style="font-family: arial, helvetica, sans-serif">This Student Self Serve program will provide you attendance, assignments, grades, discipline and credit summary information.<br />
    <br />
    To login, use your current user ID and password.<br />
    <br />
    Note to student: Visit your schools PEIMS clerk if you want to change your password.</span></span></b></big></center>

  
<p>
    &nbsp;</p>
    <p>
        <asp:Button ID="btnTeacher" runat="server" Text="Teacher Record" OnClick="btnTeacher_Click" />
        <asp:Button ID="btnStudent" runat="server" Text="Student Record" OnClick="btnStudent_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear All" OnClick="btnClear_Click" style="height: 26px" />
    </p>
    <p>
        <asp:GridView ID="GridView" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    
</asp:Content>
