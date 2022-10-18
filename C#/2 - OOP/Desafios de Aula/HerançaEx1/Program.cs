using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("João","jj2006@gmail.com");
            
            c1.DelvolveLocalidade();
        }
    }
}
