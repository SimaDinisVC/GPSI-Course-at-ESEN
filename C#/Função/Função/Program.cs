using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Função
{
    internal class Program
    {
        static char menu() // Função
        {
            char op;
            Console.Clear();
            Console.Write("----------\n   Menú\n0 - Sair\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n- ");
            char.TryParse(Console.ReadLine(), out op);
            return op;
        }
        static int somar(int n, int m)
        {
           return n + m;
        }
        static void Main(string[] args)
        {
            char op = 'S'; // representa um caratere (1 byte)
            int num1, num2;

            do // Executa
            {
                op = menu();
                Console.Clear();

                switch (op)
                {
                    case '1':
                        Console.Write("Número: ")
                        int.TryParse(Console.ReadLine(), out num1);
                        Console.Write("Número: ")
                        int.TryParse(Console.ReadLine(), out num2);
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    default:
                        if (op != '0') Console.Beep();
                        break;
                }
            }
            while (op != '0'); // Verifica

        }
    }
}
