using System;

namespace _5º_exercise
{
    internal class Produto
    {
        // Atributos
        private string nome;
        double precoCusto, precoVenda, margemLucro;

        public Produto() // Construtor Vazio para versões .NET obrigatórias
        { }

        public Produto(string nome, double precoCusto, double precoVenda) // Construtor Predefinição
        {
            this.nome = nome;
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
        }
        
        // Encapsulamento

        public string retornaNome()
        {
            return nome;
        }

        public double retornaCusto()
        {
            return precoCusto;
        }

        public double retornaVenda()
        {
            return precoVenda;
        }

        public double retornaMargemLucro()
        {
            return margemLucro;
        }

        public void alteraNome(string nome)
        {
            this.nome = nome;
        }

        public void alteraCusto(double precoCusto)
        {
            if (precoVenda >= precoCusto)
                this.precoCusto = precoCusto;
            else
                Console.Error.WriteLine("Desculpe, mas o preco do Custo não pode ser superior ao preco de Venda.");
        }

        public void alteraVenda(double precoVenda)
        {
            if (precoVenda >= precoCusto)
                this.precoVenda = precoVenda;
            else
                Console.Error.WriteLine("Desculpe, mas o preco do Venda não pode ser inferior ao preco de Custo.");
        }

        public double calcularMargemLucro()
        {
            margemLucro = precoVenda - precoCusto;
            return margemLucro;
        }

        public double getMargemLucroPorcentagem()
        {
            return Math.Round(margemLucro * 100 / precoCusto, 1);
        }
    }
}
