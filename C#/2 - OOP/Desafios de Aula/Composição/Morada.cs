using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composição
{
    internal class Morada
    {
        private string rua, n, localidade, codigo_postal;

        public Morada()
        {
            rua = "Sem rua atribuida";
            n = "Sem n atribuido";
            localidade = "Sem localidade atribuida";
            codigo_postal = "Sem código postal atribuido";
        }

        public Morada(string rua, string n, string localidade, string codigo_postal)
        {
            this.rua = rua;
            this.n = n;
            this.localidade = localidade;
            this.codigo_postal = codigo_postal;
        }

        public string DevolveRua()
        {
            return rua;
        }

        public string DevolveNumero()
        {
            return n;
        }

        public string DevolveLocalidade()
        {
            return localidade;
        }

        public string DevolveCodigoPostal()
        {
            return codigo_postal;
        }

        public void AlteraRua(string rua)
        {
            this.rua = rua;
        }

        public void AlteraNumero(string n)
        {
            this.n = n;
        }

        public void AlteraLocalidade(string localidade)
        {
            this.localidade = localidade;
        }

        public void AlteraCodigoPostal(string codigo_postal)
        {
            this.codigo_postal = codigo_postal;
        }
    }
}
