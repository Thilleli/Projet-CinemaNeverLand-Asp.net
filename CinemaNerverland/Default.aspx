<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaNerverland._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <h1>Les films disponible actuellement</h1>

        <br />
        <div class="card" style="width: 450px;border:groove; border-block-color: aqua" >
            <div class="card-body">
                <asp:Label ID="images" runat="server"></asp:Label>
                <asp:Label ID="titres" runat="server"></asp:Label>
                <asp:Label ID="dates" runat="server"></asp:Label>
                <asp:Label ID="genres" runat="server"></asp:Label>
                <asp:Label ID="price" runat="server"></asp:Label>
                <asp:Label ID="Cat" runat="server"></asp:Label>
                <asp:Label ID="time" runat="server"></asp:Label>
            </div>
        </div>
        
</asp:Content>
