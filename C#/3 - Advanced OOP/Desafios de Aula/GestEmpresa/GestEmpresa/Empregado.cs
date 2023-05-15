using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace GestEmpresa
{
    public class Empregado
    {
        // Pretendemos uma numeração automática no ID do empregado
        // Inicialmente é atribuido o valor zero
        // Apenas o empregado tem acesso
        // Estatico para podermos atribuir o valor do ID de cada Empregado de forma automática
        private static int autoID;

        // ID do empregado
        // protected: APENAS o empregado, programador e analista vão ter acesso
        protected int ID;

        // Identificar os campos (propriedades) do empregado que vão surgir na DataGridView
        // A ordem da declaração das propriedades na classe, vai influenciar a ordem dos campos nos elementos da lista

        // Campos para a coluna da DataGridView

        /// <summary>
        /// 1ª Campo: ID - Chave primária
        /// </summary>
        public int ValorID
        {
            get { return ID; }
        }

        /// <summary>
        /// 2ª Campo: nome Abreviado
        /// /// Apenas para o campo da coluna na DataGridView
        /// </summary>
        public string NomeAbreviado
        {
            get { return GetNomeAbreviado(Nome); }
        }

        /// <summary>
        /// 3º Campo: Localidade
        /// </summary>
        public string Localidade
        {
            get { return MoradaAtual.Localidade; }
        }

        /// <summary>
        /// 4º Campo: Cargo
        /// </summary>
        public string Cargo
        {
            get { return getCargo(); }
        }

        /// <summary>
        /// Tamanho entre 7 e 150 char;
        /// Pelo menos com primeiro nome e apelido
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (IsValidNome(value))
                    nome = value.Trim(); // Retira eventuais espaços no início e no fim do texto
                else
                    nome = "(Sem_Nome)";
            }
        }

        public DateTime DataNasc { get; set; }

        public Morada MoradaAtual { get; set; }

        private string email;
        public string eMail
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    email = "";
            }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (IsValidTelefone(value))
                    telefone = value; // Retira eventuais espaços no início e no fim do texto
                else
                    telefone = "";
            }
        }


        public Empregado()
        {
            // ID com numeração automática
            // Primeiro é feito o incremento e só depois é que é atribuido a ID
            ID = ++autoID;
            Nome = "(Sem_Nome)";
            // Sem data de aniversário definida 
            // É inicializado o objeto DateTime(), neste caso é assumido Value = 01/01/0001 Que não é uma data válida.
            DataNasc = new DateTime();
            MoradaAtual = new Morada();
            email = "";
            Telefone = "";
        }

        public Empregado(string _nome) : this()
        {
            nome = _nome;
        }

        public Empregado(string _nome, DateTime _dataNasc, string _email, string _telefone, Morada _morada) : this(_nome)
        {
            DataNasc = _dataNasc;
            MoradaAtual = _morada;
            eMail = _email;
            Telefone = _telefone;
        }

        // Static permite que a função seja usada sem criar uma instância da classe (objeto Empregado) 
        public static bool IsValidEmail(string email)
        {
            bool valido = true;

            try
            {
                MailAddress aux = new MailAddress(email);
            }
            catch (Exception)
            {
                valido = false;
            }

            return valido;
        }

        public static bool IsValidTelefone(string telefone)
        {
            string pattern = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s[0-9]*$";

            return Regex.IsMatch(telefone, pattern);
        }

        /// <summary>
        /// Valida o nome.
        /// </summary>
        /// <param name="nome"> Nome completo </param>
        /// <returns> verdadeiro se válido </returns>
        public static bool IsValidNome(string nome)
        {
            bool valido = true;
            
            // Tamanho entre 7 e 150 char;
            if (nome.Length < 7 || nome.Length > 150)
                valido = false;
            // Pelo menos, com primeiro nome e apelido (deve ter pelo menos duas palavras separadas por um espaço)
            if (nome.Trim().IndexOf(" ") < 0)
                valido = false;

            return valido;
        }


        /// <summary>
        /// Devolve o nome no formato: APELIDO, Nome
        /// </summary>
        /// <returns> Nome abreviado </returns>
        public static string GetNomeAbreviado(string nome)
        {
            // O Trim garante a eficácia do problema,
            // retirando espaços nas extremidades do nome
            string[] palavras = nome.Trim().Split(' ');

            string apelido, primeiroNome;
            string nomeAbreviado = "";

            // O nome deve ter pelo menos 2 palavras
            if (palavras.Length > 1)
            {
                // Último elemento do vetor em maiusculas
                apelido = palavras[palavras.Length - 1].ToUpper();

                // Primeiro elemento do vetor com capitalize
                // palavras[0][0] representa a primeira letra da primeira palavra
                // palavras[0][0] devolve um caratere (char) e não uma string
                // palavras[0][0].ToUpper() não é válido, porque não se trata de uma string
                // char.ToUpper() converte um catrater para maiuscula
                // Substring(1), devolve a substring do primeiro nome a partir da posição 1 (index)
                primeiroNome = char.ToUpper(palavras[0][0]) + palavras[0].ToLower().Substring(1);

                nomeAbreviado = string.Format("{0}, {1}", apelido, primeiroNome);
            }

            return nomeAbreviado;
        }


        public virtual string getCargo()
        {
            return "Empregado";
        }

        /// <summary>
        /// Permite criar uma cópia do objeto Empregado
        /// </summary>
        /// <returns>devolve o objeto</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
