using System;

namespace MOD9_ex1
{
    class Caixa
    {
        // Caracteristicas ou atributos

        double lado;
        string cor;

        // Construtor

        public Caixa()
        {

        }

        // Comportamento

        public double volume(double lado)
        {
            return lado * lado * lado;
        }
    }
}
