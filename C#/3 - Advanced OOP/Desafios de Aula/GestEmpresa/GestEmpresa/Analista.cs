using System;

namespace GestEmpresa
{
    class Analista : Empregado
    {
        public string Projeto { get; set; }

        public Analista() : base()
        {
            Projeto = "Por definir";
        }

        public Analista(string _nome) : base(_nome)
        {
            Projeto = "Por definir";
        }

        public Analista(string _nome, DateTime _dataNasc, string _email, string _telefone, Morada _morada, string _projeto) : base(_nome, _dataNasc, _email, _telefone, _morada)
        {
            Projeto = _projeto;
        }

        public override string getCargo()
        {
            return "Analista";
        }
    }
}
