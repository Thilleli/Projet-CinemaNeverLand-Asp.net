<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaNerverland._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h3>Les films disponible actuellement</h3> 
 
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">  
            <ItemTemplate>  
                <table  style="/*width: 300px; height: 100px; border: dashed 2px #04AFEF; background-color: #FFFFFF*/">  
                    <tr >  
                        <td colspan="2" rowspan="2"> 
                            <div class='card'>
                            <b></b><span class="img"><%# Eval("img") %></span></br></br></br>
                                <div style='margin-top: 30px;'>
                            <span class="title"><%# Eval("titre") %></span>
                            <span class="date"><%# Eval("date")%></span> 
                            <span class="categorie"><%# Eval("cat")%></span>
                            <span class="genre"><%# Eval("genre")%></span> 
                            <span class="time"><%# Eval("duree")%></span> 
                            <span class="prix"><%# Eval("prix")%></span>
                                    </div>
                                </div>
                        </td>  
                    </tr>  
                </table>  
            </ItemTemplate>  
        </asp:DataList>  



</asp:Content>