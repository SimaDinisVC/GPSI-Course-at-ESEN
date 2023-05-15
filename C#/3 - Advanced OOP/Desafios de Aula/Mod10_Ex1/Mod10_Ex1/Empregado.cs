using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Mod10_Ex1
{
    public class Empregado
    {
        //Pretendemos uma númeração automática no ID do empregado
        //O valor inicial do ID será 0
        //Apenas o Empregado tem acesso.
        //O ID vai ser estático para podermos atribuir o valor do ID ao empregado de forma automática

        private static int autoID;
        protected int ID;

        public int valorID
        {
            get { return ID; }

            set
            {
                ID = value;
            }
        }

        public string NomeAbreviado
        {
            get
            {
                return GetNomeAbreviado(nome);
            }
        }

        public string Localidade
        {
            get
            {
                return MoradaAtual.Localidade;
            }
        }

        public string Cargo
        {
            get
            {
                return getCargo();
            }

        }


        public DateTime DataNasc { get; set; }
        public Morada MoradaAtual { get; set; }


        //O ID só vai ser acedido pelas classes Programador e Analista, visto serem filhas
        //da classe empregado

        public string Nome
        {

            get
            {
                return nome;
            }

            set
            {
                if (ValidarNome(value))
                    nome = value;
                else
                    nome = "(Sem nome)";
            }
        }

        //Propriedade para acesso ao ID

        private string nome;
        private string cargo;
        private string email;
        private string telefone;
        private DateTime datanasc;
        private Morada moradaAtual;
        


        public virtual string getCargo()
        {
            return "Empregado";
        }


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (isValidEmail(value))
                    email = value;
                else
                    email = "(sem email)";
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (isValidPhoneNumb(value))
                    telefone = value;
                else
                    telefone = "(sem telefone)";
            }
        }

        //função que devolve o nome abreviado

        public static string GetNomeAbreviado(string nome)
        {
            //o Trim garante a eficácia retirando o espaço no início e do fim
            string[] palavras = nome.Trim().Split(' ');
            string apelido;
            string primeiroNome;
            string nomeAbreviado = "";
            //o nome deve ter obrigatóriamente 2 palavras
            if (palavras.Length>1)
            {
                apelido = palavras[palavras.Length - 1];
                primeiroNome = palavras[0].ToUpper();

                //nome abreviado com a primeira letra em maiúsculas
                primeiroNome = char.ToUpper(palavras[0][0]) + palavras[0].ToLower().Substring(1);
                nomeAbreviado = string.Format("{0} {1}", primeiroNome,apelido);
            }

            return nomeAbreviado;
        }

        public static bool isValidEmail(string email)
        {
            bool valido = true;
            try
            {
                MailAddress aux = new MailAddress(email);
            }
            catch(Exception)
            {
                valido = false;
            }

            return valido;
        }


        public static bool isValidPhoneNumb(string phoneNumb)
        {
            string r = "^[+][(][0-9]{3}[)] [0-9]{9}$";
            bool flag = Regex.IsMatch(phoneNumb, r);

            return flag;
        }

        public static bool ValidarNome(string nome)
        {
            bool flag = true;
            int tamanho = nome.Length;
            if (tamanho <= 7 && tamanho >= 150)
            {
                flag = false;
            }
            return flag;

        }

      //construtores

       public Empregado()
        {
            //Id com numeração automática
            //Primeiro é feito o incremento e só depois é atribuído à
            // variável ID

            ID = ++autoID;
            Nome = "(sem nome)";
            DataNasc = new DateTime();
            MoradaAtual = new Morada();
            Email = "(sem email)";
            Telefone = "(sem telefone)";
        }

        public Empregado(string _nome):this()
        {
            Nome = _nome;
        }

        public Empregado(string _nome,DateTime _data, string _email, string _telefone, Morada m):this(_nome)
        {
            DataNasc = _data;
            email = _email;
            Telefone = _telefone;
            MoradaAtual = m;
        }
    }
}
