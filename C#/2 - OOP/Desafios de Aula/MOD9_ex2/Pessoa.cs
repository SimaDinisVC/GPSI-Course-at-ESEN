using System;

namespace MOD9_ex2
{
    class Pessoa
    {
        // Atributos
        
        public string nome, data_nasc;
        public double altura;

        // Construtor
        
        public Pessoa()
        {
            nome = "";
            data_nasc = "";
            altura = 0;
        }

        public Pessoa(string nome, string data_nasc, double altura)
        {
            this.nome = nome;
            this.data_nasc = data_nasc;
            this.altura = altura;
        }
    }
}
