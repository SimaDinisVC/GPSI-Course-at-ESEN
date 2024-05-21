using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace AnimalClinic
{
    internal class BaseDados
    {
        private String strconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|datadirectory|\AnimalClinic.mdf;Integrated Security=True";

        private SqlConnection connection = new SqlConnection();
        public BaseDados()
        {
            connection.ConnectionString = strconnection;
            connection.Open();
        }

        public void CloseConnection()
        {
            try { connection.Close(); } catch(Exception e) { Console.WriteLine(e.Message); }
        }

        public void executeQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, connection);
            command.ExecuteNonQuery();
        }

        public void executeParametersQuery(string commandText, List<SqlParameter> sqlParameters)
        {
            SqlCommand command = new SqlCommand(commandText, connection);
            command.Parameters.AddRange(sqlParameters.ToArray());
            command.ExecuteNonQuery();
        }

        public DataTable executeReturnDataQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, connection);
            DataTable table = new DataTable();
            SqlDataReader data = command.ExecuteReader();
            table.Load(data);
            return table;
        }
    }
}