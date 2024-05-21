<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registar.aspx.cs" Inherits="GYMachines.registar" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script src="https://www.google.com/recaptcha/api.js"></script>
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container d-flex flex-column align-items-center">
    <h2>Registar conta</h2>
    <hr/>
    <div class="card card-container border-0 ps-1">
        
        <!-- Testar se o Username foi preenchido -->
        Username:
        <% if (Label1.Text != "")
           { %>
                <input type="text" id="username1" class="form-control" style= "width:300px; border-color:red " runat="server">
        <% } 
           else 
           { %>
                <input type="text" id="username2" class="form-control" style= "width:300px;" runat="server">
        <% } %>

        <!-- Mensagem de erro para Username -->
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=""></asp:Label><br />
       
        Email:
        <input type="email" id="email" class="form-control" style="width: 300px" runat="server"><br />

        Password:
        <input type="password" id="Password" class="form-control" style="width:300px" runat="server"><br />
        
        Confirma Password:
        <input type="password" id="ConfirmaPassword" class="form-control" style="width: 300px" runat="server"><br />
        
        <asp:Button class="btn btn-success" ID="Button1" runat="server" style="width: 300px" Text="Registar" OnClick="Button1_Click"/>

    </div>
    <div class="g-recaptcha mt-3" data-sitekey="6LcTCmIpAAAAAEwDuVqcjhjQJwYYzWQLdas2oRSC"></div>
</div>
</asp:Content>
