using System;

namespace IntroCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out idade); // Devolve valor boll do sucesso da conversão, e no out 0 se False
            //idade = int.Parse(Console.ReadLine());
            //Console.Clear();   // Limpa a consola == cls

            
            Console.WriteLine("Hello, " + nome + "!");

            if (idade < 18)
                Console.WriteLine("Não pode entrar na discoteca!");
            else
                Console.WriteLine("Pode entrar na discoteca!");

            Console.Write("\nPrime qualquer tecla...");
            Console.ReadKey();
        }
    }
}
