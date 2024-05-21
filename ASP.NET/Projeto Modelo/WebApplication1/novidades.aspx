<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="novidades.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-2"></div>
    <div class="col-sm-8">

        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged" DataKeyNames="EAN">
                        <ItemTemplate>
                <div class="jumbotron" style="width: 900px; padding-left: 20px; padding-right: 20px; padding-top: 30px">
                    <table>
                        <tr>
                            <td style="width: 250px">
                                <a href="detalhes.aspx?ean=<%#Eval("ean")%>">
                                    <img src="imagens/computadores/<%#Eval("ean")%>.jpg" class="img-thumbnail" style="width: 200px; height: 150px; padding-right: 20px" />
                                </a>
                            </td>
                            <td>
                                <h3><%#Eval("Marca")%> &nbsp; <%#Eval("Modelo")%> </h3>
                                <br />
                                <h1><%#Eval("Preco")%> €</h1>
                            </td>
                        </tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:ListView>
                
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="3">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:TecNavarroConnectionString %>' SelectCommand="SELECT EAN, Marca, Modelo, Preco FROM T_Computadores WHERE (MONTH(Data_Aquisicao) = MONTH(GETDATE())) AND (YEAR(Data_Aquisicao) = YEAR(GETDATE()))"></asp:SqlDataSource>
</asp:Content>
