using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheirosBinarios
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
