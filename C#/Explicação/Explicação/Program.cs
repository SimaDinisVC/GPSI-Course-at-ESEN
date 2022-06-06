using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10];
            for (int i = 0; i <= 8; i++)
            {
                string nome = Console.ReadLine();
                lista[i] = nome;
            }
            Array.Reverse(lista);
            Console.WriteLine(string.Join(" > ", lista));
            Console.Write("Qualquer Tecla...");
            Console.ReadKey();
        }
    }
}
