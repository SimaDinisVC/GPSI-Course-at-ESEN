using System;

namespace _1º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            Console.Write("Introduza o lado do quadrado (enter para não introduzir):\n- ");
            bool flag = int.TryParse(Console.ReadLine(), out lado);
            if (flag == false)
            {
                Quadrado quadrado1 = new Quadrado();
                Console.WriteLine("Area do Quadrado: " + quadrado1.area());
                Console.WriteLine("Diagonal do Quadrado: " + quadrado1.diagonal());
                Console.WriteLine("Perímetro do Quadrado: " + quadrado1.perimetro());
            }
            else if (lado >= 0 && lado <= 20)
            {
                Quadrado quadrado1 = new Quadrado(lado);
                Console.WriteLine("Area do Quadrado: " + quadrado1.area());
                Console.WriteLine("Diagonal do Quadrado: " + quadrado1.diagonal());
                Console.WriteLine("Perímetro do Quadrado: " + quadrado1.perimetro());
            }
            else
            {
                Console.WriteLine("O lado tem de estar compreendido entre 0 e 20.");
            }
            Console.Write("Pressione qualquer tecla...");
            Console.ReadKey();
        }
    }
}
