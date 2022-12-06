using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N22
{
    internal class Pessoa
    {
        private string nome;
        private Morada morada;
        private int telefone;

        public Pessoa() // Construtor Vazio
        {}

        public Pessoa(string nome, Morada morada, int telefone) // Construtor
        {
            this.nome = nome;
            this.morada = morada;
            this.telefone = telefone;
        }

        // Métodos para Alterar e Encapsulamento

        public void AlteraNome(string nome)
        {
            this.nome = nome;
        }

        public void AlteraMorada(Morada morada)
        {
            this.morada = morada;
        }

        public void AlteraTelefone(int telefone)
        {
            this.telefone = telefone;
        }

        public string RetornaNome()
        {
            return nome;
        }

        public string RetornaMorada()
        {
            return morada.RetornaDados();
        }

        public int RetornaTelefone()
        {
            return telefone;
        }
        
        // Fim do Encapsulamento

        public virtual string RetornaDados()
        {
            return "Nome: "+ nome + ", " + morada.RetornaDados() + "Telefone: " + telefone;
        }
    }
}
