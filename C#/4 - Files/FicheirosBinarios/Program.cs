using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FicheirosBinarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @".\dados.dat";
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, telefone);

            using (FileStream fileStream = new FileStream(caminho, FileMode.Append, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, cliente);
            }

            Console.WriteLine("Cliente criado com sucesso!");

            if (!File.Exists(caminho)) // Verifica se o caminho existe
            {
                Console.WriteLine("O arquivo de dados não existe.");
                return;
            }

            List<Cliente> clientes = new List<Cliente>();

            using (FileStream fileStream = new FileStream(caminho, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                while (fileStream.Position < fileStream.Length)
                {
                    cliente = (Cliente)formatter.Deserialize(fileStream);
                    clientes.Add(cliente);
                }
            }

            if (clientes.Count > 0)
            {
                Console.WriteLine("Lista de clientes:");
                foreach (Cliente c in clientes)
                {
                    Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}");
                }
            }
            else
            {
                Console.WriteLine("Não há clientes para exibir.");
            }
        }
    }
}
