<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="registar.aspx.cs" Inherits="WebApplication1.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://www.google.com/recaptcha/api.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-4"></div>
    <div class="col-sm-4">
        <h2>Registar nova conta </h2>
        <hr />
        <div class="card card-container">
            
            <!-- Testar se o Username foi preenchido -->
            Username:
            <% if (Label1.Text != "")
               { %>
                    <input type="text" id="username1" class="form-control" style= "width:300px; border-color:red " runat="server">
            <% } 
               else 
               { %>
                    <input type="text" id="username2" class="form-control" style= "width:300px" runat="server">
            <% } %>

                    <!-- Mensagem de erro para Username -->
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=""></asp:Label><br />
           
            Password:
            <input type="password" id="Password" class="form-control" style="width:300px" runat="server"><br />
            
            Confirma Password:
            <input type="password" id="ConfirmaPassword" class="form-control" style="width: 300px" runat="server"><br />
            
            Email:
            <input type="email" id="email" class="form-control" style="width: 300px" runat="server"><br />
            
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            
            <asp:Button class="btn btn-success" ID="Button1" runat="server" OnClick="Button1_Click" style="width: 300px" Text="Registar" />
            
            <div class="g-recaptcha" data-sitekey="6LcTCmIpAAAAAEwDuVqcjhjQJwYYzWQLdas2oRSC"></div>

        </div>
    </div>

</asp:Content>
