<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inserir_computador.aspx.cs" Inherits="WebApplication1.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function onValueChanged() {
            document.getElementById("txt_Desconto").value = 
            		document.getElementById("Desconto").value;
        }

        function onLoad() {
            document.getElementById("txt_Desconto").value = 
            		document.getElementById("Desconto").value;
        }
        window.onload = onLoad;

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-sm-3"></div>
    
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="EAN" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnItemInserting="FormView1_ItemInserting">
        <EditItemTemplate>
            EAN:
            <asp:Label ID="EANLabel1" runat="server" Text='<%# Eval("EAN") %>' />
            <br />
            Marca:
            <asp:TextBox ID="MarcaTextBox" runat="server" Text='<%# Bind("Marca") %>' />
            <br />
            Modelo:
            <asp:TextBox ID="ModeloTextBox" runat="server" Text='<%# Bind("Modelo") %>' />
            <br />
            Processador:
            <asp:TextBox ID="ProcessadorTextBox" runat="server" Text='<%# Bind("Processador") %>' />
            <br />
            Memoria_RAM:
            <asp:TextBox ID="Memoria_RAMTextBox" runat="server" Text='<%# Bind("Memoria_RAM") %>' />
            <br />
            Ecran:
            <asp:TextBox ID="EcranTextBox" runat="server" Text='<%# Bind("Ecran") %>' />
            <br />
            Disco:
            <asp:TextBox ID="DiscoTextBox" runat="server" Text='<%# Bind("Disco") %>' />
            <br />
            Tipologia:
            <asp:TextBox ID="TipologiaTextBox" runat="server" Text='<%# Bind("Tipologia") %>' />
            <br />
            Desconto:
            <asp:TextBox ID="DescontoTextBox" runat="server" Text='<%# Bind("Desconto") %>' />
            <br />
            Data_Aquisicao:
            <asp:TextBox ID="Data_AquisicaoTextBox" runat="server" Text='<%# Bind("Data_Aquisicao") %>' />
            <br />
            Tatil:
            <asp:CheckBox ID="TatilCheckBox" runat="server" Checked='<%# Bind("Tatil") %>' />
            <br />
            Preco:
            <asp:TextBox ID="PrecoTextBox" runat="server" Text='<%# Bind("Preco") %>' />
            <br />
            descricao:
            <asp:TextBox ID="descricaoTextBox" runat="server" Text='<%# Bind("descricao") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            EAN:
            <asp:TextBox ID="EANTextBox" runat="server" Text='<%# Bind("EAN") %>' />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="EANTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Marca:
            <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("Marca") %>'>
                <asp:ListItem>HP</asp:ListItem>
                <asp:ListItem Value="Asus"></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            Modelo:
            <asp:TextBox ID="ModeloTextBox" runat="server" Text='<%# Bind("Modelo") %>' />
            <br />
            Processador:
            <asp:TextBox ID="ProcessadorTextBox" runat="server" Text='<%# Bind("Processador") %>' />
            <br />
            Memoria_RAM:
            <asp:TextBox ID="Memoria_RAMTextBox" runat="server" Text='<%# Bind("Memoria_RAM") %>' />
            <br />
            Ecran:
            <asp:TextBox ID="EcranTextBox" runat="server" Text='<%# Bind("Ecran") %>' />
            <br />
            Disco:
            <asp:TextBox ID="DiscoTextBox" runat="server" Text='<%# Bind("Disco") %>' />
            <br />
            Tipologia:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Portátil</asp:ListItem>
                <asp:ListItem>Hibrido</asp:ListItem>
            </asp:RadioButtonList>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            Desconto:<br />
            <asp:TextBox ID="txt_Desconto" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="Desconto" runat="server" Text='<%# Bind("Desconto") %>' TextMode="Range" OnClick="onValueChanged();"/>
            <br />
            Tatil:
            <asp:CheckBox ID="TatilCheckBox" runat="server" Checked='<%# Bind("Tatil") %>' />
            <br />
            Preco:
            <asp:TextBox ID="PrecoTextBox" runat="server" Text='<%# Bind("Preco", "{0:C}") %>' TextMode="Number" />
            <br />
            descricao:
            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("descricao") %>' TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" OnClick="InsertButton_Click" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            EAN:
            <asp:Label ID="EANLabel" runat="server" Text='<%# Eval("EAN") %>' />
            <br />
            <br />
            Marca:
            <asp:Label ID="MarcaLabel" runat="server" Text='<%# Bind("Marca") %>' />
            <br />
            Modelo:
            <asp:Label ID="ModeloLabel" runat="server" Text='<%# Bind("Modelo") %>' />
            <br />
            Processador:
            <asp:Label ID="ProcessadorLabel" runat="server" Text='<%# Bind("Processador") %>' />
            <br />
            Memoria_RAM:
            <asp:Label ID="Memoria_RAMLabel" runat="server" Text='<%# Bind("Memoria_RAM") %>' />
            <br />
            Ecran:
            <asp:Label ID="EcranLabel" runat="server" Text='<%# Bind("Ecran") %>' />
            <br />
            Disco:
            <asp:Label ID="DiscoLabel" runat="server" Text='<%# Bind("Disco") %>' />
            <br />
            Tipologia:
            <asp:Label ID="TipologiaLabel" runat="server" Text='<%# Bind("Tipologia") %>' />
            <br />
            Desconto:
            <asp:Label ID="DescontoLabel" runat="server" Text='<%# Bind("Desconto") %>' />
            <br />
            Data_Aquisicao:
            <asp:Label ID="Data_AquisicaoLabel" runat="server" Text='<%# Bind("Data_Aquisicao") %>' />
            <br />
            Tatil:
            <asp:CheckBox ID="TatilCheckBox" runat="server" Checked='<%# Bind("Tatil") %>' Enabled="false" />
            <br />
            Preco:
            <asp:Label ID="PrecoLabel" runat="server" Text='<%# Bind("Preco") %>' />
            <br />
            descricao:
            <asp:Label ID="descricaoLabel" runat="server" Text='<%# Bind("descricao") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" DeleteCommand="DELETE FROM [T_Computadores] WHERE [EAN] = @EAN" InsertCommand="INSERT INTO [T_Computadores] ([EAN], [Marca], [Modelo], [Processador], [Memoria_RAM], [Ecran], [Disco], [Tipologia], [Desconto], [Tatil], [Preco], [descricao]) VALUES (@EAN, @Marca, @Modelo, @Processador, @Memoria_RAM, @Ecran, @Disco, @Tipologia, @Desconto, @Tatil, @Preco, @descricao)" SelectCommand="SELECT * FROM [T_Computadores]" UpdateCommand="UPDATE [T_Computadores] SET [Marca] = @Marca, [Modelo] = @Modelo, [Processador] = @Processador, [Memoria_RAM] = @Memoria_RAM, [Ecran] = @Ecran, [Disco] = @Disco, [Tipologia] = @Tipologia, [Desconto] = @Desconto, [Data_Aquisicao] = @Data_Aquisicao, [Tatil] = @Tatil, [Preco] = @Preco, [descricao] = @descricao WHERE [EAN] = @EAN">
        <DeleteParameters>
            <asp:Parameter Name="EAN" Type="String" />
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
            <asp:Parameter Name="EAN" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
