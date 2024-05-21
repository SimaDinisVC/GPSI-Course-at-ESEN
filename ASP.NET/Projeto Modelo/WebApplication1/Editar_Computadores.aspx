<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Editar_Computadores.aspx.cs" Inherits="WebApplication1.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EAN" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnDataBound="GridView1_DataBound" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting">
    <Columns>
        <asp:BoundField DataField="EAN" HeaderText="EAN" ReadOnly="True" SortExpression="EAN" />
        <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
        <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
        <asp:BoundField DataField="Processador" HeaderText="Processador" SortExpression="Processador" />
        <asp:BoundField DataField="Memoria_RAM" HeaderText="Memoria_RAM" SortExpression="Memoria_RAM" />
        <asp:BoundField DataField="Ecran" HeaderText="Ecran" SortExpression="Ecran" />
        <asp:BoundField DataField="Disco" HeaderText="Disco" SortExpression="Disco" />
        <asp:BoundField DataField="Tipologia" HeaderText="Tipologia" SortExpression="Tipologia" />
        <asp:BoundField DataField="Desconto" HeaderText="Desconto" SortExpression="Desconto" />
        <asp:BoundField DataField="Data_Aquisicao" HeaderText="Data_Aquisicao" SortExpression="Data_Aquisicao" />
        <asp:CheckBoxField DataField="Tatil" HeaderText="Tatil" SortExpression="Tatil" />
        <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
        <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
        <asp:TemplateField ShowHeader="False">
            <EditItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/imagens/icon_editar.png" Text="Edit" />
                &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/imagens/icon_apagar.png" Text="Delete" OnClientClick="return confirm('tem a certeza que deseja eliminar este computador');" />
            </ItemTemplate>
            <ControlStyle Height="50px" Width="50px" />
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" DeleteCommand="DELETE FROM [T_Computadores] WHERE [EAN] = @original_EAN " InsertCommand="INSERT INTO [T_Computadores] ([EAN], [Marca], [Modelo], [Processador], [Memoria_RAM], [Ecran], [Disco], [Tipologia], [Desconto], [Data_Aquisicao], [Tatil], [Preco], [descricao]) VALUES (@EAN, @Marca, @Modelo, @Processador, @Memoria_RAM, @Ecran, @Disco, @Tipologia, @Desconto, @Data_Aquisicao, @Tatil, @Preco, @descricao)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [T_Computadores] ORDER BY [Data_Aquisicao] DESC" UpdateCommand="UPDATE [T_Computadores] SET [Marca] = @Marca, [Modelo] = @Modelo, [Processador] = @Processador, [Memoria_RAM] = @Memoria_RAM, [Ecran] = @Ecran, [Disco] = @Disco, [Tipologia] = @Tipologia, [Desconto] = @Desconto, [Data_Aquisicao] = @Data_Aquisicao, [Tatil] = @Tatil, [Preco] = @Preco, [descricao] = @descricao WHERE [EAN] = @original_EAN ">
    <DeleteParameters>
        <asp:Parameter Name="original_EAN" Type="String" />
        <asp:Parameter Name="original_Marca" Type="String" />
        <asp:Parameter Name="original_Modelo" Type="String" />
        <asp:Parameter Name="original_Processador" Type="String" />
        <asp:Parameter Name="original_Memoria_RAM" Type="String" />
        <asp:Parameter Name="original_Ecran" Type="String" />
        <asp:Parameter Name="original_Disco" Type="String" />
        <asp:Parameter Name="original_Tipologia" Type="String" />
        <asp:Parameter Name="original_Desconto" Type="Byte" />
        <asp:Parameter DbType="Date" Name="original_Data_Aquisicao" />
        <asp:Parameter Name="original_Tatil" Type="Boolean" />
        <asp:Parameter Name="original_Preco" Type="Double" />
        <asp:Parameter Name="original_descricao" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="EAN" Type="String" />
        <asp:Parameter Name="Marca" Type="String" />
        <asp:Parameter Name="Modelo" Type="String" />
        <asp:Parameter Name="Processador" Type="String" />
        <asp:Parameter Name="Memoria_RAM" Type="String" />
        <asp:Parameter Name="Ecran" Type="String" />
        <asp:Parameter Name="Disco" Type="String" />
        <asp:Parameter Name="Tipologia" Type="String" />
        <asp:Parameter Name="Desconto" Type="Byte" />
        <asp:Parameter DbType="Date" Name="Data_Aquisicao" />
        <asp:Parameter Name="Tatil" Type="Boolean" />
        <asp:Parameter Name="Preco" Type="Double" />
        <asp:Parameter Name="descricao" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Marca" Type="String" />
        <asp:Parameter Name="Modelo" Type="String" />
        <asp:Parameter Name="Processador" Type="String" />
        <asp:Parameter Name="Memoria_RAM" Type="String" />
        <asp:Parameter Name="Ecran" Type="String" />
        <asp:Parameter Name="Disco" Type="String" />
        <asp:Parameter Name="Tipologia" Type="String" />
        <asp:Parameter Name="Desconto" Type="Byte" />
        <asp:Parameter DbType="Date" Name="Data_Aquisicao" />
        <asp:Parameter Name="Tatil" Type="Boolean" />
        <asp:Parameter Name="Preco" Type="Double" />
        <asp:Parameter Name="descricao" Type="String" />
        <asp:Parameter Name="original_EAN" Type="String" />
        <asp:Parameter Name="original_Marca" Type="String" />
        <asp:Parameter Name="original_Modelo" Type="String" />
        <asp:Parameter Name="original_Processador" Type="String" />
        <asp:Parameter Name="original_Memoria_RAM" Type="String" />
        <asp:Parameter Name="original_Ecran" Type="String" />
        <asp:Parameter Name="original_Disco" Type="String" />
        <asp:Parameter Name="original_Tipologia" Type="String" />
        <asp:Parameter Name="original_Desconto" Type="Byte" />
        <asp:Parameter DbType="Date" Name="original_Data_Aquisicao" />
        <asp:Parameter Name="original_Tatil" Type="Boolean" />
        <asp:Parameter Name="original_Preco" Type="Double" />
        <asp:Parameter Name="original_descricao" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
