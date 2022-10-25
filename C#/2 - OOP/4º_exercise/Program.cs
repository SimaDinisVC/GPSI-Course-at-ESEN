using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador e1 = new Elevador();

            e1.Entrar();
            e1.Iniciar(5, 10);
            e1.Entrar();
            e1.Subir();
            e1.Sair();
        }
    }
}
