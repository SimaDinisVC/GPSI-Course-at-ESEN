using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogadores j1 = new Jogadores("Endri", "meio-campo", "Italiana", "20/06/2001", 1.71, 59);
            j1.Mostrar();
            Console.WriteLine("A idade do jogador corresponde a {0} anos,", j1.Idade());
            j1.Aposentar();
            Console.Write("Pressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
