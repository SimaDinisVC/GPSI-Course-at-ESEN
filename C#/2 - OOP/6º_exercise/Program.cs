using System;

namespace _6º_exercise
{
    internal class Program
    {
        static int Menu() // Função que lidera o menú
        {
            int opcao;
            do
            {
                Console.WriteLine("####MENÚ####");
                Console.WriteLine("Criação de uma conta\nEscolha uma das opções:");
                Console.Write("0 - Sair\n1 - Conta Corrente Simples\n2 - Conta Corrente especial\n3 - Conta poupança\n- ");
                opcao = int.Parse(Console.ReadLine());
            }
            while (opcao < 0 && opcao > 3);

            if (opcao == 0)
            {
                Environment.Exit(0); // Sai do Programa
                return 0;
            }
            else if (opcao == 1)
                return 1;
            else if (opcao == 2)
                return 2;
            else
                return 3;
        }

        static void Main(string[] args)
        {
            int op = Menu();

            //Variáveis que todas as contas têm
            string titular;
            int n_conta, n_cartao;
            double saldo;

            if (op == 1)
            {
                Console.WriteLine("Insira o Nome Completo do Titular: ");
                titular = Console.ReadLine();
                Console.WriteLine("Insira o Número da Conta: ");
                n_conta = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Número do Cartão: ");
                n_cartao = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Saldo Disponível: ");
                saldo = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Conta_corrente_simples conta = new Conta_corrente_simples(titular, n_conta.ToString(), n_cartao.ToString(), 1200, new Cheque(1, 20));
            }

            conta.DevolveInfo();
        }
    }
}
