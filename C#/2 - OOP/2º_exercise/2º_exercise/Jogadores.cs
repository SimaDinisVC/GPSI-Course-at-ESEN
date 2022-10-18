using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2º_exercise
{
    class Jogadores
    {
        string nome, posição, nacionalidade, nascimento;
        double altura, peso;

        public Jogadores()
        { }

        public Jogadores(string nome, string posição, string nacionalidade, string nascimento, double altura, double peso)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
            this.nacionalidade = nacionalidade;
            this.posição = posição;
            this.nascimento = nascimento;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} mede {1}cm, nascido a {2} de nacionalidade {3} pensando {4}kg de posição {5}.", nome, altura, dataNascimento, nacionalidade, peso, posicao);
        }
    }
}

/*
    * Crie uma classe para representar um jogador de futebol
    * atributos: nome, posição, data de  nascimento,  nacionalidade, altura  e  peso.
    * métodos  públicos  necessários para leituras e escritas ?, imprimir todos os dados do jogador, calcular  a  idade  do  jogador  
    * e mostrar  quanto  tempo  falta para  o  jogador  se  aposentar.  
    * Para  isso,  considere  que  os  jogadores  da  posição  de  defesa  se  aposentam em média
    * aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.
*/