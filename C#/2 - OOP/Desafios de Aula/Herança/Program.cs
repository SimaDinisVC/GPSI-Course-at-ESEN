using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("BMW", "Cinza");

            Console.WriteLine(c1.Rodas());
            Console.WriteLine(c1.getLigado());

            Console.Write("Pressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
