using System;

namespace _1º_exercise
{
    class Quadrado
    {
        private double lado;

        public Quadrado()
        {
            this.lado = 1.0;
        }

        public Quadrado(double lado)
        {
            if (lado >= 0.0 && lado <= 20.0)
            {
                this.lado = lado;
            }
            else
            {
                this.lado = 1.0; // Decidi colocar o valor do primerio construtor
            }
        }

        public double area()
        {
            double area = 2 * lado;
            return area;
        }

        public double diagonal()
        {
            double diagonal = Math.Sqrt(2 * lado);
            return diagonal;
        }

        public double perimetro()
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
    }
}
