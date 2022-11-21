using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8º_exercise
{
    internal class Bebida
    {
        string nome;
        int teor_alcoolico;
        double valor;

        public Bebida(string nome, int teor_alcoolico, double valor)
        {
            this.nome = nome;
            this.teor_alcoolico = teor_alcoolico;
            this.valor = valor;
        }
    }
}
