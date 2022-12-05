using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12º_exercise
{
    internal class Autocarro
    {
        int n_lugares;
        List<string> paragens; // index 0 = primeira paragem, etc...

        public Autocarro(int n_lugares, List<string> paragens) 
        {
            this.n_lugares = n_lugares;
            this.paragens = paragens;
        }

        // Encapsulamento

        public int get_n_lugares() { return n_lugares; }

        public string get_paragem(int index) { return paragens[index]; }
    }
}
