<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="CinemaNerverland.Profil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <h3>Mes informations:</h3>
    <p><asp:Label ID="nom" runat="server"></asp:Label></p>
    <p><asp:Label ID="prenom" runat="server"></asp:Label></p>
    <p><asp:Label ID="age" runat="server"></asp:Label></p>
    <p><asp:Label ID="mail" runat="server"></asp:Label></p>
    <p><asp:Label ID="login" runat="server"></asp:Label></p>


    <p><asp:Button ID="Abandon" runat="server" Text="Se déconnecter" Width="241px" OnClick="Session_OnEnd" ></asp:Button></p>
    <p><asp:Button ID="DeletUser" runat="server" Text="Se désinscrire" Width="241px" OnClick="Delet_user" ></asp:Button></p>
   
</asp:Content>


