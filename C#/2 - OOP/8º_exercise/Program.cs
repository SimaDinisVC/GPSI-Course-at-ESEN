using System;
using System.Collections.Generic;
using System.Linq;

namespace _8º_exercise
{
    internal class Program
    {
        static int menu() // Menú de Interação com o Utilizador
        {
            int op;

            Console.Write("Menú - Registo de Eventos\n\nIndique o tipo de evento a registar:\n0 - Sair\n1 - Evento Normal\n2 - Evento Bar Aberto\n- ");
            op = int.Parse(Console.ReadLine());

            while (op < 0 || op > 2) // Proteção
            {
                Console.WriteLine("\n---> Valores têm de estar compreendidos entre 0 e 2.\n     Tente Novamente!\n");
                Console.Write("Menú - Registo de Eventos\n\nIndique o tipo de evento a registar:\n0 - Sair\n1 - Evento Normal\n2 - Evento Bar Aberto\n- ");
                op = int.Parse(Console.ReadLine());
            }

            if (op == 0)
                Environment.Exit(1); // Sai do Programa
            else if (op == 1)
                return 1;
            else
                return 2;

            return 0;

        }

        static double Bilhete(double valor_entradaP, double custos, int qnt_convites)
        {
            Console.WriteLine("Introduza o tipo de Bilhete: ");
            string t = Console.ReadLine();
            if (t == "P")
            {
                if (valor_entradaP == 0)
                    valor_entradaP = custos / qnt_convites;
                return valor_entradaP;
            }
            else if (t == "N")
            {
                double valor_entradaN = valor_entradaP + valor_entradaP * 0.1;
                return valor_entradaN;
            }
            else
            {
                double valor_entradaN = valor_entradaP + valor_entradaP * 0.1;
                double valor_entradaV = valor_entradaN + valor_entradaN * 0.15;
                return valor_entradaV;
            }
            
            return 0;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                int opcao = menu();
                string descricao, local, data_prevista;
                int qnt_convites;
                double custos, valor_entradaP;
                List<Bebida> bebidas = new List<Bebida>();

                Console.Write("\nIntroduza uma breve descrição do Evento: ");
                descricao = Console.ReadLine();

                Console.Write("\nIntroduza o local do Evento: ");
                local = Console.ReadLine();

                Console.Write("\nIntroduza a data do Evento (Formato DD/MM/AAAA): ");
                data_prevista = Console.ReadLine();

                string[] splits = data_prevista.Split('/'); // Proteção
                while (splits.Count() != 3)
                {
                    Console.WriteLine("\n---> Tem de introduzir no formato DD/MM/AAAA.");
                    Console.Write("\nIntroduza a data do Evento (Formato DD/MM/AAAA): ");
                    data_prevista = Console.ReadLine();
                    splits = data_prevista.Split('/');
                }

                Console.Write("\nIntroduza a Quantidade de Convites: ");
                qnt_convites = int.Parse(Console.ReadLine());

                Console.Write("\nIntroduza os Custos da Organização: ");
                custos = double.Parse(Console.ReadLine());

                Console.Write("\nIntroduza o Valor de Entrada Popular (0 para não introduzir): ");
                valor_entradaP = double.Parse(Console.ReadLine());


                if (opcao == 1) // Evento Normal
                {
                    
                }
                else // Evento Bar Aberto
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("Introduza o nome da {}ª bebida",j);
                        string nome = Console.ReadLine();
                        Console.WriteLine("Introduza o teor alcoolico da {}ª bebida", j);
                        double teor_alcoolico = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduza o valor/uni. da {}ª bebida", j);
                        double valor = double.Parse(Console.ReadLine());
                        bebidas.Add(new Bebida(nome, teor_alcoolico, valor));
                    }
                    Bar_Aberto eventoN = new Bar_Aberto(descricao, local, data_prevista, qnt_convites, custos, Bilhete(valor_entradaP, custos, qnt_convites), bebidas);
                }
            }
        }
    }
}
