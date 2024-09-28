using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class SqlDb
    {

        SqlConnection connection;
        private const string SqlConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
        public bool ExecuteNonquery(string storeProcedureName, List<SqlParameter> parameters)
        {
            bool returnValue = false;


            using (connection = new SqlConnection(SqlConString))
            {
                SqlCommand comm = connection.CreateCommand();
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = storeProcedureName;

                comm.Parameters.AddRange(parameters.ToArray());

                connection.Open();

                if (comm.ExecuteNonQuery() > 0)
                {
                    returnValue = true;
                }

            }

            return returnValue;


        }

        public SqlDataReader ExecuteReader(string storeProcedureName, List<SqlParameter> parameters)
        {
            SqlDataReader reader = null;

            SqlConnection connection = new SqlConnection(SqlConString);
            SqlCommand comm = connection.CreateCommand();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = storeProcedureName;

            if (parameters != null && parameters.Count > 0)
            {
                comm.Parameters.AddRange(parameters.ToArray());
            }

            connection.Open();
            reader = comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection); 
            return reader;
        }

    }
}
