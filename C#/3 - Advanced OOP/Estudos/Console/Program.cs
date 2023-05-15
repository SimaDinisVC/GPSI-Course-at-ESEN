using System;
using System.Net.Mail;
using System.Net;
using OpenPop.Pop3;
using System.Timers;

class Program
{
    static void Main()
    {
        // Configurar o temporizador
        /*
        var timer = new System.Timers.Timer(30000);
        timer.Elapsed += TimerElapsed;
        timer.AutoReset = true;
        timer.Enabled = true;

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadLine();
        */
        Console.WriteLine(new DateTime().ToString());
    }

    static void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Configurar as credenciais
        string host = "pop.gmail.com";
        int port = 995;
        string username = "simadinisvc@gmail.com";
        string password = "dinis78910";

        // Configurar o cliente de email
        using (var client = new Pop3Client())
        {
            client.Connect(host, port, true);
            client.Authenticate(username, password);
            int messageCount = client.GetMessageCount();
            Console.WriteLine("Você tem {0} novas mensagens", messageCount);
            for (int i = 1; i <= messageCount; i++)
            {
                var message = client.GetMessage(i);
                Console.WriteLine("Assunto: {0}", message.Headers.Subject);
                Console.WriteLine("De: {0}", message.Headers.From.DisplayName);
                Console.WriteLine("Mensagem: {0}", message.Headers.DateSent);
                // Chame aqui a função que deseja executar ao receber um novo email
            }
            client.Disconnect();
        }
    }
}