using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    [Serializable]
    public class Animal
    {
        // Campos
        public static int autoID;
        private readonly int id;
        private string nome, tipo, raca, detalhes;
        private int idade;
        private DateTime data_nasc;
        public Cliente dono;

        public Animal(Cliente dono) // Construtor Padrão
        {
            this.id = ++autoID;
            Nome = "(Por defenir)";
            this.tipo = "(Por defenir)";
            this.raca = "(Por defenir)";
            this.detalhes = "(Sem Informação)";
            this.idade = -1;
            Data_Nasc = new DateTime();
            this.dono = dono;
            if (!dono.Animais.Contains(this)) // Caso a lista do dono não contenha este animal é adicionado
                dono.Animais.Add(this);
        }

        public Animal(Cliente dono, string tipo, string nome, string raca, string detalhes, DateTime data_nasc) : this(dono) // Construtor Completo
        {
            this.tipo = tipo;
            Nome = nome;
            this.raca = raca;
            this.detalhes = detalhes;
            Data_Nasc = data_nasc;
        }

        public static void DesicrementaAutoID() // É usado quando são criados objetos testes que não são
        {                                       // adicionados á binding list e são removidos pelo garbage colector
            autoID--;
        }

        public int ID 
        { 
            get { return id; }
        }

        public string Tipo 
        { 
            get { return tipo; }
            set { tipo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set 
            { 
                if (value != "")
                    nome = value.Trim(); 
            }
        }

        public int Idade
        {
            get { return idade; }
        }

        public string Raca 
        { 
            get { return raca; } 
            set 
            { 
                if (value.Trim() != "")
                    raca = value.Trim(); 
            }
        }

        public DateTime Data_Nasc
        {
            get { return data_nasc; }
            set
            {
                if (value.Year > 1900)
                {
                    data_nasc = value;
                    idade = Pessoa.GetIdade(data_nasc);
                }
            }
        }

        public string Dono_Nome 
        { 
            get { return dono.Nome; }
        }

        public string Detalhes 
        {
            get { return detalhes; }
            set 
            { 
                if (value.Trim() != "")
                    detalhes = value.Trim(); 
            }
        }
    }
}
