using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Projeto_Empresa
{
    internal class Morada
    {
        public bool ValidarCodigo(string x)
        {
            string y = "^[0-9]{4}-[0-9]{3}$";
            bool r = Regex.IsMatch(x, y);
            return r;
        }
        public string Localidade { get; set; }
        public string Rua { get; set; }
        public string Codigo_Postal { get; set; }
    }
}
