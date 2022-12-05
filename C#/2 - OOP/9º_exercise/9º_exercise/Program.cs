using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9º_exercise
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            /*
             Durante o seu trajeto é preciso saber:
             o estado do balão a cada momento, mudar a sua cor, mudar a sua direção e controlar a sua altura.
            */

            int opcao;
            Balao b1;

            do
            {
                Console.WriteLine("### Inicialização do Sistema ###\n");
                Console.Write("0 - Sair\n1 - Criar Balão Padrão\n2 - Criar Balão Personalizado\n--> ");
                opcao = int.Parse(Console.ReadLine());
            }
            while (opcao < 0 || opcao > 2);

            if (opcao == 0) 
            {
                Environment.Exit(0);
                b1 = new Balao(); // Nunca é executado, mas é necessário para a verificação da variável
            }
            else if (opcao == 1)
                b1 = new Balao();
            else
            {
                Console.Write("\nO Balão já se encontra aceso? (true/false)\n--> ");
                bool acendido = bool.Parse(Console.ReadLine());

                Console.Write("\nIndique a cor do balão:\n--> ");
                string cor = Console.ReadLine();

                char direcao;
                do { 
                    Console.Write("\nIndique a direção do balão: (N - Norte / S - Sul / E - Este / O - Oeste)\n--> ");
                    direcao = Console.ReadKey().KeyChar;
                }
                while (direcao.ToString() != "N" && direcao.ToString() != "S" && direcao.ToString() != "E" && direcao.ToString() != "O"); 
                // ToString necessário para a verificação !=

                Console.Write("\n\nIndique a altura do balão: \n--> ");
                double altura = double.Parse(Console.ReadLine());
                while (altura < 0)
                {
                    Console.WriteLine("\nA altura não pode ser negativa.");
                    Console.Write("Indique a altura do balão: \n--> ");
                    altura = double.Parse(Console.ReadLine());
                }

                b1 = new Balao(acendido, cor, direcao, altura);
            }

            while (true)
            {
                do {
                    Console.Write("\n");
                    b1.getStatus();
                    Console.Write("\nAtualizar:\n\n0 - Sair\n1 - Estado do Balão\n2 - Cor\n3 - Direção\n4 - Altura\n--> ");
                    opcao = int.Parse(Console.ReadLine());
                }
                while (opcao < 0 || opcao > 4);

                if (opcao == 0)
                    Environment.Exit(0);
                else if (opcao == 1)
                {
                    Console.Write("\nO Balão já se encontra aceso? (true/false)\n--> ");
                    bool acendido = bool.Parse(Console.ReadLine());
                    b1.modifyAcendido(acendido);
                }
                else if (opcao == 2)
                {
                    Console.Write("\nIndique a cor do balão:\n--> ");
                    string cor = Console.ReadLine();
                    b1.modifyCor(cor);
                }
                else if (opcao == 3)
                {
                    char direcao;
                    do
                    {
                        Console.Write("\nIndique a direção do balão: (N - Norte / S - Sul / E - Este / O - Oeste)\n--> ");
                        direcao = Console.ReadKey().KeyChar;
                    }
                    while (direcao.ToString() != "N" && direcao.ToString() != "S" && direcao.ToString() != "E" && direcao.ToString() != "O");
                    // ToString necessário para a verificação !=
                    b1.modifyDirecao(direcao);
                }
                else
                {
                    Console.Write("\nIndique a altura do balão: \n--> ");
                    double altura = double.Parse(Console.ReadLine());
                    while (altura < 0)
                    {
                        Console.WriteLine("\nA altura não pode ser negativa.");
                        Console.Write("Indique a altura do balão: \n--> ");
                        altura = double.Parse(Console.ReadLine());
                    }
                    b1.modifyAltura(altura);
                }
            }
        }
    }
}
