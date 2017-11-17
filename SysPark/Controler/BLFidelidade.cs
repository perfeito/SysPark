using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLFidelidade
    {
        public void InsereFidelidade(ModFidelidade objModFidel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereTipoFidelidade", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFidelidade", objModFidel.NomeFidelidadde);
                        objCommand.Parameters.AddWithValue("@Situacao", objModFidel.SituacaoFidelidade);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModFidel.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaFidelidade(ModFidelidade objModFidel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaTipoFidelidade", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdFidelidade", objModFidel.IdTipoFidelidade);
                        objCommand.Parameters.AddWithValue("@NomeFidel", objModFidel.NomeFidelidadde);
                        objCommand.Parameters.AddWithValue("@SituacaoFidel", objModFidel.SituacaoFidelidade);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModFidel.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFidelidadeNome(string nomeFidel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFidelidade", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nomeFidel);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaFidelidadeTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFidelidadeTodos", objConexao))
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

        public ModFidelidade VerificaFidelidadeExiste(string nomeFidel)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaFidelidadeExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Fidelidade", nomeFidel);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModFidelidade Fidel = null;

                        if (!dr.HasRows)
                        {
                            Fidel = new ModFidelidade
                            {
                                NomeFidelidadde = " ",
                                IdTipoFidelidade = -1,
                            };
                            return Fidel;
                        }
                        else
                        {
                            dr.Read();

                            Fidel = new ModFidelidade
                            {
                                NomeFidelidadde = dr["NomeFidelidade"].ToString(),
                                IdTipoFidelidade = (long)dr["IdTipoFidelidade"],
                            };
                            return Fidel;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaFidelidadeAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaFidelidadeAtivos", objConexao))
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

        //================ PREÇO FIDELIDADE ======================
        //========================================================

        public DataTable ListaProdutoPraFidelidade()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaProdutoPraFidelidade", objConexao))
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

        public void InserePrecoFidelidade(ModFidelidade objModFidel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InserePrecoFidelidade", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdProduto", objModFidel.IdProduto);
                        objCommand.Parameters.AddWithValue("@IdTipoFidel", objModFidel.IdTipoFidelidade);
                        objCommand.Parameters.AddWithValue("@DescFidel", objModFidel.DescFidel);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaPrecoFidelidade(ModFidelidade objModFidel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaPrecoFidelidade", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@DescFidel", objModFidel.DescFidel);
                        objCommand.Parameters.AddWithValue("@IdPrecoFidel", objModFidel.IdPrecoFidelidade);
                       

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModFidelidade VerificaPrecoFidelidadeExiste(long tipo, long produto)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaPrecoFidelidadeExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTipo", tipo);
                        objCommand.Parameters.AddWithValue("@idProduto", produto);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModFidelidade Fidel = null;

                        if (!dr.HasRows)
                        {
                            Fidel = new ModFidelidade
                            {
                                IdProduto = -1,
                                IdTipoFidelidade = -1,
                                IdPrecoFidelidade = -1,
                            };
                            return Fidel;
                        }
                        else
                        {
                            dr.Read();

                            Fidel = new ModFidelidade
                            {
                                IdProduto = (long)dr["IdProdutoServico"],
                                IdTipoFidelidade = (long)dr["IdTipoFidelidade"],
                                IdPrecoFidelidade = (long)dr["IdPrecoFidelidade"],
                            };
                            return Fidel;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaDescFidelidadeCodigo(long codigo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaDescFidelidadeCodigo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaDescFidelidadeNome(string nome)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaDescFidelidadeNome", objConexao))
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

        public DataTable BuscaDescFidelidadeTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaDescFidelidadeTodos", objConexao))
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

        public bool VerificaPlanoFidelidadeAtivo(long idTipo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaPlanoFidelidadeAtivo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTipo", idTipo);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaProdutoTemPrecoPlano(long idTipo, long idProduto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaProdutoTemPrecoPlano", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTipo", idTipo);
                        objCommand.Parameters.AddWithValue("@idProduto", idProduto);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal PegaPercentualDescontoProduto(long tipo, long produto)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaPercentualDescontoProduto", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTipo", tipo);
                        objCommand.Parameters.AddWithValue("@idProduto", produto);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        decimal desconto = 0;

                        dr.Read();

                        desconto = Convert.ToDecimal(dr["DescontoFidelidade"]);

                        return desconto;
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
