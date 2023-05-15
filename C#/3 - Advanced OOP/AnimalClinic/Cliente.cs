using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    public class Cliente : Pessoa
    {
        // Campos
        private List<Animal> animais;

        public static event EventHandler ListaAlterada;

        public Cliente(string NIC, List<Animal> animais) : base(NIC) 
        {
            Animais = animais;
        }

        public Cliente(string nome, string email, string telefone, string nic, DateTime data_nasc, Morada morada, List<Animal> animais) : base(nome, email, telefone, nic, data_nasc, morada)
        {
            Animais = animais;
        }

        public List<Animal> Animais 
        {
            get { return animais; } 
            set { animais = value; }
        }
    }
}
