using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLFornecedor
    {
        public void InsereFornecedor(ModFornecedor objModFornecedor, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereFornecedor", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFantasia",objModFornecedor.NomeFantasia);
                        objCommand.Parameters.AddWithValue("@RazaoSocial", objModFornecedor.RazaoSocial);
                        objCommand.Parameters.AddWithValue("@IdcpfcnpjFornecedor", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@RgIe", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@TipoPessoa", objModFornecedor.TipoPessoa);
                        objCommand.Parameters.AddWithValue("@SituacaoFornecedor", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa", objModPessoas.ImagemPessoa);

                        objCommand.Parameters.AddWithValue("@Logradouro", objModPessoas.Logradouro);
                        objCommand.Parameters.AddWithValue("@NumeroEnd", objModPessoas.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModPessoas.Bairro);
                        objCommand.Parameters.AddWithValue("@Cidade", objModPessoas.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep", objModPessoas.Cep);
                        objCommand.Parameters.AddWithValue("@UF", objModPessoas.UF);

                        objCommand.Parameters.AddWithValue("@Telefone", objModPessoas.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModPessoas.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModPessoas.Email);
                        objCommand.Parameters.AddWithValue("@Website", objModPessoas.Website);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaFornecedorExiste(long cpfCnpj)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaFornecedorExiste", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdcpfFornecedor", cpfCnpj);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFornecedorRazao(string razaoSocial)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFornecedorRazao", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@RazaoSocial", razaoSocial);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFornecedorFantasia(string nomeFantasia)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFornecedorFantasia", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFantasia", nomeFantasia);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFornecedorTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFornecedorTodos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaFornecedor(ModFornecedor objModFornecedor, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaFornecedor", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFantasia", objModFornecedor.NomeFantasia);
                        objCommand.Parameters.AddWithValue("@RazaoSocial", objModFornecedor.RazaoSocial);
                        objCommand.Parameters.AddWithValue("@IdcpfcnpjFornecedor", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@RgIe", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@TipoPessoa", objModFornecedor.TipoPessoa);
                        objCommand.Parameters.AddWithValue("@SituacaoFornecedor", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa", objModPessoas.ImagemPessoa);

                        objCommand.Parameters.AddWithValue("@Logradouro", objModPessoas.Logradouro);
                        objCommand.Parameters.AddWithValue("@NumeroEnd", objModPessoas.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModPessoas.Bairro);
                        objCommand.Parameters.AddWithValue("@Cidade", objModPessoas.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep", objModPessoas.Cep);
                        objCommand.Parameters.AddWithValue("@UF", objModPessoas.UF);

                        objCommand.Parameters.AddWithValue("@Telefone", objModPessoas.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModPessoas.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModPessoas.Email);
                        objCommand.Parameters.AddWithValue("@Website", objModPessoas.Website);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaFornecedorAtivo(string razaoSocial)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaFornecedorAtivo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@RazaoSocial", razaoSocial);

                        return clsDados.RetornaDados(objCommand);
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
