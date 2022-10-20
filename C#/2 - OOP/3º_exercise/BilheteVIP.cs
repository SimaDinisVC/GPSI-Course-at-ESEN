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

        public BilheteVIP()
        {
            valorVIP = valor + 7; // Valor do Bilhete VIP
        }

        public double Valor() // Método que RETORNA o valor
        {
            return valorVIP;
        }
    }
}
