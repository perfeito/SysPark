using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;


namespace SysPark.Controler
{
    public class BLCliente
    {
        public void InsereCliente(ModCliente objModCliente, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereCliente", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeCliente", objModPessoas.NomePessoa);
                        objCommand.Parameters.AddWithValue("@IdcpfCliente", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@DataNasc", objModPessoas.DataNascimento);
                        objCommand.Parameters.AddWithValue("@Rg", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@SituacaoCliente", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);

                        objCommand.Parameters.AddWithValue("@Fidelidade", objModCliente.Fidelidade);
                        objCommand.Parameters.AddWithValue("@Contas", objModCliente.Contas);
                        objCommand.Parameters.AddWithValue("@IdTipoFidel", objModCliente.IdTipoFidelidade);
                        objCommand.Parameters.AddWithValue("@TaxaEntrega ", objModCliente.TaxaEntrega);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa ", objModCliente.ImagemPessoa);
                        objCommand.Parameters.AddWithValue("@PontosAtual ", objModCliente.PontosAtual);
                        objCommand.Parameters.AddWithValue("@Acumulados ", objModCliente.Acululados);

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

        public bool VerificaClienteExiste(long cpf)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaClienteExiste", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdcpfCliente", cpf);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaClienteNome(string nomeCliente)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaClientesNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nomeCliente);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaClienteTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaClientesTodos", objConexao))
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

        public void AtualizaCliente(ModCliente objModCliente, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaCliente", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeCliente", objModPessoas.NomePessoa);
                        objCommand.Parameters.AddWithValue("@IdcpfCliente", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@DataNasc", objModPessoas.DataNascimento);
                        objCommand.Parameters.AddWithValue("@Rg", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@SituacaoCliente", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);

                        objCommand.Parameters.AddWithValue("@Fidelidade", objModCliente.Fidelidade);
                        objCommand.Parameters.AddWithValue("@Contas", objModCliente.Contas);
                        objCommand.Parameters.AddWithValue("@IdTipoFidel", objModCliente.IdTipoFidelidade);
                        objCommand.Parameters.AddWithValue("@TaxaEntrega ", objModCliente.TaxaEntrega);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa ", objModCliente.ImagemPessoa);

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

        public DataTable ListaClienteAtivo(string nome)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaClienteAtivo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nome);

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
