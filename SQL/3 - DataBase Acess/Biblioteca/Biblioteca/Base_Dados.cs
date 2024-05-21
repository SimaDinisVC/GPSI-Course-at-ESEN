using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // livraria para trabalhar com a base de dados do sql server
using System.Data;  // livraria para trabalhar com ogjetos de dados

namespace Biblioteca
{
    class Base_Dados
    {
        // String ligação para aceder a base de dados
        String strligacao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|datadirectory|\Biblioteca.mdf;Integrated Security=True";

        // Ligar à base de dados
        SqlConnection LigacaoBD = new SqlConnection();

        // Construtor da class para fazer a ligação a base de dados
        public Base_Dados()
        {
            // Abrir à base de dados
            LigacaoBD.ConnectionString = strligacao;
            LigacaoBD.Open();
        }

        public void fechar_bd()
        {
            try
            {
                LigacaoBD.Close();
            }
            catch (Exception)
            {

            }
        }

        // Metodo para executar um comando de SQL (manupular a BD)
        public void executar_sql(string comando_sql)
        {
            SqlCommand comando = new SqlCommand();

            // definir o comnado a aplicar
            comando.CommandText = comando_sql;

            // associar o comando á Base Dados
            comando.Connection = LigacaoBD;

            // executar o comando de SQL
            comando.ExecuteNonQuery();
        }

        public void executar_sql(string comando_sql, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(comando_sql, LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
        }

        public DataTable devolver_consulta(string comando_sql)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = LigacaoBD;
            comando.CommandText = comando_sql;
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            return registos;
        }
    }
}