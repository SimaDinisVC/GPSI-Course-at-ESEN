using System;

namespace MOD9_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Caixa c1;

            c1 = new Caixa();
            Console.WriteLine(c1.volume(12));
            Console.ReadKey();
        }
    }
}
