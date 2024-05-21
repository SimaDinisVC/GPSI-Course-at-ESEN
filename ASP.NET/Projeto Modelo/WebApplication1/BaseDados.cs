using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Biblioteca com as funções de Acesso á Base de Dados SQLServer
using System.Data; // Biblioteca com funções para trabalhar com objetos da Base de Dadoss
using System.Configuration; // Biblioteca para trabalhar com o App.Config


namespace WebApplication1
{
    class BaseDados
    {
        #region BD_DML

        SqlConnection LigacaoBD;
        string strLigacao;

        //Construtor para iniciar a ligação á Base de dados

        public BaseDados()
        {
            // -------- String de ligacao á base de dados (connection String) ------- 
            strLigacao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|datadirectory|\tecnavarro.mdf;Integrated Security=True;Connect Timeout=30";
            //strLigacao = ConfigurationManager.ConnectionStrings["BD_Biblioteca"].ToString();
            LigacaoBD = new SqlConnection(strLigacao);
            // --------- Abrir a Base Dados --------
            LigacaoBD.Open();

        }

        // Destrutor para fechar a Base de Dados

        ~BaseDados()
        {
            try
            {
                LigacaoBD.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        // Metodo para executar um script de SQL para alterar dados na BD (Insert, Update, Delete)
        public void executa_SQL(string querySQL)
        {
            SqlCommand comando = new SqlCommand(); // Objeto para executar instruções de SQL
            comando.CommandText = querySQL; // Associa a query recebida como parametro
            comando.Connection = LigacaoBD; // Associa o comando á base de Dados onde quero aplicar o comando
            comando.ExecuteNonQuery(); // Executa o comando de Sql na base de dados 
            comando.Dispose(); // Libertar o espaço em memória relacionado com a variavel comando
            comando = null; // Apagar o conteudo da variavel
        }

        // Metodo para executar um script de SQL com utilização de parametros

        public void executa_SQL(string querySQL, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(querySQL,LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
            comando.Dispose();
        }

        // Metodo para iniciar uma transação

        public SqlTransaction iniciar_transação()
        {
            return LigacaoBD.BeginTransaction();
        }

        // Metodo para executar a instrução de SQL com uma transação

        public void executa_SQL(string querySQL, List<SqlParameter> parametros, SqlTransaction transacao)
        {
            SqlCommand comando = new SqlCommand(querySQL, LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.Transaction = transacao;
            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
            }
            catch 
            {
                 transacao.Rollback();
                throw;
            }
            comando.Dispose();
        }

        // Metodo para devolver o resultado de uma consulta de SQL(Query)

        public DataTable devolve_consulta(string querySQL)
        {
            SqlCommand comando = new SqlCommand(querySQL, LigacaoBD);
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;
        }

        public DataTable devolve_consulta(string querySQL, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(querySQL, LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;
        }
        #endregion
    }
}
