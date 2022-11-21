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

        static void Main(string[] args)
        {
            List<int> ids = new List<int>(); // Apenas para não se repetir o mesmo ID

            for (int i = 0; i < 5; i++)
            {
                int opcao = menu();
                int id;
                string descricao, local, data_prevista;
                int qnt_convites;
                double custos;
                Entrada valor_entrada;

                Console.Write("Introduza o Identificador do Evento (Enter para gerar um ID): ");
                bool flag = int.TryParse(Console.ReadLine(), out id); // Caso a flag devolver True é então o utilizador introduziu um nª
                if (flag) // Proteção
                {
                    while (ids.Contains(id))
                    {
                        Console.WriteLine("\n--> Identificador já existente! Tente outro!\n");
                        Console.Write("Introduza o Identificador do Evento (Enter para gerar um ID): ");
                        flag = int.TryParse(Console.ReadLine(), out id);
                        if (!flag) // FUNCIONALIDADE APARTE (No caso de não introduzir um nº ele passa a gerar um id)
                        {
                            do
                            {
                                Random rd = new Random();
                                id = rd.Next(10000, 99999);
                            }
                            while (ids.Contains(id));
                            break; // Para quebrar o while da introdução do ID à mão
                        }
                    }
                }
                else // FUNCIONALIDADE APARTE (No caso de não introduzir um nº ele passa a gerar um id)
                {
                    do
                    {
                        Random rd = new Random();
                        id = rd.Next(10000, 99999);
                    }
                    while (ids.Contains(id));
                }
                ids.Add(id);

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

                if (opcao == 1)
                {
                    
                }
                else
                {

                }
            }
        }
    }
}
