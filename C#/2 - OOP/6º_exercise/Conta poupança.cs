using System;

namespace _6º_exercise
{
    internal class Conta_poupança : Conta_corrente_simples
    {
        DateTime data = new DateTime(2002, 10, 18);

        public Conta_poupança(string titular, string n_conta, string n_cartao, double saldo, int primeiro_n, int ultimo_n, Cheque c1, DateTime data) : base(titular, n_conta, n_cartao, saldo, c1)
        {
            this.data = data;
        }
    }
}