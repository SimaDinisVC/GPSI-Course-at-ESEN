using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3º_exercise
{
    internal class Bilhete
    {
        double valor;

        public Bilhete(double valor)
        {
            this.valor = valor; // Valor do Bilhete
        }

        public void ImprimirValor() // Método que IMPRIME o Valor
        {
            Console.WriteLine("O valor do Bilhete é {0} euros.", valor);
        }
    }
}
