using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N22
{
    internal class Morada
    {
        private string rua, localidade, codigo_postal;

        public Morada() // Construtor Vazio
        { }

        public Morada(string rua, string localidade, string codigo_postal) // Construtor
        {
            this.rua = rua;
            this.localidade = localidade;
            this.codigo_postal = codigo_postal;
        }

        public void AlteraRua(string rua)
        {
            this.rua = rua;
        }

        public void AlteraLocalidade(string localidade)
        {
            this.localidade = localidade;
        }

        public void AlteraCodigoPostal(string codigo_postal)
        {
            this.codigo_postal = codigo_postal;
        }

        public string RetornaRua()
        {
            return rua;
        }

        public string RetornaLocalidade()
        {
            return localidade;
        }

        public string RetornaCodigoPostal()
        {
            return codigo_postal;
        }

        // Fim do Encapsulamento

        public virtual string RetornaDados()
        {
            return "Morada: "+ rua + ", " + codigo_postal + " " + localidade;
        }
    }
}