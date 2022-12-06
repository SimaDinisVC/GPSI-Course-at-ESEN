using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("José", new Morada("Rua Direita", "Viseu", "3501-123"), 961239198);
            Atleta a1 = new Atleta("Tiago", new Morada("Rua do Palácio", "Porto", "2311-133"), 921234123, 60.5, 1.80);
            Atleta a2 = new Atleta("Martim", new Morada("Rua de Alfama", "Lisboa", "1011-145"), 935325645, 50, 1.73);

            Console.WriteLine("---> Pessoa 1\n");
            Console.WriteLine(p1.RetornaMorada());
            Console.WriteLine("\n---> Alteta 1\n");
            Console.WriteLine("IMC: " + a1.DevolveIMC());
            Console.WriteLine("Classificação: " + a1.ClassificarIMC());
            Console.WriteLine("\n---> Alteta 2\n");
            Console.WriteLine("IMC: " + a2.DevolveIMC());
            Console.WriteLine("Classificação: " + a2.ClassificarIMC());

            Console.WriteLine("\nPrima Qualquer Tecla para sair...");
            Console.ReadKey();
        }
    }
}
