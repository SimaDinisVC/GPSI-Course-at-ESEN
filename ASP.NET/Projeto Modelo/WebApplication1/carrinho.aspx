<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="carrinho.aspx.cs" Inherits="WebApplication1.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <script type="text/javascript">
        function successalert() {
            swal({
                title: 'Parabéns!',
                text: 'A sua encomenda foi submetida com sucesso',
                type: 'success'
            })
        }
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% //Response.Write(dados.Rows.Count); %>
    <div class="col-sm-4"></div>
    <div class="col-sm-4">
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="Id" DataSourceID="Produtos">
            <EditItemTemplate>
                Data:
            <asp:TextBox ID="DataTextBox" runat="server" Text='<%# Bind("Data") %>' />
                <br />
                total:
            <asp:TextBox ID="totalTextBox" runat="server" Text='<%# Bind("total") %>' />
                <br />
                Id:
            <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Data:
            <asp:TextBox ID="DataTextBox" runat="server" Text='<%# Bind("Data") %>' />
                <br />
                total:
            <asp:TextBox ID="totalTextBox" runat="server" Text='<%# Bind("total") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Data:
            <asp:Label ID="DataLabel" runat="server" Text='<%# Bind("Data") %>' />
                <br />
                total:
                <asp:Label ID="totalLabel" runat="server" Text='<%# Bind("total") %>' />
                <br />
                Id:
            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Estado:
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("estado") %>'></asp:Label>
                <br />
            </ItemTemplate>
        </asp:FormView>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" EmptyDataText="Não tem qualquer produto no seu carrinho. Continue comprando" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" />
                <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
                <asp:BoundField DataField="modelo" HeaderText="modelo" SortExpression="modelo" />
                <asp:BoundField DataField="quantidade" HeaderText="quantidade" SortExpression="quantidade" />
                <asp:BoundField DataField="preco" HeaderText="preco" SortExpression="preco" />
                <asp:ButtonField ButtonType="Button" CommandName="diminuir_quantidade" Text="-">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ButtonField>
                <asp:ButtonField runat="server" ButtonType="Button" Text="+" CommandName="aumentar_quantidade">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" CommandName="Apagar" Text="Button" ImageUrl="~/imagens/icon_apagar.png">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ButtonField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" DeleteCommand="delete * from compra_produtos where id=@id" SelectCommand="select produtos_compra.id, t_computadores.marca, t_computadores.modelo, produtos_compra.quantidade, t_computadores.preco from t_computadores, produtos_compra where T_computadores.ean = produtos_compra.ean and produtos_compra.id_compra=@id_compra">
            <DeleteParameters>
                <asp:Parameter Name="id" />
            </DeleteParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="FormView1" Name="id_compra" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="Produtos" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" OnSelecting="Produtos_Selecting" SelectCommand="SELECT [Id], [Data], [total], [estado] FROM [Compras] WHERE (([finalizada ] = @finalizada_) AND ([id_cliente] = @id_cliente))">
            <SelectParameters>
                <asp:Parameter DefaultValue="False" Name="finalizada_" Type="Boolean" />
                <asp:SessionParameter Name="id_cliente" SessionField="user" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="Dados_Compra" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="select produtos_compra.id, t_computadores.marca, t_computadores.modelo, produtos_compra.quantidade, t_computadores.preco from t_computadores, produtos_compra,  compras where T_computadores.ean = produtos_compra.ean and compras.id=produtos_compra.id_compra and produtos_compra.id_compra=@id_compra">
            <SelectParameters>
                <asp:ControlParameter ControlID="FormView1" Name="id_compra" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>

        <br />
        <br />

        <!-- Testar se está logado-->
        <% if (GridView1.Rows.Count > 0)
           { %>
                <button type="button" class="btn btn-success" runat="server" id="fechar_encomenda" onserverclick="fechar_encomenda_Click">Finalizar encomenda</button>
                <button type="button" class="btn btn-info" runat="server" id="continuar_comprar" onserverclick="continuar_comprar_Click">Continuar a comprar</button>
        <% } %>

    </div>
</asp:Content>
