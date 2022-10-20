using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Veiculo
    {
        // propriedades
        int velMax, rodas;
        bool ligado;

        //Construtor
        public Veiculo()
        {}

        public Veiculo(int velMax, int rodas, bool ligado)
        {
            this.velMax = 120;
            this.rodas = rodas;
            this.ligado = false;
        }

        //métodos

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false; 
        }

        public int Rodas()
        {
            return rodas;
        }

        public string getLigado()
        {
            /*if (ligado) return "sim";

            else return "não";*/

            // OU

            // operador ternário
            return (ligado ? "sim" : "não");
        }
    }
}
