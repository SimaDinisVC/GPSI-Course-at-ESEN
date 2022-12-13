using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12º_exercise
{
    internal class Passageiro
    {
        string origem, destino;

        public Passageiro(string origem, string destino)
        {
            this.origem = origem;
            this.destino = destino;
        }

        // Encapsulamento

        public string get_origem() { return origem; }

        public string get_destino() { return destino; }
    }
}
