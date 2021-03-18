<%@ Page Title="Connexion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="CinemaNerverland.Connexion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Identification</h3>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <p>&nbsp;</p>
    <p>Entrez votre identifiant :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="connexionID" runat="server" Width="234px"></asp:TextBox>
    </p>
    <p>Entrez votre mot de passe :&nbsp;
        <asp:TextBox ID="ConnexionMDP" TextMode="Password" runat="server" Width="237px"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="send" runat="server" Text="Valider" Width="241px" OnClick="send_Click" />
        </p>
    <p>Vous n&#39;avez pas de un compte?
        <asp:LinkButton ID="Inscription" runat="server" href="Inscription.aspx">Inscrivez-vous ici</asp:LinkButton>
    </p>
    <p>&nbsp;</p>
   
</asp:Content>
 