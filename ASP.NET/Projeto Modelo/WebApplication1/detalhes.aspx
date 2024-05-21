<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="detalhes.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-2"></div>
    <div class="col-sm-4">
        <asp:Image ID="Image1" runat="server" Height="315px" Width="365px" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT * FROM [T_Computadores] WHERE ([EAN] = @EAN)">
            <SelectParameters>
                <asp:QueryStringParameter Name="EAN" QueryStringField="ean" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <div class="col-sm-5">
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource1" BorderStyle="None" BorderWidth="0px" GridLines="None" AutoGenerateRows="False" DataKeyNames="EAN">
            <Fields>
                <asp:BoundField DataField="EAN" HeaderText="EAN" ReadOnly="True" SortExpression="EAN" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
                <asp:BoundField DataField="Processador" HeaderText="Processador" SortExpression="Processador" />
                <asp:BoundField DataField="Memoria_RAM" HeaderText="Memoria_RAM" SortExpression="Memoria_RAM" />
                <asp:BoundField DataField="Ecran" HeaderText="Ecran" SortExpression="Ecran" />
                <asp:BoundField DataField="Disco" HeaderText="Disco" SortExpression="Disco" />
                <asp:BoundField DataField="Tipologia" HeaderText="Tipologia" SortExpression="Tipologia" /> 
                <asp:BoundField DataField="Desconto" HeaderText="Desconto" SortExpression="Desconto" />
                <asp:CheckBoxField DataField="Tatil" HeaderText="Tatil" SortExpression="Tatil" />
                <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
            </Fields>
        </asp:DetailsView>
        <br />

        
         <!-- Verificar se o utilizador está logado -->
         <%if (Session["user"] != null) { %>       
            <Button type="button" ID="Bt_AddCarrinho" class="btn btn-success" data-toggle="modal" data-target="#myModal" style="Width:184px"> Comprar</Button>
       
            &nbsp;

            <!-- Botão para os favoritos -->
            <asp:ImageButton ID="Image2" runat="server" Width="50" Height="50" OnClick="Image2_Click" />    
         
         <%} %>

    </div>

    <!-- Modal -->
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Adicionar computador ao carrinho</h4>
                </div>
                <div class="modal-body">
                    <table>
                        <tr>
                            <td style="padding-right:15px">
                                <img src="imagens/computadores/<% Response.Write(DetailsView1.Rows[0].Cells[1].Text); %>.jpg" style="width: 80px; height: 80px;" />
                            </td>
                            <td>
                                <%  Response.Write(DetailsView1.Rows[1].Cells[1].Text); %>
                                &nbsp;
                                <%  Response.Write(DetailsView1.Rows[2].Cells[1].Text); %>
                                <br />
                                <%  Response.Write(DetailsView1.Rows[3].Cells[1].Text); %>
                                &nbsp;
                                <%  Response.Write(DetailsView1.Rows[4].Cells[1].Text); %>
                                &nbsp;
                                <%  Response.Write(DetailsView1.Rows[5].Cells[1].Text); %>
                            </td>
                        </tr>
                    </table>

                </div>
                <%if (Session["user"] != null){ %>
                <div class="modal-footer">
                    <button id="Bt_AddCarrinho_1" type="button" class="btn btn-success" OnServerClick="Bt_AddCarrinho_Click" data-dismiss="modal" data-target="#myModal" runat="server">Adicionar ao carrinho</button>
                    <button id="Bt_AddCarrinho_2" type="button" class="btn btn-info" data-dismiss="modal" runat="server" data-target="#myModal">Ver Carrinho</button>
                </div>
                <%} %>
            </div>

        </div>
    </div>

</asp:Content>

    