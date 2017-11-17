using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLFuncionario
    {
        public void InsereFuncionario(ModFuncionario objModFuncionario, ModCargo objModCargo, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereFuncionario", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFuncionario", objModPessoas.NomePessoa);
                        objCommand.Parameters.AddWithValue("@IdcpfFuncionario", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@DataNasc", objModPessoas.DataNascimento);
                        objCommand.Parameters.AddWithValue("@Rg", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@SituacaoFuncionario", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa ", objModFuncionario.ImagemPessoa);

                        objCommand.Parameters.AddWithValue("@Salario", objModFuncionario.Salario);
                        objCommand.Parameters.AddWithValue("@Comissao", objModFuncionario.Comissao);
                        objCommand.Parameters.AddWithValue("@CarteiraTrabalho", objModFuncionario.CarteiraTrabalho);
                        objCommand.Parameters.AddWithValue("@DataAdimissao", objModFuncionario.DataAdimissao);
                        objCommand.Parameters.AddWithValue("@Contas", objModFuncionario.Contas);
                        objCommand.Parameters.AddWithValue("@CodFunc", objModFuncionario.CodFunc);

                        objCommand.Parameters.AddWithValue("@IdCargo", objModCargo.IdCargo);

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

        public DataTable BuscaFuncionarioNome(string nomeFuncionario)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFuncionarioNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nomeFuncionario);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFuncionarioTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFuncionarioTodos", objConexao))
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

        public void AtualizaFuncionario(ModFuncionario objModFuncionario, ModCargo objModCargo, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaFuncionario", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFuncionario", objModPessoas.NomePessoa);
                        objCommand.Parameters.AddWithValue("@IdcpfFuncionario", objModPessoas.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@DataNasc", objModPessoas.DataNascimento);
                        objCommand.Parameters.AddWithValue("@Rg", objModPessoas.Rg);
                        objCommand.Parameters.AddWithValue("@SituacaoFuncionario", objModPessoas.SituacaoPessoa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPessoas.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@ImagemPessoa ", objModFuncionario.ImagemPessoa);

                        objCommand.Parameters.AddWithValue("@Salario", objModFuncionario.Salario);
                        objCommand.Parameters.AddWithValue("@Comissao", objModFuncionario.Comissao);
                        objCommand.Parameters.AddWithValue("@CarteiraTrabalho", objModFuncionario.CarteiraTrabalho);
                        objCommand.Parameters.AddWithValue("@DataAdimissao", objModFuncionario.DataAdimissao);
                        if (objModFuncionario.DataDemissao == null)
                            objCommand.Parameters.AddWithValue("@DataDemissao", DBNull.Value);
                        else
                            objCommand.Parameters.AddWithValue("@DataDemissao", objModFuncionario.DataDemissao);
                        objCommand.Parameters.AddWithValue("@Contas", objModFuncionario.Contas);
                        objCommand.Parameters.AddWithValue("@CodFunc", objModFuncionario.CodFunc);

                        objCommand.Parameters.AddWithValue("@IdCargo", objModCargo.IdCargo);

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

        public bool VerificaFuncionarioExiste(long cpf)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaFuncionarioExiste", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdcpfFuncionario", cpf);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModFuncionario VerificaCodigoFuncionarioExiste(Int64 codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCodigoFuncionarioExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodFunc", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModFuncionario Func = null;

                        if (!dr.HasRows)
                        {
                            Func = new ModFuncionario
                            {
                                IdcpfcnpjPessoa = -1,
                                CodFunc = -1,
                            };
                            return Func;
                        }
                        else
                        {
                            dr.Read();

                            Func = new ModFuncionario
                            {
                                IdcpfcnpjPessoa = (Int64)dr["IdcpfcnpjPessoa"],
                                CodFunc = (Int64)dr["CodFunc"],
                            };

                            return Func;
                        }
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
