<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaNerverland._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h3>Les films disponible actuellement</h3> 
 
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">  
            <ItemTemplate>  
                <div class='card'>
                <table>
                    <div class='hide'>
                        <tr >  
                            <td> 
                                <b></b><span class="image"><%# Eval("img") %></span><br />  
                            </td>  
                        </tr> 
                    </div>
                    <div class='container'>
                        <tr >  
                            <td> 
                                 <span class="title"><%# Eval("titre") %></span><br />  
                                 <span class="date"><%# Eval("date")%></span><br />  
                                 <span class="categorie"><%# Eval("cat")%></span><br />  
                                 <span class="genre"><%# Eval("genre")%></span><br /> 
                                 <span class="time"><%# Eval("duree")%></span><br />  
                                 <span class="prix"><%# Eval("prix")%></span><br />   
                            </td>  
                        </tr> 
                     </div>
                </table> 
                </div>
            </ItemTemplate>  
        </asp:DataList>  



</asp:Content>