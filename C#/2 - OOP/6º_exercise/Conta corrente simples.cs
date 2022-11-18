using System;

namespace _6º_exercise
{
    public class Conta_corrente_simples
    {
        string n_conta, n_cartao, titular;
        double saldo;

        Cheque c1;

        public Conta_corrente_simples(string titular, string n_conta, string n_cartao, double saldo, Cheque c1)
        {
            this.titular = titular;
            this.n_conta = n_conta;
            this.n_cartao = n_cartao;
            this.saldo = saldo;
            this.c1 = c1;
        }

        public void DevolveInfo()
        {
            Console.WriteLine("Número da conta: " + n_conta);
            Console.WriteLine("Número do cartão: " + n_cartao);
            Console.WriteLine("Nome do Titular: " + titular);
            Console.WriteLine("Saldo disponível: " + saldo);
            c1.DevolveInfo();
        }
    }
}
