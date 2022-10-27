using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Empregado
    {
        // atributos da classe
        string nome;

        public Empregado() // Construtor Padrão 
        { }

        public Empregado(string nome) // Construtor que recebe o nome
        {
            this.nome = nome;
        }

        public void MostraNome() // Método que mostra o nome
        {
            Console.Write("{0}, ", nome);
        }

        public virtual void MostraFuncao() // Método Virtual que pode ser reesrito na classe derivada
        {
            Console.WriteLine("Empregado");
        }
    }
}
