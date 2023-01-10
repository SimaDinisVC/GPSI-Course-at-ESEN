using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal static class Jogador
    {
        public static int energia;
        public static bool vida;
        public static string nome;

        public static void IniciarJogador(string n)
        {
            energia = 100;
            vida = true;
            nome = n;
        }

        public static void info()
        {
            Console.WriteLine(energia);
            Console.WriteLine(vida);
            Console.WriteLine(nome);
        }
    }
}
