using System;

namespace GestEmpresa
{
    class Programador : Empregado
    {
        public string Especialidade { get; set; }

        public Programador() : base()
        {
            Especialidade = "Por identificar";
        }

        public Programador(string _nome) : base(_nome)
        {
            Especialidade = "Por identificar";
        }

        public Programador(string _nome, DateTime _dataNasc, string _email, string _telefone, Morada _morada, string _especialidade) : base(_nome, _dataNasc, _email, _telefone, _morada)
        {
            Especialidade = _especialidade;
        }

        public override string getCargo()
        {
            return "Programador";
        }
    }
}
