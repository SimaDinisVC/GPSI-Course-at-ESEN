using System;

namespace _6º_exercise
{
    internal class Conta_corrente_especial : Conta_corrente_simples
    {
        double limite, taxa;

        public Conta_corrente_especial(string titular, string n_conta, string n_cartao,double saldo, int primeiro_n, int ultimo_n, Cheque c1, double limite, double taxa) : base(titular, n_conta, n_cartao, saldo, c1)
        {
            this.limite = limite;
            this.taxa = taxa;
        }
    }
}