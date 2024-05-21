<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="configurador.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    <style type="text/css">
        .auto-style1 
        {
            font-family: Arial;
            font-size: medium;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="col-sm-2">

        <div class="panel panel-default">
            <div class="panel-body">Processador</div>
            <div class="panel-footer">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" DataSourceID="Processador" DataTextField="Processador" DataValueField="Processador" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Processador" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Processador] FROM [T_Computadores] ORDER BY [Processador]"></asp:SqlDataSource>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-body">Memória</div>
            <div class="panel-footer">
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style1" DataSourceID="Memoria" DataTextField="Memoria_RAM" DataValueField="Memoria_RAM" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Memoria" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Memoria_RAM] FROM [T_Computadores] ORDER BY [Memoria_RAM] DESC"></asp:SqlDataSource>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-body">Disco</div>
            <div class="panel-footer">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style1" DataSourceID="Disco" DataTextField="Disco" DataValueField="Disco" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Disco" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Disco] FROM [T_Computadores] ORDER BY [Disco] DESC"></asp:SqlDataSource>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-body">Monitor</div>
            <div class="panel-footer">
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="auto-style1" DataSourceID="Monitor" DataTextField="Ecran" DataValueField="Ecran" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="Monitor" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT DISTINCT [Ecran] FROM [T_Computadores] ORDER BY [Ecran] DESC"></asp:SqlDataSource>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-body">Preço Máximo</div>
            <div class="panel-footer">
                <asp:Label ID="lbl_preco" runat="server"></asp:Label>  
                <asp:TextBox ID="TextBox1" TextMode="Range" min='300' max='3000'  runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True">3000</asp:TextBox>
            </div>
        </div>
    </div>
    

    <div class="col-sm-10">

        <!-- Registos dos computadores mais recentes -->
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="Computadores">

            <ItemTemplate>
                <table>
                    <tr>
                        <td style="width: 300px"></td>
                        <td>
                            <a href="detalhes.aspx?ean=<%#Eval("ean")%>" style="padding-right: 15px">
                                <img src="imagens/computadores/<%#Eval("ean") %>.jpg" style="width: 200px; height: 150px" />
                            </a>
                        </td>
                        <td>
                            <%#Eval("marca") %> &nbsp; <%#Eval("modelo") %>
                            <br />
                            <h2><%#Eval("preco") %> &nbsp; € </h2>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 50px"></td>
                    </tr>
                </table>
            </ItemTemplate>

        </asp:Repeater>

        <asp:SqlDataSource ID="Computadores" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" SelectCommand="SELECT [EAN], [Marca], [Modelo], [Preco] FROM [T_Computadores] WHERE (([Processador] = @Processador) AND ([Memoria_RAM] = @Memoria_RAM) AND ([Disco] = @Disco) AND ([Ecran] = @Ecran) AND ([Preco] <= @Preco))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Processador" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList2" Name="Memoria_RAM" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList3" Name="Disco" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList4" Name="Ecran" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="lbl_preco" Name="preco" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
</asp:Content>
