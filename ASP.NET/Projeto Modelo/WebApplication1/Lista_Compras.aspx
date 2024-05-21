<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Lista_Compras.aspx.cs" Inherits="WebApplication1.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-3"></div>

    
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="Lista_encomendas" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Data" HeaderText="Data" SortExpression="Data" />
        <asp:BoundField DataField="total" HeaderText="total" SortExpression="total" />
        <asp:BoundField DataField="id_cliente" HeaderText="id_cliente" SortExpression="id_cliente" />
        <asp:CheckBoxField DataField="finalizada " HeaderText="finalizada " SortExpression="finalizada " />
        <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        <asp:CommandField SelectText="Processar" ShowSelectButton="True" />
    </Columns>
    <FooterStyle BackColor="White" ForeColor="#333333" />
    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F7F7F7" />
    <SortedAscendingHeaderStyle BackColor="#487575" />
    <SortedDescendingCellStyle BackColor="#E5E5E5" />
    <SortedDescendingHeaderStyle BackColor="#275353" />
</asp:GridView>
<asp:SqlDataSource ID="Lista_encomendas" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT * FROM [Compras] WHERE (([finalizada ] = @finalizada_) AND ([estado] = @estado))">
    <SelectParameters>
        <asp:Parameter DefaultValue="true" Name="finalizada_" Type="Boolean" />
        <asp:Parameter DefaultValue="Em processamento" Name="estado" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>

    
</asp:Content>
