<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="CinemaNerverland.Profil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
   <h3>Mes informations:</h3>
    <p>Login: <asp:Label ID="login" runat="server" ></asp:Label></p>


  

    <p><asp:Button ID="Abandon" runat="server" Text="Se déconnecter" Width="241px" OnClick="Session_OnEnd" ></asp:Button></p>
</asp:Content>

