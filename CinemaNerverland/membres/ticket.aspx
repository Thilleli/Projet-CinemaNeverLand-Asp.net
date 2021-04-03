<%@ Page Title="Connexion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ticket.aspx.cs" Inherits="CinemaNerverland.membres.ticket" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Acheter votre place de cinéma</h2>
   
    <strong>Sélectionner le film :
    </strong>
    <select multiple class="form-control" id="search-multiple" name="search-multiple">
    <option>Evangelion: 3.0+1.0</option>
</select>
    <br />
    <strong>Sélectionner le nombre de place :</strong>
    <asp:TextBox ID="InscriptionAge" type="number" runat="server" required ></asp:TextBox>
    <br />
    <br />
    <strong>Séctionner la date de la séance souhaiter :</strong><asp:Calendar ID="Calendar1" runat="server" required BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
        <DayStyle Width="14%" />
        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
        <TodayDayStyle BackColor="#CCCC99" />
    </asp:Calendar>
    &nbsp;<br />
&nbsp;<asp:Button ID="Valider" runat="server"  OnClick="send_Click" Text="Valider" />
    <br />
    <br />
    <br />
    </br>


       
</asp:Content>
