<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="BE_U1_W3_D2_Esercitazione_Cookies.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Benvenuto</h2>
        <asp:Label ID="UsernameLabel" runat="server"></asp:Label>
        <br />
       <asp:Button ID="Logout" runat="server" Text="Logout" Onclick="Logout_Click"/>
    </main>
    
</asp:Content>
