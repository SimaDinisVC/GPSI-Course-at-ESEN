using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System;
using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using System.Xml.Linq;
using System.Net.Http;

namespace testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string r = Environment.NewLine + "";

            Console.WriteLine(r.Replace(Environment.NewLine, "") == string.Empty);

            /*
            Console.Write("Insira o código postal: ");
            string codigoPostal = Console.ReadLine();

            string localidade = await ObterLocalidade(codigoPostal);

            Console.WriteLine($"A localidade correspondente ao código postal {codigoPostal} é: {localidade}");

            // Configurações do servidor de e-mail
            bool useSsl = true;

            // Credenciais de acesso à conta de e-mail
            string email = "simadinisvc@gmail.com";
            string password = "wrsdnsbzothximjq"; // A usar contorno de verificação de dois fatores

             //MANDAR EMAIL!
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Simão Costa", email));
            message.To.Add(new MailboxAddress("", "simadinisvc2006@gmail.com"));
            message.Subject = "Teste";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Teste\n Olá a todos!";

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465);

                client.Authenticate(email, password);

                client.Send(message);
                client.Disconnect(true);
            }
            Console.WriteLine("Enviado com sucesso!");

             RECEBER EMAILs!
            using (var client = new ImapClient())
            {
                // Conecta ao servidor de e-mail
                client.Connect("imap.gmail.com", 993, useSsl);

                // Autentica com as credenciais do usuário
                client.Authenticate(email, password);

                // Abre a caixa de entrada
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Filtra as mensagens recebidas nas últimas 24 horas
                var today = DateTime.Now.Date;
                var yesterday = today.AddDays(-1);
                var query = SearchQuery.DeliveredAfter(yesterday);

                // Busca pelas mensagens que atendem ao filtro
                var messages = inbox.Search(query);

                // Processa as mensagens recebidas
                foreach (var uid in messages)
                {
                    var message = inbox.GetMessage(uid);

                    // Processa a mensagem recebida
                    Console.WriteLine("Assunto: " + message.Subject);
                    Console.WriteLine("Remetente: " + message.From);
                    Console.WriteLine("Data de envio: " + message.Date);
                    Console.WriteLine("Corpo: " + message.TextBody);
                }

                // Desconecta do servidor de e-mail
                client.Disconnect(true);

            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                // Autentica com as credenciais do usuário
                client.Authenticate(email, password);

                // Abre a caixa de entrada
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Define um filtro para buscar apenas as mensagens recebidas nas últimas 24 horas
                var yesterday = DateTime.Today.AddDays(-1);
                var query = SearchQuery.DeliveredAfter(yesterday);

                // Busca pelas mensagens que atendem ao filtro
                var uids = inbox.Search(query);

                // Registra o evento MessageArrived para ser notificado quando novas mensagens chegarem
                inbox.MessageArrived += (sender, e) =>
                {
                    Console.WriteLine("Nova mensagem recebida: " + e.UniqueId);
                };

                // Processa as mensagens recebidas
                foreach (var uid in uids)
                {
                    var message = inbox.GetMessage(uid);

                    // Processa a mensagem recebida
                    Console.WriteLine("Assunto: " + message.Subject);
                    Console.WriteLine("Remetente: " + message.From);
                    Console.WriteLine("Data de envio: " + message.Date);
                    Console.WriteLine("Corpo: " + message.TextBody);
                }

                // Desconecta do servidor de e-mail
                client.Disconnect(true);


            using (var client = new ImapClient())
            {
                // Conecta ao servidor de e-mail
                client.Connect("imap.gmail.com", 993, useSsl);

                // Autentica com as credenciais do usuário
                client.Authenticate(email, password);

                // Abre a caixa de entrada
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Filtra as mensagens recebidas nas últimas 24 horas
                var today = DateTime.Now.Date;
                var yesterday = today.AddDays(-1);
                var query = SearchQuery.DeliveredAfter(yesterday);

                // Busca pelas mensagens que atendem ao filtro
                var messages = inbox.Search(query);

                // Lista para armazenar os assuntos das mensagens
                List<string> subjects = new List<string>();

                // Processa as mensagens recebidas
                foreach (var uid in messages)
                {
                    var message = inbox.GetMessage(uid);

                    // Adiciona o assunto da mensagem à lista de assuntos
                    subjects.Add(message.Subject);
                }

                subjects.Reverse();

                // Exibe os assuntos ordenados
                foreach (var subject in subjects)
                {
                    string input = subject;
                    int startIndex = 0;
                    while (startIndex < input.Length && input[startIndex] == '?')
                    {
                        startIndex++;
                    }
                    string part1 = input.Substring(0, startIndex);
                    string part2 = input.Substring(startIndex);
                    part1 = part1.Replace("?", "");
                    string output = part1 + part2;
                    Console.WriteLine(output);
                }

                // Desconecta do servidor de e-mail
                client.Disconnect(true);
        }

        static async Task<string> ObterLocalidade(string codigoPostal)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string apiUrl = $"https://www.cttcodigopostal.pt/api/v1/4f493beaea324c2887ba33821ebe5cad/{codigoPostal}";

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // A resposta é retornada como uma string JSON, então você pode usar uma biblioteca JSON (como Newtonsoft.Json) para analisá-la
                    // Neste exemplo, vamos simplificar e extrair apenas a localidade diretamente da string JSON
                    string localidade = jsonResponse.Split(':')[5].Split(',')[0].Trim('"');

                    return localidade;
                }
                catch (HttpRequestException)
                {
                    // Trate exceções de requisição HTTP aqui
                    // Por exemplo, se ocorrer um erro de conexão ou o código postal não for válido
                    Console.WriteLine("Ocorreu um erro na requisição HTTP.");
                    return string.Empty;
                }
            }
        }*/

        }
    }
}