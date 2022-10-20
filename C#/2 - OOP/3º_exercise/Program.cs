using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilhete b1 = new Bilhete();
            BilheteVIP bv1 = new BilheteVIP();

            b1.ImprimirValor(); // Impressão do Valor
            Console.WriteLine("O valor do Bilhete VIP é {0} euros.", bv1.Valor()); // Impressão através do retorno do valor

            Console.Write("\nPressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
