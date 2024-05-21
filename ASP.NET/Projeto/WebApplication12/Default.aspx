<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication12._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
        .feature {
            height: 100%; /* Define uma altura de 100% */
        }
    </style>
    <div>
    <main class="my-5">
        <section class="hero">
            <div class="container">
                <h2>Bem-vindo à GYMachines</h2>
                <p class="lead">A tua loja online com os melhores equipamentos de ginásio.</p>
                <a href="Maquinas" class="btn btn-dark btn-lg">Ver Produtos</a>
            </div>
        </section>

        <section class="features">
            <div class="container mt-5">
    <h2>Porquê escolher a GYMachines?</h2>
    <div class="row mt-3">
        <div class="col-md-4">
            <div class="feature bg-dark rounded-3 p-4"> <!-- Adiciona a classe border-rounded aqui -->
                <i class="fas fa-dumbbell text-light"></i>
                <h3 class="text-light">Qualidade Superior 💎✨</h3>
                <p class="text-light" style="text-align:justify;"> Os nossos equipamentos são feitos com os melhores materiais para garantir a durabilidade e o desempenho.</p>
            </div>
        </div>
        <div class="col-md-4">
            <div class="feature bg-dark rounded-3 p-4"> <!-- Adiciona a classe border-rounded aqui -->
                <i class="fas fa-truck text-light"></i>
                <h3 class="text-light">Entrega Rápida 🚚💨</h3>
                <p class="text-light" style="text-align:justify;">Enviamos os equipamentos para a tua casa com rapidez e segurança.</p>
            </div>
        </div>
        <div class="col-md-4">
            <div class="feature bg-dark rounded-3 p-4"> <!-- Adiciona a classe border-rounded aqui -->
                <i class="fas fa-dollar-sign text-light"></i>
                <h3 class="text-light">Preços Competitivos ⚖️💰</h3>
                <p class="text-light" style="text-align:justify;">Oferecemos os melhores preços do mercado para que tu possas equipar o teu ginásio sem gastar muito.</p>
            </div>
        </div>
    </div>
</div>
        </section>
        </section>
    </main>
    </div>
</asp:Content>
