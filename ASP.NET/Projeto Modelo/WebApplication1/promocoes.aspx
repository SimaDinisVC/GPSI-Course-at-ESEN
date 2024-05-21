<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="promocoes.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #container {
            display: flex;
            flex-wrap: wrap;
        }

        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-2"></div>

    <asp:DataList ID="DataList1" runat="server" DataKeyField="EAN" DataSourceID="lista_produtos" CellPadding="0" RepeatColumns="3">

        <ItemTemplate>

            <div class="w3-card-4" style="padding-top: 50px; padding-right: 100px">
                <a href="detalhes.aspx?ean=<%# Eval("EAN") %>">
                    <img src="imagens/computadores/<%# Eval("EAN") %>.jpg" style="width: 140px; height: 100px;"></a>
                <div class="w3-container w3-center" style="padding-left: 15px">
                    <asp:Label ID="DescontoLabel" runat="server" BackColor="#CC0000" Font-Size="XLarge" ForeColor="White" Text='<%# Eval("Desconto", "{0}%") %>' />
                    <br />
                    <asp:Label ID="MarcaLabel" runat="server" Text='<%# Eval("Marca") %>' />
                    &nbsp;<asp:Label ID="ModeloLabel" runat="server" Text='<%# Eval("Modelo") %>' />
                    <br />
                    <asp:Label ID="ProcessadorLabel" runat="server" Text='<%# Eval("Processador") %>' />
                    &nbsp;<asp:Label ID="Memoria_RAMLabel" runat="server" Text='<%# Eval("Memoria_RAM") %>' />
                    <br />
                    Monitor
                    <asp:Label ID="EcranLabel" runat="server" Text='<%# Eval("Ecran") %>' />
                    <br />
                    <asp:Label ID="PrecoLabel" runat="server" Font-Size="Large" Text='<%# Eval("Preco", "{0:C}") %>' />
                </div>
            </div>

        </ItemTemplate>

    </asp:DataList>

    <asp:SqlDataSource ID="lista_produtos" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [EAN], [Marca], [Modelo], [Processador], [Memoria_RAM], [Ecran], [Desconto], [Preco] FROM [T_Computadores] WHERE ([Desconto] IS NOT NULL)"></asp:SqlDataSource>

    <br />
    <br />

</asp:Content>
