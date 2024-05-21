<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Maquinas.aspx.cs" Inherits="GYMachines.maquinas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-3">
                <div class="panel panel-default" style="width: 200px">
                    <div class="panel-heading">
                        FILTROS
                    </div>
                    <div class="panel-body">
                        <hr />
                        <b>Marca</b>
                        <div style="overflow-y: scroll; width: 170px; height: 100px">
                            <hr />
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Marca" DataValueField="Marca">
                            </asp:CheckBoxList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [Marca] FROM [Maquinas] ORDER BY [Marca]"></asp:SqlDataSource>
                        </div>
                        <br />
                        <hr />
                        <b>Grupo Muscular</b>
                        <hr />
                        <br />
                        <div style="overflow-y: scroll; width: 170px; height: 100px">
                            <asp:CheckBoxList ID="CheckBoxList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="GrpMuscular" DataValueField="GrpMuscular">
                            </asp:CheckBoxList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [GrpMuscular] FROM [Maquinas] ORDER BY [GrpMuscular]"></asp:SqlDataSource>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-9">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" BorderStyle="None" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="325px" Width="691px">
                    <Columns>
                        <asp:CommandField SelectText="Ver Máquina" ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" Visible="False" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                        <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
                        <asp:BoundField DataField="GrpMuscular" HeaderText="Grupo Muscular" SortExpression="GrpMuscular" />
                        <asp:BoundField DataField="preco" HeaderText="Preço" SortExpression="preco" />
                    </Columns> 
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ID], [Nome], [Marca], [Modelo], [GrpMuscular], [preco] FROM [Maquinas]"></asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>

