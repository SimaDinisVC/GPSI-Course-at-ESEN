using System;

namespace _2º_exercise
{
    class Jogadores
    {
        string nome, posicao, nacionalidade, nascimento;
        double altura, peso;

        public Jogadores()
        { }

        public Jogadores(string nome, string posicao, string nacionalidade, string nascimento, double altura, double peso)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
            this.nacionalidade = nacionalidade;
            this.posicao = posicao;
            this.nascimento = nascimento;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} mede {1}cm, nascido a {2} de nacionalidade {3} pensando {4}kg de posição {5}.", nome, altura, nascimento, nacionalidade, peso, posicao);
        }

        public int Idade()
        {
            string[] Lista_Nascimento = nascimento.Split('/');

            int ThisYear = DateTime.Now.Year;
            int ThisMonth = DateTime.Now.Month;
            int ThisDay = DateTime.Now.Day;

            int idade = ThisYear - int.Parse(Lista_Nascimento[2]);

            if (int.Parse(Lista_Nascimento[1]) == ThisMonth)
            {
                if (int.Parse(Lista_Nascimento[0]) >= ThisDay)
                {
                    idade++;
                }
            }

            return idade;
        }

        public void Aposentar()
        {
            if (posicao == "defesa")
            {
                if (Idade() < 40)
                {
                    Console.WriteLine("O {0} tem ainda {1} ano(s) de carreira até se aposentar.", nome, (40-Idade()));
                }
                else
                {
                    Console.WriteLine("O {0} já deve estar aposentado!!!", nome);
                }
            }
            else if (posicao == "meio-campo")
            {
                if (Idade() < 38)
                {
                    Console.WriteLine("O {0} tem ainda {1} ano(s) de carreira até se aposentar.", nome, (38 - Idade()));
                }
                else
                {
                    Console.WriteLine("O {0} já deve estar aposentado!!!", nome);
                }
            }
            else if (posicao == "atacante")
            {
                if (Idade() < 35)
                {
                    Console.WriteLine("O {0} tem ainda {1} ano(s) de carreira até se aposentar.", nome, (35 - Idade()));
                }
                else
                {
                    Console.WriteLine("O {0} já deve estar aposentado!!!", nome);
                }
            }
            else
            {
                Console.WriteLine("A posição do Jogador tem de estar compreendida entre 'defesa', 'meio-campo' e 'atacante'.");
            }
        }
    }
}