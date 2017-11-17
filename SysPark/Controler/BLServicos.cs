using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLServicos
    {
        public void CadastraServico(ModServicos objModServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CadastraServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", objModServico.Codigo);
                        objCommand.Parameters.AddWithValue("@NomeServico", objModServico.NomeServico);
                        objCommand.Parameters.AddWithValue("@Descricao", objModServico.Descricao);
                        objCommand.Parameters.AddWithValue("@SituacaoServico", objModServico.SituacaoServico);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModServico.IdGRupo);
                        objCommand.Parameters.AddWithValue("@IdSubGrupo", objModServico.IdSubGRupo);                        
                        objCommand.Parameters.AddWithValue("@UnidadeSaida", objModServico.UnidadeSaida);                        
                        objCommand.Parameters.AddWithValue("@DataCadastro", objModServico.DataCadastro);
                        objCommand.Parameters.AddWithValue("@ImagemServico", objModServico.ImagemServico);                        
                        objCommand.Parameters.AddWithValue("@PrecoVenda", objModServico.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModServico.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@Aliquota", objModServico.Aliquota);
                        objCommand.Parameters.AddWithValue("@Ibpt", objModServico.Ibpt);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AtualizaServico(ModServicos objModServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", objModServico.Codigo);
                        objCommand.Parameters.AddWithValue("@NomeServico", objModServico.NomeServico);
                        objCommand.Parameters.AddWithValue("@Descricao", objModServico.Descricao);
                        objCommand.Parameters.AddWithValue("@SituacaoServico", objModServico.SituacaoServico);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModServico.IdGRupo);
                        objCommand.Parameters.AddWithValue("@IdSubGrupo", objModServico.IdSubGRupo);
                        objCommand.Parameters.AddWithValue("@UnidadeSaida", objModServico.UnidadeSaida);                        
                        objCommand.Parameters.AddWithValue("@ImagemServico", objModServico.ImagemServico);
                        objCommand.Parameters.AddWithValue("@PrecoVenda", objModServico.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModServico.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdServico", objModServico.IdServico);
                        objCommand.Parameters.AddWithValue("@Aliquota", objModServico.Aliquota);
                        objCommand.Parameters.AddWithValue("@Ibpt", objModServico.Ibpt);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaServicoNome(string nomeServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaServicoNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeServico", nomeServico);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaServicoGrupoTodosNome(string nomeServico, int idGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaServicoGrupoTodosNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeServico", nomeServico);
                        objCommand.Parameters.AddWithValue("@IdGrupo", idGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaServicoSubGrupoTodosNome(string nomeServico, int idGrupo, int idSubgrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaServicoSubGrupoTodosNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeServico", nomeServico);
                        objCommand.Parameters.AddWithValue("@IdGrupo", idGrupo);
                        objCommand.Parameters.AddWithValue("@IdSubGrupo", idSubgrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaServicoCodigo(Int64 codigo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaServicoCodigo", objConexao))
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
        public DataTable BuscaServicoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaServicoTodos", objConexao))
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
        public ModServicos VerificaServicoExisteCodigo(Int64 codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaServicoExisteCodigo", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModServicos Servicos = null;

                        if (!dr.HasRows)
                        {
                            Servicos = new ModServicos
                            {
                                Codigo = -1,
                                IdServico = -1,
                            };
                            return Servicos;
                        }
                        else
                        {
                            dr.Read();

                            Servicos = new ModServicos
                            {
                                Codigo = Convert.ToInt64((dr["Codigo"]).ToString()),
                                IdServico = Convert.ToInt32((dr["Id"]).ToString()),
                            };

                            return Servicos;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ModServicos VerificaServicoExisteNomeServico(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaServicoExisteNomeServico", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeServico", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModServicos Servicos = null;

                        if (!dr.HasRows)
                        {
                            Servicos = new ModServicos
                            {
                                NomeServico = " ",
                                IdServico = -1,
                            };
                            return Servicos;
                        }
                        else
                        {
                            dr.Read();

                            Servicos = new ModServicos
                            {
                                NomeServico = (dr["NomeProdutoServico"]).ToString(),
                                IdServico = Convert.ToInt32((dr["IdProdutoServico"]).ToString()),
                            };

                            return Servicos;
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
