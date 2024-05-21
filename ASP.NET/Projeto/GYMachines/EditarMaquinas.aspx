<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarMaquinas.aspx.cs" Inherits="GYMachines.EditarProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
            <asp:BoundField DataField="GrpMuscular" HeaderText="Grupo Muscular" SortExpression="GrpMuscular" />
            <asp:BoundField DataField="preco" HeaderText="Preco" SortExpression="preco" />
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" SortExpression="Descricao" />
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon_editar.png" Text="Edit" />
                    &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon_apagar.png" Text="Delete" OnClientClick="return confirm('tem a certeza que deseja eliminar este computador');" />
                </ItemTemplate>
                <ControlStyle Height="50px" Width="50px" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM Maquinas WHERE (ID = @ID)" SelectCommand="SELECT * FROM Maquinas" UpdateCommand="UPDATE Maquinas SET Nome = @Nome, Marca = @Marca, Modelo = @Modelo, GrpMuscular = @GrpMuscular, preco = @preco, Descricao = @Descricao WHERE ID = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="ID" />
            <asp:Parameter Name="Nome" />
            <asp:Parameter Name="Marca" />
            <asp:Parameter Name="Modelo" />
            <asp:Parameter Name="GrpMuscular" />
            <asp:Parameter Name="preco" />
            <asp:Parameter Name="Descricao" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
