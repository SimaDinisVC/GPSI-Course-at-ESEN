using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado[] trabalhadores = new Empregado[] {new Empregado("Simão"), new Empregado("Rafael"), new Patrao("Bento")};

            for (int i = 0; i < trabalhadores.Length; i++)
            {
                trabalhadores[i].MostraNome();
                trabalhadores[i].MostraFuncao();
            }
        }
    }
}
