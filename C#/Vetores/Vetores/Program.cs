using System;
using System.Linq;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOTAL_DIAS = 7; // Não altera o seu valor
            double[] temp = new double[TOTAL_DIAS]; // Vetor de Tamanho 7, new "tipo" inicializa o objeto.   
            double tempMin, tempMax, AmplitudeTerm;

            // repetir 7x
            // i++ é o mesmo que i += 1
            for (int i = 0; i < TOTAL_DIAS; i++)
            {
                Console.Write("Temperatura da {0}º semana:", i+1);
                double.TryParse(Console.ReadLine(), out temp[i]);

                Console.WriteLine(temp[i]);
            }

            tempMin = temp.Min(); // Min do vetor
            tempMax = temp.Max(); // Max do vetor
            AmplitudeTerm = tempMax - tempMin;

            Console.WriteLine("A temperatura Mínima {0}ºC, máxima {1}ºC, e Amplitude Térmica {2}ºC", tempMin, tempMax, AmplitudeTerm);

            Console.Write("Qualquer Tecla...");
            Console.ReadKey();
        }
    }
}
