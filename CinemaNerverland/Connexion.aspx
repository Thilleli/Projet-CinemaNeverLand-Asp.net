<%@ Page Title="Connexion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="CinemaNerverland.Connexion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class='centerCase'>
        <br />
        <h3>Identificatifiez-vous</h3>

        <asp:Login ID="LoginControl" runat="server" onauthenticate="LoginControl_Authenticate" Height="163px">
            <LayoutTemplate>
                <div class="CaselogInscri">
                            <table>
                                <tr>
                                    <tdcolspan="2" style="height: 3px"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nom d&#39;utilisateur&nbsp;:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="height: 40px">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Width="126px">Mot de passe&nbsp;:</asp:Label>
                                    </td>
                                    <td style="height: 40px">
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Mémoriser le mot de passe." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Se connecter" ValidationGroup="LoginControl" />
                                    </td>
                                </tr>
                            </table>
                    </div>
            </LayoutTemplate>
            </asp:Login>


        </p>

        <p>Vous n&#39;avez pas de un compte?
            <asp:LinkButton ID="Inscription" runat="server" href="Inscription.aspx">Inscrivez-vous ici</asp:LinkButton>
        </p>
        <p>&nbsp;</p>
   </div>
</asp:Content>
