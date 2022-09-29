using System;

namespace MOD9_ex4
{
    internal class Empresa
    {
        private double salario_total = 0;
        private int funcionarios = 0 ;
        private double maior_salario;
        private string funcionarioBemPAGO;

        public Empresa()
        { }

        public void NovoEmpregado(string nome, double salario)
        {
            this.salario_total += salario;
            this.funcionarios += 1;
            if (salario > this.maior_salario)
            {
                this.maior_salario = salario;
                this.funcionarioBemPAGO = nome;
            }
        }

        public void Medio()
        {
            Console.WriteLine("Salario Médio: " + (this.salario_total / this.funcionarios));
        }

        public void maiorSalario()
        {
            Console.WriteLine("O funcionário com maior salário é "+this.funcionarioBemPAGO+" a receber "+this.maior_salario+"€");
        }
    }
}
