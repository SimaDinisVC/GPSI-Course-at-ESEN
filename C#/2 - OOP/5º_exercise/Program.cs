using System;

namespace _5º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double custo, venda;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o preço de custo: ");
            bool booleanCusto = double.TryParse(Console.ReadLine(), out custo);
            Console.Write("Digite o preço de venda: ");
            bool booleanVenda = double.TryParse(Console.ReadLine(), out venda);

            while (!booleanCusto) // Proteção
            {
                Console.Error.WriteLine("Tem de introduzir numeros.\nDigite o preço de custo: ");
                booleanCusto = double.TryParse(Console.ReadLine(), out custo);
            }

            while (!booleanVenda) // Proteção
            {
                Console.WriteLine("Tem de introduzir numeros.\nDigite o preço de venda: ");
                booleanVenda = double.TryParse(Console.ReadLine(), out custo);
            }

            Produto p1 = new Produto(nome, custo, venda); // Objeto

            Console.WriteLine("Preço do custo: {0} euros", p1.retornaCusto());
            Console.WriteLine("Preço do venda: {0} euros", p1.retornaVenda());
            Console.WriteLine("Margem de Lucro: {0} euros", p1.calcularMargemLucro());
            Console.WriteLine("Margem de Lucro em Percentagem: {0}%", p1.getMargemLucroPorcentagem());

            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
