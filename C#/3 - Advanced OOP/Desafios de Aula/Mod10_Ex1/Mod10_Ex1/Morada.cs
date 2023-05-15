using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mod10_Ex1
{
    public class Morada
    {
     
        public string Localidade { get; set; }

        public string Rua { get; set; }


        private string cod_postal;
        public string Codigo_Postal { 
            get { return cod_postal; }
            set {
                if (ValidarCodigoPostal(value))
                    cod_postal = value;
                else
                    cod_postal = "0000-000";
            } }

        //Construtor padrão

        public Morada()
        {
            Rua = "";
            Codigo_Postal = "0000-000";
            Localidade = "";
        }

        public Morada(string _Codpostal):this()
        {
            Codigo_Postal = _Codpostal;
        }

        public Morada(string _Rua, string _Codpostal,string _Localidade):this(_Codpostal)
        {
            Rua = _Rua;
            Codigo_Postal = _Codpostal;
            Localidade = _Localidade;
        }


           public bool ValidarCodigoPostal(string x)
        {
            string y = "^[0-9]{4}-[0-9]{3}$";
            bool r = Regex.IsMatch(x, y);
            return r;
        }
    }
}
