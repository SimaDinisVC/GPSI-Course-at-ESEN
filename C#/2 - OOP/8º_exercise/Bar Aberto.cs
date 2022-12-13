using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8º_exercise
{
    internal class Bar_Aberto : Evento
    {
        List<Bebida> bebidas = new List<Bebida>();

        public Bar_Aberto(string descricao, string local, string data_prevista, int qnt_convites, double custos, double valor_entrada, List<Bebida> bebidas) : base(descricao, local, data_prevista, qnt_convites, custos, valor_entrada)
        {
            this.bebidas = bebidas;
        }

    }
}
