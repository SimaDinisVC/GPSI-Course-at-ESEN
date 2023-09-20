using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalClinic
{
    [Serializable]
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
        }     

        public string CodigoPostal 
        { 
            get { return codigo_postal; }
            set 
            {
                if (IsValidCodigoPostal(value.Trim()))
                {
                    codigo_postal = value.Trim();
                    localidade = ObterLocalidade(value.Trim());
                }
            }
        }

        public static bool IsValidCodigoPostal(string cp) // Verificação do Código-Postal via Regex
        {
            string pattern = @"^\d{4}-\d{3}$";
            bool regexresult = Regex.IsMatch(cp, pattern);
            if (regexresult)
            {
                string localidade = ObterLocalidade(cp);
                if (localidade == string.Empty)
                    return false;
            }
            return regexresult;
        }

        public static string ObterLocalidade(string codigoPostal)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string apiUrl = $"https://www.cttcodigopostal.pt/api/v1/4f493beaea324c2887ba33821ebe5cad/{codigoPostal}";

                try
                {
                    HttpResponseMessage response = httpClient.GetAsync(apiUrl).Result;
                    response.EnsureSuccessStatusCode(); // se o código for 200 request OK, se for 404 ele dá catch

                    string jsonResponse = response.Content.ReadAsStringAsync().Result;
                    if (jsonResponse == "[]")
                        return string.Empty;

                    string localidade = jsonResponse.Split(':')[5].Split(',')[0].Trim('"');
                    string distrito = jsonResponse.Split(':')[6].Split(',')[0].Trim('"');

                    if (localidade != distrito)
                        localidade = localidade + ", " + distrito;

                    return localidade;
                }
                catch (HttpRequestException)
                {
                    return string.Empty;
                }
            }
        }
    }
}
