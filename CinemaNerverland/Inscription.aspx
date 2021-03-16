<%@ Page Title="Inscription" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="CinemaNerverland.Inscription" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Créer un compte</h3>
    <p>&nbsp;</p>
    <p>Entrez votre nom :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="InscriptionNom" runat="server" Width="238px"></asp:TextBox>
    </p>
    <p>Entrez votre prenom :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="InscriptionName" runat="server" Width="236px"></asp:TextBox>
    </p>
    <p>Entrez votre âge :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="InscriptionAge" runat="server" Width="236px"></asp:TextBox>
    </p>
    <p>Entrez votre e-mail :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="InscriptionMail" runat="server" Width="235px"></asp:TextBox>
    </p>
    <p>Entrez votre identifiant :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="InscriptionID" runat="server" Width="234px"></asp:TextBox>
    </p>
    <p>Entrez votre mot de passe :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="InscriptionMDP" runat="server" Width="237px"></asp:TextBox>
    </p>
    <p>Verification du mot de passe : <asp:TextBox ID="InscriptionMDPC" runat="server" Width="237px"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;<asp:Button ID="send" runat="server" Text="Valider" Width="241px" OnClick="send_Click" /></p>
    <p>Vous avez déja un compte ?
        <asp:LinkButton ID="Connexion" runat="server">Connectez-vous ici</asp:LinkButton>
    </p>
    <p>&nbsp;</p>
   
</asp:Content>
