using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N22
{
    internal class Atleta : Pessoa
    {
        double peso, altura;

        public Atleta() // Construtor Vazio
        { }

        public Atleta(string nome, Morada morada, int telefone, double peso, double altura) : base(nome, morada, telefone) // Construtor
        {
            this.peso = peso;
            this.altura = altura;
        }

        public void AlteraPeso(double peso)
        {
            this.peso = peso;
        }

        public void AlteraAltura(double altura)
        {
            this.altura = altura;
        }

        public double RetornaPeso() 
        {
            return peso; 
        }

        public double RetornaAltura()
        {
            return altura;
        }

        // Fim do Encapsulamento

        public override string RetornaDados()
        {
            return base.RetornaDados() + ", Peso: " + peso + ", Altura: " + altura;
        }

        public double DevolveIMC()
        {
            return Math.Round(peso / (altura * altura), 2);
        }

        public string ClassificarIMC()
        {
            if (DevolveIMC() < 20)
                return "Magreza";
            else if (DevolveIMC() >= 20 && DevolveIMC() <= 24.99)
                return "Normal";
            else if (DevolveIMC() >= 25 && DevolveIMC() <= 29.99)
                return "Excesso de Peso";
            else if (DevolveIMC() >= 30 && DevolveIMC() <= 35)
                return "Obesidade";
            else
                return "Grande Obesidade";
        }
    }
}
