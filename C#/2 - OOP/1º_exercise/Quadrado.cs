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
            this.lado = lado;
        }

        public double area() // Area
        {
            double area = 2 * lado;
            return area;
        }

        public double diagonal() // Diagonal
        {
            double diagonal = Math.Sqrt(2 * lado);
            return diagonal;
        }

        public double perimetro() // Perimetro
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
    }
}
