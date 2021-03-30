<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CinemaNerverland.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Nous contacter:</h2>

    <table class="nav-justified">
        <p style="color: green; font-weight :bold;"> <asp:Literal runat="server" ID="LabelSendOk" />
            <p class="text-danger"style="font-weight :bold;"><asp:Literal runat="server" ID="LabelSendnoOk" /></p>
        <tr>
            <td class="modal-sm" style="width: 134px">Civilité: </td>
            <td>
                <asp:DropDownList ID="DropDownListCivilié" runat="server">
                    <asp:ListItem>Veuillez faire un choix</asp:ListItem>
                    <asp:ListItem>Mme</asp:ListItem>
                    <asp:ListItem>Mlle</asp:ListItem>
                    <asp:ListItem>Mr</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 134px">Nom:</td>
            <td>
                <br />
                <asp:TextBox ID="TextBoxNom" runat="server" Height="30px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 134px">Prénom:</td>
            <td>
                <br />
                <asp:TextBox ID="TextBoxPrenom" runat="server" Height="30px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 134px">Adresse mail:</td>
            <td>
                <br />
                <asp:TextBox ID="TextBoxMail" runat="server" Height="30px" TextMode="Email" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 134px">Objet:</td>
            <td>
                <br />
                <asp:TextBox ID="TextBoxObjet" runat="server" Height="30px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 23px; width: 134px">Message:</td>
            <td style="height: 23px">
                <br />
                <asp:TextBox ID="TextBoxMessage" runat="server" Height="209px" TextMode="MultiLine" Width="389px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 134px">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="ButtonSend" runat="server" Height="34px" OnClick="ButtonSend_Click" style="margin-left: 87" Text="Envoyer" Width="165px" />
                <br />
               
            </td>
        </tr>
    </table>
</asp:Content>
