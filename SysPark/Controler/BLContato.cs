using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLContato
    {
        public void InsereContato(ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereContato", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Telefone", objModPessoas.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModPessoas.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModPessoas.Email);
                        objCommand.Parameters.AddWithValue("@Website", objModPessoas.Website);
                        objCommand.Parameters.AddWithValue("@IdcpfcnpjPessoa", objModPessoas.IdcpfcnpjPessoa);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AtualizaContato(ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaContato", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Telefone", objModPessoas.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModPessoas.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModPessoas.Email);
                        objCommand.Parameters.AddWithValue("@Website", objModPessoas.Website);
                        objCommand.Parameters.AddWithValue("@IdcpfcnpjPessoa", objModPessoas.IdcpfcnpjPessoa);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
