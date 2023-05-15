using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading.Tasks;

namespace AnimalClinic
{
    static class Clinica
    {
        // Configurações
        public static string appname = "AnimalClinic®";
        public static string appversion = "v1.0 Beta";

        // Lista de tipos animais aceites pela clínica (Conforme Especialidades dos Médicos);
        public static List<string> tiposAnimais = new List<string>();
        public static event EventHandler ListaAlterada; // Cria um evento para que quando esta lista for alterada,
                                                        // todos os objetos Medico apliquem as suas especialidades
                                                        // visto que pode acontecer removermos especialidades comuns a dois médicos
        public static List<string> TiposAnimais 
        {
            get { return tiposAnimais; }
            set 
            { 
                tiposAnimais = value;
                ListaAlterada?.Invoke(null, EventArgs.Empty); // Envoca o evento...
            }
        }

        public static BindingList<Animal> animallist = new BindingList<Animal>() { 
            new Animal(new Cliente("Simão Costa", "simadinisvc@gmail.com", "963656262", "25600641", new DateTime(2006,02,26), new Morada("Av. Infante D. Henrique", "Viseu", "3510-070"), new List<Animal>()), "Gato", "Guga Brinca Costa", "ciamês", "cauda longa\nbebe pouca água\nvomita pelo\ncauda longa\nbebe pouca água\nvomita pelo", new DateTime(2016,1,1)),
            new Animal(new Cliente("Juliana Costa", "julianacosta@gmail.com", "967837343", "87654321", new DateTime(2006,02,26), new Morada("Av. Infante D. Henrique", "Viseu", "3510-070"), new List<Animal>()), "Gato", "Guga Costa", "ciamês", "cauda longa\nbebe pouca água\nvomita pelo", new DateTime(2016,1,1)),
            new Animal(new Cliente("Francisco Costa", "franciscosta@gmail.com", "962324792", "86754231", new DateTime(2006,02,26), new Morada("Av. Infante D. Henrique", "Viseu", "3510-070"), new List<Animal>()), "Gato", "Guga Brinca", "ciamês", "cauda longa\nbebe pouca água\nvomita pelo", new DateTime(2016,1,1))
        };

        public static BindingList<Medico> medicolist = new BindingList<Medico>()
        {
            new Medico("Carlos Almeida", "almeidacarlos@gmail.com", "961237613", "12345678", new DateTime(1980,01,01), new Morada("Rua do Alfinete", "Viseu", "3500-012"), new List<string>() { "Cão", "Gato", "Tartaruga", "Furão", "Cobra" } ),
            new Medico("Simão Costa", "simadinisvc@gmail.com", "963656262", "23987412", new DateTime(2006,02,06), new Morada("Av. Infante D. Henrique", "Viseu", "3510-070"), new List<string>() { "Cão" })
        };

        public static BindingList<Rececionista> rececionistalist = new BindingList<Rececionista>()
        {
            new Rececionista("13245768"),
            new Rececionista("Simão Costa", "simadinisvc@gmail.com", "963656262", "12346789", new DateTime(2006,02,06), new Morada("Av. Infante D. Henrique", "Viseu", "3510-070"))
        };

        public static BindingList<Consulta> consultalist = new BindingList<Consulta>()
        {
            new Consulta(animallist[0], medicolist[0], new DateTime(2023,04,14,16,30,0))
        };

        public static List<string> IDAnimais // Propriedade que permite visualizado os ID's ocupados 
        {
            get { return animallist.Select(e => e.ID.ToString()).ToList(); }
        }

        public static Animal ObterAnimalByID(int ID)
        {
            return Clinica.animallist.FirstOrDefault(anml => anml.ID == ID);
        }

        public static Medico ObterMedicobyNIC(string NIC)
        {
            return Clinica.medicolist.FirstOrDefault(mdc => mdc.NIC == NIC);
        }

        public static Rececionista ObterRececionistabtNIC(string NIC)
        {
            return Clinica.rececionistalist.FirstOrDefault(x => x.NIC == NIC);
        }

        // Construtor Static to Iniciate something
    }
}