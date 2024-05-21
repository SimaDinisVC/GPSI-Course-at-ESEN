<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="computadores.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Testa se houve escolha do tipo de computador -->
    <% if (Request.QueryString["tipo"] != null){ %>

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
                        <asp:CheckBoxList ID="CHK_ListaMarcas" runat="server" AutoPostBack="True" DataSourceID="Lista_Marca" DataTextField="Marca" DataValueField="Marca" OnSelectedIndexChanged="CHK_SelectedIndexChanged">
                        </asp:CheckBoxList>
                        <asp:SqlDataSource ID="Lista_Marca" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Marca] FROM [T_Computadores] WHERE ([Tipologia] = @Tipologia) ORDER BY [Marca]">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Tipologia" QueryStringField="tipo" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>

                    <br />
                    <hr />
                    <b>Processador</b>
                    <hr />

                    <br />
                    <div style="overflow-y: scroll; width: 170px; height: 100px">
                        <asp:CheckBoxList ID="Chk_Processador" runat="server" AutoPostBack="True" DataSourceID="TecNavarro" DataTextField="Processador" DataValueField="Processador" OnSelectedIndexChanged="CHK_SelectedIndexChanged">
                        </asp:CheckBoxList>
                            <asp:SqlDataSource ID="TecNavarro" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Processador] FROM [T_Computadores] WHERE ([Tipologia] = @Tipologia) ORDER BY [Processador]  ">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="Tipologia" QueryStringField="tipo" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                    </div>

                    <br />
                    <hr />

                    <b>Memória</b>
                    <hr />
                    <div style="overflow-y: scroll; width: 170px; height: 100px">
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" DataSourceID="Lista_Memoria" DataTextField="Memoria_RAM" DataValueField="Memoria_RAM" OnSelectedIndexChanged="CHK_SelectedIndexChanged" DataTextFormatString="&nbsp; {0:s}" Height="100px">
                        </asp:CheckBoxList>
                        <asp:SqlDataSource ID="Lista_Memoria" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Memoria_RAM] FROM [T_Computadores] WHERE ([Tipologia] = @Tipologia) ORDER BY [Memoria_RAM]">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Tipologia" QueryStringField="tipo" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>

                    <br />
                    <hr />

                    <b>Monitor</b>
                    <hr />
                    <div style="overflow-y: scroll; width: 170px; height: 100px">
                        <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" DataSourceID="Lista_Monitores" DataTextField="Ecran" DataValueField="Ecran" OnSelectedIndexChanged="CHK_SelectedIndexChanged" DataTextFormatString="&nbsp; {0:s}" Height="100px">
                        </asp:CheckBoxList>
                        <asp:SqlDataSource ID="Lista_Monitores" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Ecran] FROM [T_Computadores] WHERE ([Tipologia] = @Tipologia) ORDER BY [Ecran]">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Tipologia" QueryStringField="tipo" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>
                </div>
            </div>
        </div>

    <% } else { %>
            <div class="col-sm-3"></div>
    <% } %>

    <% if (Request["pesquisa"] == null) { %>

        <!-- Lista de computadores de acordo critérios especificados -->
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="EAN" DataSourceID="Visitado" AllowPaging="True" AllowSorting="True" ShowHeader="False" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="10" ForeColor="Black" GridLines="Horizontal" Width="700px" BackColor="White" Caption="Último visitado" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" CellSpacing="10">
        <Columns>
            <asp:ImageField DataImageUrlField="EAN" DataImageUrlFormatString="~/imagens/Computadores/{0}.jpg">
                <ControlStyle Height="80px" Width="100px" />
                <ItemStyle Height="25px" Width="25px" />
            </asp:ImageField>
            <asp:BoundField DataField="EAN" HeaderText="EAN" ReadOnly="True" SortExpression="EAN" Visible="False" />
            <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
            <asp:BoundField DataField="Processador" HeaderText="Processador" SortExpression="Processador" />
            <asp:BoundField DataField="Memoria_RAM" HeaderText="Memoria_RAM" SortExpression="Memoria_RAM" />
            <asp:BoundField DataField="Ecran" HeaderText="Ecran" SortExpression="Ecran" />
            <asp:BoundField DataField="Disco" HeaderText="Disco" SortExpression="Disco" />
            <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
            <asp:CommandField ButtonType="Image" ShowSelectButton="True" SelectImageUrl="~/imagens/more-details-computer-generated-web-button-icon-pure-white-background-more-details-button-119140803.jpg">
                <ControlStyle Height="40px" Width="120px" />
            </asp:CommandField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>

        <br />
        <br />

        <!-- Dados do último computador visitado -->
    <asp:SqlDataSource ID="Visitado" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT * FROM [T_Computadores] WHERE ([EAN] = @EAN)">
        <SelectParameters>
            <asp:CookieParameter CookieName="visitado" Name="EAN" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

        <div class="col-sm-3"></div>

    <% } %>

    <br />
    <br />
    
    <div class="col-sm-3"></div>

    <!-- Mostrar último computador visitado -->
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EAN" DataSourceID="Produtos" AllowPaging="True" AllowSorting="True" ShowHeader="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="10" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" CellSpacing="20">
        <Columns>
            <asp:ImageField DataImageUrlField="EAN" DataImageUrlFormatString="~/imagens/Computadores/{0}.jpg">
                <ControlStyle Height="80px" Width="100px" />
                <ItemStyle Height="25px" Width="25px" />
            </asp:ImageField>
            <asp:BoundField DataField="EAN" HeaderText="EAN" ReadOnly="True" SortExpression="EAN" Visible="False" />
            <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
            <asp:BoundField DataField="Processador" HeaderText="Processador" SortExpression="Processador" />
            <asp:BoundField DataField="Memoria_RAM" HeaderText="Memoria_RAM" SortExpression="Memoria_RAM" />
            <asp:BoundField DataField="Ecran" HeaderText="Ecran" SortExpression="Ecran" />
            <asp:BoundField DataField="Disco" HeaderText="Disco" SortExpression="Disco" />
            <asp:BoundField DataField="Preco" HeaderText="Preco" SortExpression="Preco" />
            <asp:CommandField ButtonType="Image" ShowSelectButton="True" SelectImageUrl="~/imagens/more-details-computer-generated-web-button-icon-pure-white-background-more-details-button-119140803.jpg">
                <ControlStyle Height="40px" Width="120px" />
            </asp:CommandField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>

    <br />

    <asp:SqlDataSource ID="Produtos" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT * FROM [T_Computadores]">
    </asp:SqlDataSource>
    
    <br />
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT * FROM [T_Computadores] WHERE ([EAN] &lt;&gt; @EAN)">
        <SelectParameters>
            <asp:CookieParameter CookieName="visitado" Name="EAN" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
