<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GYMachines.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container d-flex flex-column align-items-center">
    <h2>Entrar na conta</h2>
    <hr />
    <div class="card card-container border-0 ps-1">
        
       
        Email:
        <input type="email" id="email" class="form-control" style="width: 300px" runat="server"><br />

        Password:
        <input type="password" id="Password" class="form-control" style="width:300px" runat="server"><br />
        
        <div id="remember" class="checkbox mb-4 pt-0" >
            <label>
                <asp:CheckBox  ID="Chk_remember" runat="server" AutoPostBack="False" />
                &nbsp;Remember me              
            </label>
        </div>

        <asp:Button class="btn btn-success" ID="Button1" runat="server" Style="width: 300px" Text="Login" OnClick="login_ServerClick"/>
        
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Esqueceu-se da Password?</asp:LinkButton>
        <asp:Label ID="lbl_erro" runat="server" Font-Bold="True" ForeColor="Red" Text="Login incorreto" Visible="False"></asp:Label>
    </div>
</div>
</asp:Content>
