using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    [Serializable]
    public class Consulta
    {
        // Campos
        private Animal animal;
        private Medico medico;
        private DateTime dataeHora;
        private string relatorioFinal;

        public Consulta(Animal animal, Medico medico, DateTime dataeHora) // Construtor Exclusivo
        {
            this.animal = animal;
            this.medico = medico;
            this.dataeHora = dataeHora;
            this.relatorioFinal = "(Sem Informação)";
        }

        public Animal Animal 
        { 
            get { return animal; }
            set 
            { 
                if (value != null)
                    animal = value;
            }
        }

        public DateTime DataeHora
        {
            get { return dataeHora; }
            set { dataeHora = value; }
        }

        public string NomeMedico { get { return medico.Nome; } }

        public int IDAnimal { get { return animal.ID; } }

        public string NomeAnimal { get { return animal.Nome; } }

        public string NomeDono { get { return animal.dono.Nome; } }

        public string NICDono { get { return animal.dono.NIC; } }

        public string Detalhes
        {
            get { return relatorioFinal; }
            set 
            { 
                if (value.Trim() != "")
                    relatorioFinal = value;
            }
        }
    }
}
