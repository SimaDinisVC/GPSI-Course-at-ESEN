using System;
using System.Collections.Generic;
using System.IO;

namespace FicheirosBinarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @".\dados.dat";
            List<Cliente> clientes = new List<Cliente>();
            string nome, telefone;
            Console.WriteLine("Novo cliente");
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = Console.ReadLine();
            clientes.Add(new Cliente(nome, telefone));

            BinaryWriter binOut = new BinaryWriter(new FileStream(caminho, FileMode.Append, FileAccess.Write));
            
            foreach (Cliente i in clientes)
            {
                binOut.Write(i.Nome);
                binOut.Write(i.Telefone);
            }
            binOut.Close();

            // ler dados do ficheiro binário

            BinaryReader binIn = new BinaryReader(new FileStream(caminho, FileMode.Open, FileAccess.Read));

            while (binIn.PeekChar() != -1) // enquanto o cursor não atingir o fim do ficheiro
            {
                nome = binIn.ReadString();
                telefone = binIn.ReadString();
            }

            binIn.Close();

            Console.WriteLine("O nome que veio do ficheiro: " + nome);
            Console.WriteLine("O telefone que veio do ficherio: " + telefone);

        }
    }
}
