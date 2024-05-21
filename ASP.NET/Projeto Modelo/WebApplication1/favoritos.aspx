<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="favoritos.aspx.cs" Inherits="WebApplication1.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-sm-2"> </div>
    
    <div class="col-sm-8">

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" >
        <ItemTemplate>
            <div class="jumbotron" style="width: 900px; padding-left: 15px; padding-right: 50px; padding-top:30px">
                <table>
                    <tr>
                        <td style="width: 250px">
                            <img src="imagens/computadores/<%#Eval("ean")%>.jpg" class="img-thumbnail" style="height: 150px; width: 150px; text-align: left; padding-right:20px" />
                        </td>
                        <td style="width: 900px">
                            <h2><%#Eval("marca") %>&nbsp; <%#Eval("modelo") %></h2>
                            <%#Eval("descricao") %>
                            <br />
                            <a href="detalhes.aspx?EAN=<%#Eval("ean")%>">
                                <img src="imagens/botao_vermais.png" style="width:170px; height:60px;" align="right"  />
                            </a>
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:ListView>

    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT [t_computadores].* FROM [T_Computadores], [favoritos] where [t_computadores].[ean] = [favoritos].[ean] and favoritos.username=@username">
        <SelectParameters>
            <asp:SessionParameter Name="username" SessionField="user" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
