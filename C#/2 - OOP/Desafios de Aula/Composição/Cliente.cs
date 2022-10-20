using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composição
{
    internal class Cliente
    {
        private string nome, email;

        //Relação Composição. O cliente tem uma morada
        Morada m1 = new Morada("Rua x","2","Viseu","3510-070");

        public Cliente() 
        {
            nome = "Sem nome atribuido";
            email = "Sem email atribuido";
        }

        public Cliente(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public string DevolveNome()
        {
            return nome;
        }

        public string DevolveEmail()
        {
            return email;
        }

        public void DelvolveLocalidade()
        {
            Console.WriteLine(m1.DevolveLocalidade());
        }

        public void AlteraNome(string nome)
        {
            this.nome = nome;
        }

        public void AlteraEmail(string email)
        {
            this.email = email;
        }
    }
}
