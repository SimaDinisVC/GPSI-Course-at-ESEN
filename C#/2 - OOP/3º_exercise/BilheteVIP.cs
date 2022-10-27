using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3º_exercise
{
    internal class BilheteVIP : Bilhete
    {
        double valorVIP;
        double valor_add;
        double valor_padrao;

        public BilheteVIP(double valor, double valor_add) : base(valor)
        {
            this.valor_add = valor_add;
            valor_padrao = valor;
            this.valorVIP = valor + valor_add; // Valor do Bilhete VIP
        }

        public double Valor() // Método que RETORNA o valor
        {
            return valorVIP;
        }

        public void Diferença()
        {
            Console.WriteLine("A diferença entre valores é de {0} euros.",(valor_padrao-valorVIP));
        }
    }
}
