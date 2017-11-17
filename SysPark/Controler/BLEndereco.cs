using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLEndereco
    {
        public void InsereEndereco(ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereEndereco", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Logradouro", objModPessoas.Logradouro);
                        objCommand.Parameters.AddWithValue("@NumeroEnd", objModPessoas.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModPessoas.Bairro);
                        objCommand.Parameters.AddWithValue("@Cidade", objModPessoas.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep", objModPessoas.Cep);
                        objCommand.Parameters.AddWithValue("@UF", objModPessoas.UF);
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

        public void AtualizaEndereco(ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaEndereco", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Logradouro", objModPessoas.Logradouro);
                        objCommand.Parameters.AddWithValue("@NumeroEnd", objModPessoas.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModPessoas.Bairro);
                        objCommand.Parameters.AddWithValue("@Cidade", objModPessoas.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep", objModPessoas.Cep);
                        objCommand.Parameters.AddWithValue("@UF", objModPessoas.UF);
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
