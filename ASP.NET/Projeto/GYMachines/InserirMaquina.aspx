<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirMaquina.aspx.cs" Inherits="GYMachines.InserirMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <asp:FormView ID="FormView1" runat="server" DefaultMode="Insert" DataSourceID="SqlDataSource1">
                    <InsertItemTemplate>
                        <div class="form-group">
                            <asp:Label ID="lblNome" runat="server" AssociatedControlID="txtNome" Text="Nome"></asp:Label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Text='<%# Bind("Nome") %>' />
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblMarca" runat="server" AssociatedControlID="txtMarca" Text="Marca"></asp:Label>
                            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Text='<%# Bind("Marca") %>' />
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblModelo" runat="server" AssociatedControlID="txtModelo" Text="Modelo"></asp:Label>
                            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Text='<%# Bind("Modelo") %>' />
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblGrpMuscular" runat="server" AssociatedControlID="ddlGrpMuscular" Text="Grupo Muscular"></asp:Label>
                            <asp:DropDownList ID="ddlGrpMuscular" runat="server" CssClass="form-control" SelectedValue='<%# Bind("GrpMuscular") %>'>
                                <asp:ListItem Text="Braços" Value="braços"></asp:ListItem>
                                <asp:ListItem Text="Peito" Value="peito"></asp:ListItem>
                                <asp:ListItem Text="Costas" Value="costas"></asp:ListItem>
                                <asp:ListItem Text="Pernas" Value="pernas"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPreco" runat="server" AssociatedControlID="txtPreco" Text="Preço"></asp:Label>
                            <asp:TextBox ID="txtPreco" runat="server" CssClass="form-control" Text='<%# Bind("preco") %>' />
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDescricao" runat="server" AssociatedControlID="txtDescricao" Text="Descrição"></asp:Label>
                            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" Text='<%# Bind("Descricao") %>' />
                        </div>
                        <asp:Button ID="btnInsert" runat="server" Text="Inserir" CssClass="btn btn-primary" CommandName="Insert" />
                    </InsertItemTemplate>
                </asp:FormView>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" InsertCommand="INSERT INTO Maquinas(Nome, Marca, Modelo, GrpMuscular, preco, Descricao) VALUES (@Nome, @Marca, @Modelo, @GrpMuscular, @preco, @Descricao)">
        <InsertParameters>
            <asp:Parameter Name="Nome" />
            <asp:Parameter Name="Marca" />
            <asp:Parameter Name="Modelo" />
            <asp:Parameter Name="GrpMuscular" />
            <asp:Parameter Name="preco" />
            <asp:Parameter Name="Descricao" />
        </InsertParameters>
    </asp:SqlDataSource>

</asp:Content>
