using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalClinic
{
    public class Pessoa
    {
        // Campos
        public static List<string> NICs = new List<string>();
        protected string nome, email, telefone; // O status vai indicar a situação do pessoa na clinica
        protected int idade, nic /* Nº Indentificação Civil Obrigatório */;
        protected DateTime data_nasc;
        protected Morada morada;
        public bool status = false; // Ausente ou Disponível 

        public Pessoa(string NIC) // Construtor Padrão
        {
            this.nome = "(Por defenir)";
            this.email = "(Por defenir)";
            this.telefone = "(Por defenir)";
            this.Data_Nasc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.morada = new Morada();
            this.NIC = NIC;
            NICs.Add(NIC);
        }

        public Pessoa(string nome, string email, string telefone, string NIC, DateTime data_nasc, Morada morada) : this(NIC) // Construtor Completo
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Data_Nasc = data_nasc;
            Morada = morada;
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string NIC
        {
            get { return nic.ToString(); }
            set
            {
                if (IsValidNIC(value))
                    nic = int.Parse(value);
            }
        }

        public string Nome 
        { 
            get { return nome; } 
            set 
            { 
                if (value.Trim() != "")
                    nome = value.Trim(); 
            }
        }

        public string Email 
        {
            get { return email; }
            set 
            {
                if (IsValidEmail(value.Trim()))
                    email = value.Trim();
            } 
        }

        public string Telefone 
        { 
            get { return telefone; } 
            set 
            {
                if (IsValidTelefone(value.Trim()))
                    telefone = value.Trim();
            }
        }

        public int Idade 
        {
            get { return idade; }
        }

        public DateTime Data_Nasc 
        { 
            get { return data_nasc; }
            set
            {
                if (value.Year > 1900)
                {
                    data_nasc = value;
                    idade = GetIdade(data_nasc);
                }
            } 
        }

        public Morada Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public static bool IsValidNIC(string nic) // Verificação do NIC (Nº Indentificação Civil) via Regex
        {
            string pattern = @"^\d{8}$";
            return Regex.IsMatch(nic.ToString(), pattern);
        }

        public static bool IsValidEmail(string email) // Verificação do Email via Regex
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidTelefone(string telefone) // Verificação do Telefone via Regex
        {
            string pattern = @"^(\+?351)?\s*9\d{8}$";
            return Regex.IsMatch(telefone, pattern);
        }

        public static int GetIdade(DateTime data_nasc) // Calcula a idade
        {
            DateTime data_atual = DateTime.Today;

            // Calcular a idade subtraindo o ano de nascimento do ano atual
            int idade = data_atual.Year - data_nasc.Year;

            // Se a data atual for anterior ao dia do aniversário do ano corrente, subtrair um ano da idade
            if (data_atual < data_nasc.AddYears(idade))
                idade--;

            return idade;
        }
    }
}
