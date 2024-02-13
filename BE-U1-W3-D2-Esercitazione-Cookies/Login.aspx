<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BE_U1_W3_D2_Esercitazione_Cookies._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
            <asp:TextBox ID="Username" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click"/>
    </main>

</asp:Content>
