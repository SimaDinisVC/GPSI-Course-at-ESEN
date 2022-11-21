using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8º_exercise
{
    internal class Evento
    {
        int id;
        string descricao, local, data_prevista;
        int qnt_convites;
        double custos;
        Entrada valor_entrada;

        public Evento(int id, string descricao, string local, string data_prevista, int qnt_convites, double custos, Entrada valor_entrada)
        {
            this.id = id;
            this.descricao = descricao;
            this.local = local;
            this.data_prevista = data_prevista;
            this.qnt_convites = qnt_convites;
            this.custos = custos;
            this.valor_entrada = valor_entrada;
        }

        public double entrada_popular()
        {
            return custos / qnt_convites;
        }
    }
}
