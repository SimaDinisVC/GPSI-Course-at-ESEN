<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="WebApplication1.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
      <div class="col-sm-3"></div>

    <asp:FormView ID="FormView1" runat="server" DataKeyNames="Username" DataSourceID="SqlDataSource1" DefaultMode="Edit">
    <EditItemTemplate>
        Nome:
        <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        Username: <br />
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>
    <InsertItemTemplate>
        Nome:
        <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        Username:
        <asp:TextBox ID="UsernameTextBox" runat="server" Text='<%# Bind("Username") %>' />
        <br />
        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </InsertItemTemplate>
    <ItemTemplate>
        Nome:
        <asp:Label ID="NomeLabel" runat="server" Text='<%# Bind("Nome") %>' />
        <br />
        email:
        <asp:Label ID="emailLabel" runat="server" Text='<%# Bind("email") %>' />
        <br />
        Username:
        <asp:Label ID="UsernameLabel" runat="server" Text='<%# Eval("Username") %>' />
        <br />
        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
        &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
        &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
    </ItemTemplate>
</asp:FormView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TecNavarroConnectionString %>" DeleteCommand="DELETE FROM [Utilizadores] WHERE [Username] = @original_Username AND (([Nome] = @original_Nome) OR ([Nome] IS NULL AND @original_Nome IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))" InsertCommand="INSERT INTO [Utilizadores] ([Nome], [email], [Username]) VALUES (@Nome, @email, @Username)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Nome], [email], [Username] FROM [Utilizadores] WHERE ([Username] = @Username)" UpdateCommand="UPDATE [Utilizadores] SET [Nome] = @Nome, [email] = @email WHERE [Username] = @original_Username AND (([Nome] = @original_Nome) OR ([Nome] IS NULL AND @original_Nome IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))">
    <DeleteParameters>
        <asp:Parameter Name="original_Username" Type="String" />
        <asp:Parameter Name="original_Nome" Type="String" />
        <asp:Parameter Name="original_email" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="Username" Type="String" />
    </InsertParameters>
    <SelectParameters>
        <asp:SessionParameter Name="Username" SessionField="user" Type="String" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="Nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="original_Username" Type="String" />
        <asp:Parameter Name="original_Nome" Type="String" />
        <asp:Parameter Name="original_email" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
