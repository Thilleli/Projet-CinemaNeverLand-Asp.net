<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaNerverland._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h3>Les films disponible actuellement</h3> 
 
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">  
            <ItemTemplate>  
                <table  style="width: 300px; height: 100px; border: dashed 2px #04AFEF; background-color: #FFFFFF">  
                    <tr >  
                        <td colspan="2" rowspan="2">  
                            <b></b><span class="img"><%# Eval("img") %></span><br />  
                            <span class="title"><%# Eval("titre") %></span><br />  
                            <span class="date"><%# Eval("date")%></span><br />  
                            <span class="categorie"><%# Eval("cat")%></span><br />  
                            <span class="genre"><%# Eval("genre")%></span><br /> 
                            <span class="time"><%# Eval("duree")%></span><br />  
                            <span class="prix"><%# Eval("prix")%></span><br />  
                        </td>  
                    </tr>  
                </table>  
            </ItemTemplate>  
        </asp:DataList>  



</asp:Content>