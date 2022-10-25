using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4º_exercise
{
    internal class Elevador
    {
        private int piso, n_andares, capacidade_max, capacidade_atual;
        private bool iniciado = false; // Para verificar se o elevador está iniado

        public Elevador(){} // Construtor Vazio

        public void Iniciar(int n_andares, int capacidade_max)
        {
            if (capacidade_max > 0 && n_andares > 0) // Proteção
            {
                this.n_andares = n_andares;
                this.capacidade_max = capacidade_max;
                piso = 0; // inicia a contagem de pisos
                capacidade_atual = 0; // inicia contagem de pessoas dentro de elevador
                iniciado = true;
            }
            else
            {
                Console.Error.WriteLine("ERRO: Os valores não podem ser <= 0.");
                System.Environment.Exit(0); // Sai do Programa
            }
        }

        public void Entrar()
        {
            if (iniciado)
            {
                if (capacidade_atual < capacidade_max)
                    capacidade_atual++;
                else
                    Console.WriteLine("Capacidade máxima atingida! Pedimos desculpa mas terá de ir pelas escadas.");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Sair()
        {
            if (iniciado)
            {
                if (capacidade_atual > 0)
                    capacidade_atual--;
                else
                    Console.WriteLine("Não existe ninguém no elevador!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Subir()
        {
            if (iniciado)
            {
                if (piso < n_andares)
                    capacidade_atual++;
                else
                    Console.WriteLine("Já se encontra no último andar!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Descer()
        {
            if (iniciado)
            {
                if (piso > 0)
                    capacidade_atual--;
                else
                    Console.WriteLine("Já se encontra no andar térreo!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }
    }
}
