using System.Text.RegularExpressions;

namespace GestEmpresa
{
    public class Morada
    {
        public string Rua { get; set; }
        public string Localidade { get; set; }

        private string codPostal;
        public string CodPostal {
            get { return codPostal; }
            set { if (IsValidCodigoPostal(value))
                    codPostal = value;
                else
                    codPostal = "0000-000";
            }
        }

        public Morada()
        {
            Rua = "";
            CodPostal = "0000-000";
            Localidade = "";
        }

        public Morada(string _CodPostal): this()
        {
            CodPostal = _CodPostal;
        }

        public Morada(string _Rua, string _CodPostal, string _Localidade): this(_CodPostal)
        {
            Rua = _Rua;
            Localidade = _Localidade;
        }

        // https://regex101.com/
        // https://regexr.com/
        // http://regexstorm.net/
        public static bool IsValidCodigoPostal(string CodigoPostal)
        {
            string pattern = @"^\d{4}-\d{3}$";

            return Regex.IsMatch(CodigoPostal, pattern);
        }

        public override string ToString()
        {
            return Rua + "\n" + CodPostal + " " + Localidade;
        }
    }


}
