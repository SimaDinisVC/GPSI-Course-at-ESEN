using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12º_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Passageiro> passageiros = new List<Passageiro>() // Lisboa, Coimbra, Aveiro, Porto e Braga.
            {
                new Passageiro("Viseu", "Coimbra"),
                new Passageiro("Aveiro", "Viseu"),
                new Passageiro("Braga", "Viseu"),
                new Passageiro("Viseu", "Porto"),
                new Passageiro("Lisboa", "Porto"),
                new Passageiro("Lisboa", "Porto"),
                new Passageiro("Lisboa", "Porto"),
                new Passageiro("Braga", "Lisboa"),
                new Passageiro("Viseu", "Lisboa"),
                new Passageiro("Lisboa", "Coimbra")
            };
        }
    }
}
