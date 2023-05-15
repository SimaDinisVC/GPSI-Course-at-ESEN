using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_Ex1
{
    class Programador:Empregado
    {
        public string Especialidade { get; set; }

        public Programador():base()
        {
            Especialidade = "(sem especialidade)";
        }

        public Programador(string _nome):base(_nome)
        {
            Especialidade = "(sem especialidade)";
        }

        public Programador(string _nome, DateTime _data, string _email, string _telefone, Morada m, string e):base(_nome, _data, _email, _telefone, m)
        {
            Especialidade = e;
        }

        public override string getCargo()
        {
            return "Programador";
        }

    }
}
