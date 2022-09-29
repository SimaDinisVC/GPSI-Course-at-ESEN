using System;

namespace MOD9_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação do Objeto do Tipo Pessoa
            Pessoa p1 = new Pessoa();
            Console.WriteLine(p1.nome);

            Pessoa p2 = new Pessoa("João", "07-10-20006", 1.85);
            Console.WriteLine(p2.nome);
        }
    }
}
