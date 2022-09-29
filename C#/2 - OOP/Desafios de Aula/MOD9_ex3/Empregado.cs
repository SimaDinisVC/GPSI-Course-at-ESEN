using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD9_ex3
{
    internal class Empregado
    {
        private string nome;
        private int idade;

        public Empregado()
        { }

        public Empregado(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public void MostraDados()
        {
            Console.WriteLine("Nome: "+nome+"\nIdade: "+idade);
        }
    }
}
