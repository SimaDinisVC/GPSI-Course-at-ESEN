using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalClinic
{
    public class Morada
    {   
        // Campos
        private string rua, localidade, codigo_postal;

        public Morada()
        {
            this.rua = "(Por defenir)";
            this.localidade = "(Por defenir)";
            this.codigo_postal = "(Por defenir)";
        }

        public Morada(string rua) : this()
        {
            Rua = rua;
        }

        public Morada(string rua, string localidade, string codigo_postal) : this(rua)
        {
            Localidade = localidade;
            CodigoPostal = codigo_postal;
        }

        public string Rua 
        { 
            get { return rua; } 
            set 
            { 
                if (value.Trim() != "")
                    rua = value.Trim(); 
            }
        }

        public string Localidade 
        { 
            get { return localidade; } 
            set { localidade = value.Trim().ToUpper(); }
        }     

        public string CodigoPostal 
        { 
            get { return codigo_postal; }
            set 
            {
                if (IsValidCodigoPostal(value.Trim()))
                    codigo_postal = value.Trim();
            }
        }

        public static bool IsValidCodigoPostal(string cp) // Verificação do Código-Postal via Regex
        {
            string pattern = @"^\d{4}-\d{3}$";
            return Regex.IsMatch(cp, pattern);
        }
    }
}
