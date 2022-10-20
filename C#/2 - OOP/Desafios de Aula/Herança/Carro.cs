using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    // classe derivada da class Veiculo
    internal class Carro : Veiculo // herda todas as propriedades da class pai (Veiculo)
    {
        // proriedades específicas desta classe
        string nome, cor;

        public Carro(string nome, string cor) : base(170, 5, false)
        {
            this.nome = nome;
            this.cor = cor;
        }
    }
}
