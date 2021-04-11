<%@ Page Title="Inscription" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="CinemaNerverland.Inscription" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
     <div class='centerCase'>
         <br />
            <h3>Créer un compte</h3>
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>

            <p>&nbsp;</p>
            <p>Entrez votre nom :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="InscriptionNom" runat="server" Width="238px" required></asp:TextBox>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^[a-zA-Z]+$'
                                                ErrorMessage='Remplissez correctement ce champs'
                                                ControlToValidate='InscriptionNom'
                                                CssClass="text-danger"
                                                Display='Dynamic' />
            </p>
            <p>Entrez votre prenom :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="InscriptionName" runat="server" Width="236px" required></asp:TextBox>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^[a-zA-Z]+$'
                                                ErrorMessage='Remplissez correctement ce champs'
                                                ControlToValidate='InscriptionName'
                                                CssClass="text-danger"
                                                Display='Dynamic' />
            </p>
            <p>Entrez votre âge :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="InscriptionAge" type="number" runat="server" Width="236px" required ></asp:TextBox>
            </p>
            <p>Entrez votre e-mail :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="InscriptionMail" runat="server" Width="235px" required></asp:TextBox>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^[\w_.~-]+@[\w][\w.\-]*[\w]\.[\w][\w.]*[a-zA-Z]$'
                                                ErrorMessage='Remplissez correctement ce champs'
                                                ControlToValidate='InscriptionMail'
                                                CssClass="text-danger"
                                                Display='Dynamic' />
            </p>
            <p>Entrez votre identifiant :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="InscriptionID" runat="server" Width="234px" required></asp:TextBox>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^[0-9a-zA-Z]+$'
                                                ErrorMessage='Remplissez correctement ce champs'
                                                ControlToValidate='InscriptionID'
                                                CssClass="text-danger"
                                                Display='Dynamic' />
            </p>
            <p>Entrez votre mot de passe :&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="InscriptionMDP" TextMode="Password" runat="server" Width="237px" required></asp:TextBox>
            </p>
            <p>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$'
                                                ErrorMessage='Votre mot de passe doit contenir des lettres miniscules et majuscules des chiffre et des caractères spéciaux'
                                                ControlToValidate='InscriptionMDP'
                                                CssClass="text-danger"
                                                Display='Dynamic' />


            </p>
            <p>Verification du mot de passe : <asp:TextBox ID="InscriptionMDPC" TextMode="Password" runat="server" Width="237px" required></asp:TextBox>
            </p><p>
                <asp:RegularExpressionValidator runat='server'
                                                ValidationExpression='^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$'
                                                ErrorMessage='Votre mot de passe doit contenir des lettres miniscules et majuscules des chiffre et des caractères spéciaux'
                                                ControlToValidate='InscriptionMDPC'
                                                CssClass="text-danger"
                                                Display='Dynamic' />
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;<asp:Button ID="send" runat="server" Text="Valider" Width="241px" OnClick="send_Click" /></p>
            <p>Vous avez déja un compte ?
                <asp:LinkButton ID="Connexion" runat="server"  href="Connexion.aspx">Connectez-vous ici</asp:LinkButton>
            </p>
            <p>&nbsp;</p>
   </div>
</asp:Content>
