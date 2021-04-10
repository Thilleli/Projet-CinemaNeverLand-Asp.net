<%@ Page Title="Connexion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ticket.aspx.cs" Inherits="CinemaNerverland.membres.ticket" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
        <h2>Achetez votre place de cinéma</h2>
   
        <strong><p>Sélectionnez le film :</p></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListFilms" runat="server" AutoPostBack="true">
        </asp:DropDownList>
        <br />

        <strong><p>Nombres de places :</p></strong> 
            <asp:TextBox ID="nbrPlaces" type="number" runat="server" required ></asp:TextBox>
        <br />

    
    &nbsp;<asp:Button ID="Valider" runat="server"  OnClick="send_Click" Text="Valider" />
        <br />

        <asp:Label ID="filmSelected" runat="server" ></asp:Label>
        <br />
        <strong><p>Choisir une séance:</p></strong>
        <asp:CheckBoxList ID="CheckBoxListDisponibiliteFilm" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Reservation" runat="server"></asp:Label>
        <br />

    &nbsp;<asp:Button ID="ValiderReservation" runat="server"  OnClick="reservation" Text="Valider pour réserver les places" />
        <br />
        <asp:Label ID="MessageValidation" runat="server"></asp:Label>
        <br />
 
</asp:Content>