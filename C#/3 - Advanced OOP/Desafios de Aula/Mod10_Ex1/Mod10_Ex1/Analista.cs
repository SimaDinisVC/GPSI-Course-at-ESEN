using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_Ex1
{
    internal class Analista:Empregado
    {
        public string Projeto { get; set; }

        public Analista() : base()
        {
            Projeto = "(sem projeto atribuído)";
        }

        public Analista(string _nome) : base(_nome)
        {
            Projeto = "(sem projeto atribuído)";
        }

        public Analista(string _nome, DateTime _data, string _email, string _telefone, Morada m, string p) : base(_nome, _data, _email, _telefone, m)
        {
            Projeto = p;
        }


        public override string getCargo()
        {
            return "Analista";
        }
    }
}
