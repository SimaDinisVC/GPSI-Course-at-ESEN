using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GestEmpresa
{
    static class Empresa
    {
        // Como a BindList não tem o método de ordenação, podemos estratégicamente criar uma lista ordenada pela chave ID
        public static List<Empregado> empList = new List<Empregado>().OrderBy(x => x.ValorID).ToList();


        // Criar uma lista vinculada com a DataGridView, permitindo a atualização 
        // dos dados da lista no formulário em tempo real. Ou seja, estou a ligar a List com os dados da DataGridView
        
        // Criar a BindingList caso não queira ordenar pelo ID 
        // public static BindingList<Empregado> emp = new BindingList<Empregado>();

        // Criar a BindingList com base na Lista ordenado pelo ID
        public static BindingList<Empregado> emp = new BindingList<Empregado>(empList);


        // E se quiser ordenar a BindingList? Não é possivel de forma direta... é necessário criar primeiroi uma List...

        // Configurações
        public static string appNome = "GestEmpresa";
        public static string appVer = "v2.0 Beta";

        // Lista de tipos de empregados (cargos)
        public static List<string> cargos = new List<string> { "Programador", "Analista"};
        public const int CARGO_PROGRAMADOR = 0;
        public const int CARGO_ANALISTA = 1;

        // O construtor da empresa e, por ser estático, vai ser executada no início do programa
        static Empresa()
        {
            emp.Add(new Programador("Carlos Almeida", new DateTime(1968,11,19),"carlosalmeida@esenviseu.net","967832455",new Morada("Rua da Boa Fé, N.º 69", "3510-146", "Viseu"),"Programador na área de robótica"));
            emp.Add(new Programador("Maria Campos"));
            emp.Add(new Analista());
           // emp.Add(new Empregado()); // Devo permitir a criação de um Empregado?... Eu não queria... como fazer para o impedir? Tornar a classe Empregado como abstrata
        }
    }
}
