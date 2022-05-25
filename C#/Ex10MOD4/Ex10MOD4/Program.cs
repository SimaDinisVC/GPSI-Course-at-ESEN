using System;
using System.Linq;

namespace Ex10MOD4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int avisos7 = 7;
            int falta;
            int[] faltas = new int[10];
            int[] jogadores = new int[10];
            int[] jogadores5 = new int[10];

            while (true)
            {
                Console.Write("Introduza o nº de jogador que realizou falta: ");
                int.TryParse(Console.ReadLine(), out falta);
                if (falta == 0)
                    break;
                else if (jogadores.Contains(falta) == false)
                {
                    jogadores.Append(falta);
                    faltas.Append(1);
                }
                else
                {
                    faltas[Array.IndexOf(jogadores, falta)] += 1;
                    foreach (int i in faltas)
                    {
                        int indice = Array.IndexOf(faltas, i);
                        if (i == 5 && jogadores5.Contains(jogadores[indice]) == false)
                        {
                            Console.WriteLine("O jogador {0} atingiu as cinco faltas.", jogadores[indice]);
                            jogadores5.Append(jogadores[indice]);
                        }
                    }
                    if (faltas.Sum() == avisos7)
                    {
                        if (avisos7 == 7)
                        {
                            Console.WriteLine("A equipa somou 7 faltas.");
                            avisos7 *= 2;
                        }
                        else
                        {
                            Console.WriteLine("A equipa somou mais 7 faltas.");
                            avisos7 *= 2;
                        }
                    }
                }
            }
            if (faltas.Length != 0)
            {
                for (int i = 0; i < faltas.Length; i++)
                {
                    Console.WriteLine("O jogador {0} teve {1} faltas.", jogadores[i], faltas[i]);
                }
                Console.WriteLine("A equipa acumulou {0} faltas.", faltas.Sum());
            }
            else
            {
                Console.WriteLine("O programa não encontrou nenhuma falta.");
            }
            Console.Write("Prime qualquer tecla...");
            Console.ReadKey();
        }
    }
}
