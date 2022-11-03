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
        private bool flag_iniciado = false; // Para verificar se o elevador está iniado

        public Elevador(){} // Construtor Vazio

        public void Iniciar(int n_andares, int capacidade_max)
        {
            if (capacidade_max > 0 && n_andares > 0) // Proteção
            {
                this.n_andares = n_andares;
                this.capacidade_max = capacidade_max;
                piso = 0; // inicia a contagem de pisos
                capacidade_atual = 0; // inicia contagem de pessoas dentro de elevador
                flag_iniciado = true;
            }
            else
            {
                Console.Error.WriteLine("ERRO: Os valores não podem ser <= 0.");
                Environment.Exit(0); // Sai do Programa
            }
        }

        public void Entrar()
        {
            if (flag_iniciado)
            {
                if (capacidade_atual < capacidade_max)
                {
                    capacidade_atual++;
                    Console.WriteLine("{0} / {1} pessoas",capacidade_atual,capacidade_max);
                }
                else
                    Console.WriteLine("Capacidade máxima atingida! Pedimos desculpa mas terá de ir pelas escadas.");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Sair()
        {
            if (flag_iniciado)
            {
                if (capacidade_atual > 0)
                {
                    capacidade_atual--;
                    Console.WriteLine("{0} / {1} pessoas", capacidade_atual, capacidade_max);
                }
                else
                    Console.WriteLine("Não existe ninguém no elevador!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Subir()
        {
            if (flag_iniciado)
            {
                if (piso < n_andares)
                { 
                    capacidade_atual++;
                    Console.WriteLine("{0} / {1} andar", piso, n_andares);
                }
                else
                    Console.WriteLine("Já se encontra no último andar!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }

        public void Descer()
        {
            if (flag_iniciado)
            {
                if (piso > 0)
                {
                    capacidade_atual--;
                    Console.WriteLine("{0} / {1} andar", piso, n_andares);
                }
                else
                    Console.WriteLine("Já se encontra no andar térreo!");
            }
            else
                Console.Error.WriteLine("ERRO: O elevador ainda não foi iniciado.");
        }
    }
}
