using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    [Serializable]
    public class Medico : Pessoa
    {
        // Campos
        private string password;
        private BindingList<Consulta> consultas = new BindingList<Consulta>();
        private List<string> especialidades; // Tipos de Animais aceites pelo médico
        
        public Medico(string NIC, List<string> especialidades) : base(NIC)
        {
            Especialidades = especialidades;
            Clinica.ListaAlterada += MeuManipuladorDeEventos;
        }

        public Medico(string nome, string email, string telefone, string NIC, DateTime data_nasc, Morada morada, List<string> especialidades) : base(nome, email, telefone, NIC, data_nasc, morada)
        {
            Especialidades = especialidades;
            Clinica.ListaAlterada += MeuManipuladorDeEventos;
        }

        public List<string> Especialidades 
        {
            get { return especialidades; }
            set
            {
                especialidades = value;
                Clinica.tiposAnimais = Clinica.tiposAnimais.Union(value, StringComparer.OrdinalIgnoreCase).ToList(); // Atualiza os tipos de animais aceites pela clinica
            }
        }

        public void MeuManipuladorDeEventos(object sender, EventArgs e) // Para quando é removido um funcionário que tem as mesmas espcialiadades que as do objeto em causa
        {
            Clinica.tiposAnimais = Clinica.tiposAnimais.Union(especialidades, StringComparer.OrdinalIgnoreCase).ToList();
        }

        public void RestabelecerLigacaoEvento()
        {
            Clinica.ListaAlterada += MeuManipuladorDeEventos;
        }

        public BindingList<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
