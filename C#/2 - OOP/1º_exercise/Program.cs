using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1º_exercise
{
    internal class Program
    {
        static int Menu()
        {
            int select;
            Console.Write("### MENU ###\n1 - Criar Quadrado\n2 - Área\n3 - Diagonal\n4 - Perímetro\n- ");
            int.TryParse(Console.ReadLine(), out select);
            
            return select;
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine();
            Quadrado quadrado1 = new Quadrado();
            Quadrado quadrado2 = new Quadrado(20);

            quadrado1.area();
            quadrado1.diagonal();
            quadrado1.perimetro(); */
            int select = Menu();
            if (select != 0)
            {
                string lado;
                Console.Write("Introduza o valor do lado (enter para usar predefinição): ");
                lado = Console.ReadLine();
                if (lado == "")
                {
                    lado = 0;
                }
            }
            else
            {

            }

            
        }
    }
}
