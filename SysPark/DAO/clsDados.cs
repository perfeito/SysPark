using System;
using System.Data.SqlClient;
using System.Data;


namespace SysPark
{
    public class clsDados
    {
        /// <summary>
        ///Conecta ao banco, usando a string de conexão do banco.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConectaBanco()
        {
            try
            {
                //====== FABERSON =======
                return new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=SysPark;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlDataReader RetornaDadosReader(SqlCommand objSqlCommand, SqlConnection objSqlConnection)
        {
            try
            {
                objSqlConnection.Open();
                var dr = objSqlCommand.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public static DataTable RetornaDados(SqlCommand objSqlCommand)
        {
            try
            {
                var dt = new DataTable();
                var dataadapter = new SqlDataAdapter { SelectCommand = objSqlCommand };
                dataadapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet RetornaDadosSet(SqlCommand objSqlCommand)
        {
            try
            {
                var ds = new DataSet();
                var dataadapter = new SqlDataAdapter { SelectCommand = objSqlCommand };
                dataadapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExecutaComando(SqlCommand objSqlCommand, SqlConnection conn)
        {
            try
            {
                conn.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
