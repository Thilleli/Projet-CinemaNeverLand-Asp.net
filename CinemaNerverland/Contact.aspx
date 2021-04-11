<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CinemaNerverland.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <h3> <strong>Contactez <asp:Label ID="NomCin" runat="server"></asp:Label></strong> </h3><br />
            <div class="centerCase">
                <p>&nbsp;</p>
                <p><strong> Par téléphone au:</strong>  0<asp:Label ID="telCin" runat="server"></asp:Label></p><br />
                <p> <strong>Par courrier au:</strong> <asp:Label ID="addCin" runat="server"></asp:Label> <asp:Label ID="villecin" runat="server"></asp:Label> </p><br />
            </div>
            <div class="centerCase" style="height: 652px">
                <p>&nbsp;</p>
                <p><strong>Sinon, écrivez nous ici : </strong></p>
                    <table>
                        
                        <tr>
                            <td class="modal-sm" style="width: 134px">Nom:</td>
                            <td>
                                <br />
                                <asp:TextBox ID="TextBoxNom" runat="server" Height="30px" Width="250px" required></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="modal-sm" style="width: 134px">Prénom:</td>
                            <td>
                                <br />
                                <asp:TextBox ID="TextBoxPrenom" runat="server" Height="30px" Width="250px" required></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="modal-sm" style="width: 134px">Adresse mail:</td>
                            <td>
                                <br />
                                <asp:TextBox ID="TextBoxMail" runat="server" Height="30px" TextMode="Email" Width="250px" required ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="modal-sm" style="width: 134px">Objet:</td>
                            <td>
                                <br />
                                <asp:TextBox ID="TextBoxObjet" runat="server" Height="30px" Width="250px" required ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="modal-sm" style="height: 23px; width: 134px">Message:</td>
                            <td style="height: 23px">
                                <br />
                                <asp:TextBox ID="TextBoxMessage" runat="server" Height="209px" TextMode="MultiLine" Width="389px" required></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="modal-sm" style="width: 134px">
                                <br />
                                <br />
                                <br />
                                <br />
                            </td>
                            <td>
                                <br />
                                <asp:Button ID="ButtonSend" runat="server" Height="34px" OnClick="ButtonSend_Click" style="margin-left: 87" Text="Envoyer" Width="165px" />
                                <br />
                                <br />
               
                            </td>
                        </tr>
                        <p style="color: green; font-weight :bold;"> <asp:Literal runat="server" ID="LabelSendOk" />
                            <asp:Literal runat="server" ID="LabelSendnoOk" />
                        <br />
                       
                    </table>
               </div>
         <br />

</asp:Content>
