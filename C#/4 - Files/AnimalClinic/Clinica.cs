using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        public static BindingList<Animal> animallist = new BindingList<Animal>();

        public static BindingList<Medico> medicolist = new BindingList<Medico>();

        public static BindingList<Rececionista> rececionistalist = new BindingList<Rececionista>();

        public static BindingList<Consulta> consultalist = new BindingList<Consulta>();

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
        static Clinica()
        {
            if (File.Exists(@"./animalist.dat"))
            {
                BindingList<Animal> animais = new BindingList<Animal>();

                using (FileStream fileStream = new FileStream(@"./animalist.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    while (fileStream.Position < fileStream.Length)
                    {
                        Animal animal = (Animal)formatter.Deserialize(fileStream);
                        animais.Add(animal);
                        Animal.autoID += 1;
                    }
                }

                animallist = animais;
            }

            if (File.Exists(@"./consultalist.dat"))
            {
                BindingList<Consulta> consultas = new BindingList<Consulta>();

                using (FileStream fileStream = new FileStream(@"./consultalist.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    while (fileStream.Position < fileStream.Length)
                    {
                        Consulta consulta = (Consulta)formatter.Deserialize(fileStream);
                        consultas.Add(consulta);
                    }
                }

                consultalist = consultas;
            }

            if (File.Exists(@"./medicolist.dat"))
            {
                BindingList<Medico> medicos = new BindingList<Medico>();

                using (FileStream fileStream = new FileStream(@"./medicolist.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    while (fileStream.Position < fileStream.Length)
                    {
                        Medico medico = (Medico)formatter.Deserialize(fileStream);
                        medico.RestabelecerLigacaoEvento();
                        medicos.Add(medico);
                    }
                }
                medicolist = medicos;
                ListaAlterada.Invoke(null, EventArgs.Empty);
            }

            if (File.Exists(@"./rececionistalist.dat"))
            {
                BindingList<Rececionista> rececionistas = new BindingList<Rececionista>();

                using (FileStream fileStream = new FileStream(@"./rececionistalist.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    while (fileStream.Position < fileStream.Length)
                    {
                        Rececionista rececionista = (Rececionista)formatter.Deserialize(fileStream);
                        rececionistas.Add(rececionista);
                    }
                }

                rececionistalist = rececionistas;
            }

            if (File.Exists(@"./NIClist.dat"))
            {
                List<string> nics = new List<string>();

                using (FileStream fileStream = new FileStream(@"./NIClist.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    while (fileStream.Position < fileStream.Length)
                    {
                        string nic = (string)formatter.Deserialize(fileStream);
                        nics.Add(nic);
                    }
                }

                Pessoa.NICs = nics;
            }
        }

        public static void UpdateAnimalistFiles()
        {
            using (FileStream fileStream = new FileStream(@"./animalist.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                foreach (Animal a in animallist)
                {
                    formatter.Serialize(fileStream, a);
                }
            }
        }

        public static void UpdateMedicolistFiles()
        {
            using (FileStream fileStream = new FileStream(@"./medicolist.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                foreach (Medico m in medicolist)
                {
                    formatter.Serialize(fileStream, m);
                }
            }
        }

        public static void UpdateConsultalistFiles()
        {
            using (FileStream fileStream = new FileStream(@"./consultalist.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                foreach (Consulta c in consultalist)
                {
                    formatter.Serialize(fileStream, c);
                }
            }
        }

        public static void UpdateRececionistalistFiles()
        {
            using (FileStream fileStream = new FileStream(@"./rececionistalist.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                foreach (Rececionista r in rececionistalist)
                {
                    formatter.Serialize(fileStream, r);
                }
            }
        }

        public static void UpdateNIClistFiles()
        {
            using (FileStream fileStream = new FileStream(@"./NIClist.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                foreach (string s in Pessoa.NICs)
                {
                    formatter.Serialize(fileStream, s);
                }
            }
        }

        public static void UpdateAllFiles()
        {
            UpdateAnimalistFiles();
            UpdateMedicolistFiles();
            UpdateConsultalistFiles();
            UpdateRececionistalistFiles();
            UpdateNIClistFiles();
        }
    }
}