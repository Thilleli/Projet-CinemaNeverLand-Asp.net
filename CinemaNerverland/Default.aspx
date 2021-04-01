<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaNerverland._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <h1>Les films disponible actuellement</h1>

        <br />
        <div class="card" style="width: 500px;border:groove; border-block-color: aqua" >
            <div class="card-body">
                <asp:Label ID="films" runat="server"></asp:Label>
                
            </div>
        </div> 
        
</asp:Content>
