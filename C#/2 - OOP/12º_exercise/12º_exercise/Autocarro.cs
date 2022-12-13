using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12º_exercise
{
    internal class Autocarro
    {
        List<string> paragens; // index 0 = primeira paragem, etc...
        int n_lugares, i_paragem_atual;
        

        public Autocarro(int n_lugares, List<string> paragens) 
        {
            this.n_lugares = n_lugares;
            this.paragens = paragens;
            i_paragem_atual = 0; // vamos tratar o atributo em função de index's
        }

        // Encapsulamento

        public int get_n_lugares() { return n_lugares; }

        // Métodos

        public string get_paragem_atual() { return paragens[i_paragem_atual]; }
        // Devolve a paragem com base no nº da paragem em relação ao trajeto

        public void ProximaParagem() { i_paragem_atual++; }
    }
}
