using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace FicheirosBinarios
{
    [Serializable]
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
