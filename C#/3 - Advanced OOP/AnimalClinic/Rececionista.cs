using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    public class Rececionista : Pessoa
    {
        // Campos
        private string password;

        public Rececionista(string NIC) : base(NIC)
        {
        }

        public Rececionista(string nome, string email, string telefone, string NIC, DateTime data_nasc, Morada morada) : base(nome, email, telefone, NIC, data_nasc, morada)
        {
        }

        public string Password 
        {
            get { return password; } 
            set { password = value; }
        }
    }
}
