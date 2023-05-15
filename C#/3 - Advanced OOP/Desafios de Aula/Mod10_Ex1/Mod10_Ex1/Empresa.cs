using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_Ex1
{
    static class Empresa
    {
        //Criar uma lista vinculada com a DataGridView

        public static BindingList<Empregado> empList = new BindingList<Empregado>();
        public static List<string> cargos = new List<string> { "Programador", "Analista" };

        public static string appNome = "GestEmpresa";
        public static string versao = "v1.0 beta";

        public const int CARGO_PROGRAMADOR = 0;
        public const int CARGO_ANALISTA = 1;

        static Empresa()
        {
            empList.Add(new Programador("Andreia", new DateTime(1983, 05, 27), "p1360@esenviseu.net", "933333333", new Morada("Rua x", "3500-001", "Viseu"), "C#"));
            empList.Add(new Analista());
            empList.Add(new Programador("Simão"));
        }

    }
}
