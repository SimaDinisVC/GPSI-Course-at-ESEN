using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9º_exercise
{
    internal class Balao
    {
        private bool acendido;
        private string cor;
        private char direcao; // direcao == N (Norte) || S (Sul) || E (Este) || O (Oeste)
        private double altura;

        public Balao() // Construtor Vazio
        {
            acendido = false;
            altura = 0;
        }
        
        public Balao(bool acendido, string cor, char direcao, double altura) // Construtor Padrão
        {
            this.acendido = acendido;
            this.cor = cor;
            this.direcao = direcao;
            this.altura = altura;
            if (altura > 0)
                this.acendido = true;
        }
        
        // Encapsulamento

        public bool getAcendido() { return acendido; }

        public string getCor() { return cor; }

        public char getDirecao() { return direcao; }

        public double getAltura() { return altura; }

        // Alterações de propriedades

        public void modifyAcendido(bool acendido) 
        { 
            if (altura > 0)
                this.acendido = true;
            else
                this.acendido = acendido;
        }

        public void modifyCor(string cor) { this.cor = cor; }

        public void modifyDirecao(char direcao) {this.direcao = direcao;}

        public void modifyAltura(double altura) 
        {
            this.altura = altura;
            if (altura > 0)
                acendido = true;
        }

        public void getStatus() // Método Global
        {
            Console.WriteLine("STATUS:\n");
            Console.WriteLine(" Acendido: " + acendido);
            Console.WriteLine(" Cor: " + cor);
            Console.WriteLine(" Direção: " + direcao);
            Console.WriteLine(" Altura: " + altura);
        }
    }
}
