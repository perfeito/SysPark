using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLProduto
    {
        public void CadastraProduto(ModProduto objModProduto, ModFornecedor objModFornecedor)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CadastraProduto", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodBarras", objModProduto.CodBarras);
                        objCommand.Parameters.AddWithValue("@NomeProduto", objModProduto.NomeProduto);
                        objCommand.Parameters.AddWithValue("@Descricao", objModProduto.Descricao);
                        objCommand.Parameters.AddWithValue("@Marca", objModProduto.Marca);
                        objCommand.Parameters.AddWithValue("@IdFornecedor", objModFornecedor.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@SituacaoProduto", objModProduto.Situacao);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModProduto.IdGRupo);
                        objCommand.Parameters.AddWithValue("@IdSubGrupo", objModProduto.IdSubGRupo);
                        objCommand.Parameters.AddWithValue("@QtdEstoque", objModProduto.QtdEstoque);
                        objCommand.Parameters.AddWithValue("@QtdMinEstoque", objModProduto.QtdMinEstoque);
                        objCommand.Parameters.AddWithValue("@UnidadeEntrada", objModProduto.UnidadeEntrada);
                        objCommand.Parameters.AddWithValue("@UnidadeSaida", objModProduto.UnidadeSaida);
                        objCommand.Parameters.AddWithValue("@Fator", objModProduto.Fator);
                        objCommand.Parameters.AddWithValue("@UltimaCompra", objModProduto.UltimaCompra);
                        objCommand.Parameters.AddWithValue("@QtdComprada", objModProduto.QtdComprada);
                        objCommand.Parameters.AddWithValue("@DataCadastro", objModProduto.DataCadastro);
                        objCommand.Parameters.AddWithValue("@ImagemProduto", objModProduto.ImagemProduto);
                        objCommand.Parameters.AddWithValue("@PrecoCusto", objModProduto.PrecoCusto);
                        objCommand.Parameters.AddWithValue("@MargemLucro", objModProduto.MargemLucro);
                        objCommand.Parameters.AddWithValue("@PrecoVenda", objModProduto.PrecoVenda);                        
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModProduto.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@Aliquota", objModProduto.Aliquota);
                        objCommand.Parameters.AddWithValue("@Ibpt", objModProduto.Ibpt);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaProduto(ModProduto objModProduto, ModFornecedor objModFornecedor)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaProdutos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodBarras", objModProduto.CodBarras);
                        objCommand.Parameters.AddWithValue("@NomeProduto", objModProduto.NomeProduto);
                        objCommand.Parameters.AddWithValue("@Descricao", objModProduto.Descricao);
                        objCommand.Parameters.AddWithValue("@Marca", objModProduto.Marca);
                        objCommand.Parameters.AddWithValue("@IdFornecedor", objModFornecedor.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@SituacaoProduto", objModProduto.Situacao);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModProduto.IdGRupo);
                        objCommand.Parameters.AddWithValue("@IdSubGrupo", objModProduto.IdSubGRupo);
                        objCommand.Parameters.AddWithValue("@QtdEstoque", objModProduto.QtdEstoque);
                        objCommand.Parameters.AddWithValue("@QtdMinEstoque", objModProduto.QtdMinEstoque);
                        objCommand.Parameters.AddWithValue("@UnidadeEntrada", objModProduto.UnidadeEntrada);
                        objCommand.Parameters.AddWithValue("@UnidadeSaida", objModProduto.UnidadeSaida);
                        objCommand.Parameters.AddWithValue("@Fator", objModProduto.Fator);
                        //objCommand.Parameters.AddWithValue("@UltimaCompra", objModProduto.UltimaCompra);
                        //objCommand.Parameters.AddWithValue("@QtdComprada", objModProduto.QtdComprada);
                        //objCommand.Parameters.AddWithValue("@DataCadastro", objModProduto.DataCadastro);
                        objCommand.Parameters.AddWithValue("@ImagemProduto", objModProduto.ImagemProduto);
                        objCommand.Parameters.AddWithValue("@PrecoCusto", objModProduto.PrecoCusto);
                        objCommand.Parameters.AddWithValue("@MargemLucro", objModProduto.MargemLucro);
                        objCommand.Parameters.AddWithValue("@PrecoVenda", objModProduto.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModProduto.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdProduto", objModProduto.IdProduto);
                        objCommand.Parameters.AddWithValue("@Aliquota", objModProduto.Aliquota);
                        objCommand.Parameters.AddWithValue("@Ibpt", objModProduto.Ibpt);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }        

        public ModProduto VerificaProdutoExisteCodBarras(long codBarras)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaProdutoExisteCodBarras", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodBarras", codBarras);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto Produto = null;

                        if (!dr.HasRows)
                        {
                            Produto = new ModProduto
                            {
                                CodBarras = -1,
                                IdProduto = -1,
                            };
                            return Produto;
                        }
                        else
                        {
                            dr.Read();

                            Produto = new ModProduto
                            {
                                CodBarras = Convert.ToInt64((dr["Codigo"]).ToString()),
                                IdProduto = Convert.ToInt32((dr["Id"]).ToString()),
                            };

                            return Produto;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaProdutoNome(string nomeProduto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaProdutoNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeProduto", nomeProduto);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaProdutoGrupoTodosNome(string nomeProduto, int idGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaProdutoGrupoTodosNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeProduto", nomeProduto);
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

        public DataTable BuscaProdutoSubGrupoTodosNome(string nomeProduto, int idGrupo, int idSubgrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaProdutoSubGrupoTodosNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeProduto", nomeProduto);
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

        public DataTable BuscaProdutoCodBarras(long codBarras)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaProdutoCodBarras", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodBarras", codBarras);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaProdutoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaProdutoTodos", objConexao))
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

        public ModProduto PegarProdutoParaAcertaEstoque(long codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegarProdutoParaAcertaEstoque", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto Produto = null;

                        if (!dr.HasRows)
                        {
                            Produto = new ModProduto
                            {
                                IdProduto = -1,
                            };
                            return Produto;
                        }
                        else
                        {
                            dr.Read();

                            Produto = new ModProduto
                            {
                                IdProduto = (long)dr["ID"],
                                CodBarras = (long)dr["Código"],
                                NomeProduto = dr["Produto"].ToString(),
                                ImagemProduto = (byte[])dr["Imagem"],
                                QtdEstoque = (decimal)dr["Estoque"],
                                QtdMinEstoque = (decimal)dr["Grade"],
                                NomeAtualiza = dr["Atualizado Por"].ToString(),
                                DataAtualiza = (DateTime)dr["Data Atualização"],
                            };

                            return Produto;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AcertaEstoque(decimal qtd, string nomeAtualiza, long idprotudo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AcertaEstoque", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        objCommand.Parameters.AddWithValue("@QtdEstoque", qtd);  
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", nomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdProduto", idprotudo);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaProdutoServicoAlterarPreco(string nomeProduto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaProdutoServicoAlterarPreco", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nomeProduto);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaProdutoServicoAlterarPrecoPorCodigo(long cod)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaProdutoServicoAlterarPrecoPorCodigo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", cod);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarPreco(ModProduto objModProduto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AlterarPreco", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodBarras", objModProduto.CodBarras);                        
                        objCommand.Parameters.AddWithValue("@PrecoCusto", objModProduto.PrecoCusto);
                        objCommand.Parameters.AddWithValue("@MargemLucro", objModProduto.MargemLucro);
                        objCommand.Parameters.AddWithValue("@PrecoVenda", objModProduto.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModProduto.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdProduto", objModProduto.IdProduto);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //================ RELATÓRIOS ========================

        public DataTable ListarProdutosParaControleEstoque()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoque", objConexao))
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

        public DataTable ListarProdutosParaControleEstoquePorGrupo(int idGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoquePorGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

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

        public DataTable ListarProdutosParaControleEstoquePorSubGrupo(int idSubGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoquePorSubGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSubGrupo", idSubGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarProdutosParaControleEstoqueNegativos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoqueNegativos", objConexao))
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

        public DataTable ListarProdutosParaControleEstoqueNegativosPorGrupos(int idGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoqueNegativosPorGrupos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

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

        public DataTable ListarProdutosParaControleEstoqueNegativosPorSubGrupos(int idSubGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListarProdutosParaControleEstoqueNegativosPorSubGrupos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSubGrupo", idSubGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Relatorio_Venda_Itens_Mais_Vendidos(DateTime inicio, DateTime fim, int qtdLinha)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Venda_Itens_Mais_Vendidos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@DataInicio", inicio);
                        objCommand.Parameters.AddWithValue("@DataFim", fim);
                        objCommand.Parameters.AddWithValue("@Qtd", qtdLinha);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Relatorio_Venda_Itens_Menos_Vendidos(DateTime inicio, DateTime fim, int qtdLinha)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Venda_Itens_Menos_Vendidos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@DataInicio", inicio);
                        objCommand.Parameters.AddWithValue("@DataFim", fim);
                        objCommand.Parameters.AddWithValue("@Qtd", qtdLinha);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Relatorio_Perdas_Maiores_Valores(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Perdas_Maiores_Valores", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@DataInicio", inicio);
                        objCommand.Parameters.AddWithValue("@DataFim", fim);                       

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Relatorio_Perdas_Maiores_Qtds(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Perdas_Maiores_Qtds", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@DataInicio", inicio);
                        objCommand.Parameters.AddWithValue("@DataFim", fim);                        

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //============= PERDAS DE PRODUTOS =====================

        public void InsereCausaPerda(ModProduto objModPro)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereCausaPerda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Causa", objModPro.NomeCausa);
                        objCommand.Parameters.AddWithValue("@Situacao", objModPro.SituacaoCausa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPro.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModProduto VerificaCausaPerdaExiste(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCausaPerdaExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Causa", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto Causa = null;

                        if (!dr.HasRows)
                        {
                            Causa = new ModProduto
                            {
                                NomeCausa = " ",
                                IdCausaPerda = -1,
                            };
                            return Causa;
                        }
                        else
                        {
                            dr.Read();

                            Causa = new ModProduto
                            {
                                NomeCausa = (dr["NomeCausa"]).ToString(),
                                IdCausaPerda = Convert.ToInt32((dr["IdCausaPerda"]).ToString()),
                            };

                            return Causa;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaCausaPerdaNome(string causa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaCausaPerdaNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Causa", causa);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaCausaPerdaTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaCausaPerdaTodos", objConexao))
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

        public void AtualizaCausaPerda(ModProduto objModPro)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaCausaPerda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCausa", objModPro.IdCausaPerda);
                        objCommand.Parameters.AddWithValue("@NomeCausa", objModPro.NomeCausa);
                        objCommand.Parameters.AddWithValue("@Situacao", objModPro.SituacaoCausa);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPro.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaCausaPerdaAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaCausaPerdaAtivos", objConexao))
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

        public ModProduto SelecionaProdutoParaPerdaCodigo(long codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("SelecionaProdutoParaPerdaCodigo", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto Produto = null;

                        if (!dr.HasRows)
                        {
                            Produto = new ModProduto
                            {
                                IdProduto = -1,
                            };
                            return Produto;
                        }
                        else
                        {
                            dr.Read();

                            Produto = new ModProduto
                            {
                                IdProduto = (long)dr["Id"],
                                CodBarras = (long)dr["Codigo"],
                                NomeProduto = dr["Nome"].ToString(),
                                ImagemProduto = (byte[])dr["Imagem"],
                            };

                            return Produto;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InserePerda(ModProduto objModPro)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InserePerda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idProduto", objModPro.IdProduto);
                        objCommand.Parameters.AddWithValue("@idCausa", objModPro.IdCausaPerda);
                        objCommand.Parameters.AddWithValue("@Qtd", objModPro.QtdPerda);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModPro.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaPerdas()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaPerdas", objConexao))
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

        //public void BaixaEstoque(Int64 idproduto, decimal qtd)
        //{
        //    try
        //    {
        //        using (var objConexao = clsDados.ConectaBanco())
        //        {
        //            using (var objCommand = new SqlCommand("BaixaEstoque", objConexao))
        //            {
        //                objCommand.CommandType = CommandType.StoredProcedure;

        //                objCommand.Parameters.AddWithValue("@IdProduto", idproduto);
        //                objCommand.Parameters.AddWithValue("@Qtd", qtd);

        //                clsDados.ExecutaComando(objCommand, objConexao);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
