using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLOrdemServico
    {
        //================= SITUAÇÃO DE ORDEM DE SERVIÇO =====================

        public void InsereSituacaoOrdem(ModOrdemServico objOrdemServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereSituacaoOrdem", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", objOrdemServico.NomeSituacao);
                        objCommand.Parameters.AddWithValue("@Situacao", objOrdemServico.SituacaoOrdem);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objOrdemServico.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModOrdemServico Verifica_Situcao_Ordem_Existe(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Verifica_Situcao_Ordem_Existe", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@SituacaoOrdem", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModOrdemServico Ordem = null;

                        if (!dr.HasRows)
                        {
                            Ordem = new ModOrdemServico
                            {
                                NomeSituacao = " ",
                                IdSitucaoOrdem = -1,
                            };
                            return Ordem;
                        }
                        else
                        {
                            dr.Read();

                            Ordem = new ModOrdemServico
                            {
                                NomeSituacao = (dr["NomeSituacao"]).ToString(),
                                IdSitucaoOrdem = (int)dr["IdSituacaoServico"],
                            };

                            return Ordem;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaSituacaoOrdem(string nomeSituacao)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaSituacaoOrdem", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeSituacao", nomeSituacao);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaSituacaoOrdemTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaSituacaoOrdemTodos", objConexao))
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

        public void AtualizaSituacaoOrdem(ModOrdemServico objModOrdemServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaSituacaoOrdem", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSituacaoOrdem", objModOrdemServico.IdSitucaoOrdem);
                        objCommand.Parameters.AddWithValue("@NomeSituacao", objModOrdemServico.NomeSituacao);
                        objCommand.Parameters.AddWithValue("@Situacao", objModOrdemServico.SituacaoOrdem);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModOrdemServico.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Lista_Situacao_Ordem_Ativos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Lista_Situacao_Ordem_Ativos", objConexao))
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

        //================= ORDEM DE SERVIÇO ========================

        public ModProduto SelecionaItemCaixaCodigo(Int64 codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("SelecionaItemCaixaCodigo", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto objModMaterial = null;

                        if (!dr.HasRows)
                        {
                            objModMaterial = new ModProduto
                            {
                                IdProduto = -1,
                            };
                            return objModMaterial;
                        }
                        else
                        {
                            dr.Read();

                            objModMaterial = new ModProduto
                            {
                                IdProduto = Convert.ToInt64((dr["Id"]).ToString()),
                                CodBarras = Convert.ToInt64((dr["Codigo"]).ToString()),
                                NomeProduto = (dr["Nome"]).ToString(),
                                PrecoVenda = Convert.ToDecimal((dr["Preço"]).ToString()),
                                ImagemProduto = (byte[])dr["Imagem"],
                                Aliquota = dr["Aliquota"].ToString(),
                                Ibpt = (decimal)dr["IBPT"],
                            };
                            return objModMaterial;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModProduto SelecionaItemCaixaPromocaoCodigo(Int64 codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("SelecionaItemCaixaPromocaoCodigo", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto objModMaterial = null;

                        if (!dr.HasRows)
                        {
                            objModMaterial = new ModProduto
                            {
                                IdProduto = -1,
                            };
                            return objModMaterial;
                        }
                        else
                        {
                            dr.Read();

                            objModMaterial = new ModProduto
                            {
                                IdProduto = Convert.ToInt64((dr["Id"]).ToString()),
                                CodBarras = Convert.ToInt64((dr["Codigo"]).ToString()),
                                NomeProduto = (dr["Nome"]).ToString(),
                                PrecoVenda = Convert.ToDecimal((dr["Preço"]).ToString()),
                                ImagemProduto = (byte[])dr["Imagem"],
                                Aliquota = dr["Aliquota"].ToString(),
                                Ibpt = (decimal)dr["IBPT"],
                            };
                            return objModMaterial;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaItemNaPromocao(Int64 codProduto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaItemNaPromocao", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodProduto", codProduto);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insere_Item_Na_OrdemServico(ModProduto Item)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Insere_Item_Na_OrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodigoItem", Item.CodigoItem);
                        objCommand.Parameters.AddWithValue("@IdOrdem", Item.IdOrdemServico);
                        objCommand.Parameters.AddWithValue("@IdProduto", Item.IdProduto);
                        objCommand.Parameters.AddWithValue("@PrecoUnitario", Item.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@Qtd", Item.QtdVenda);
                        objCommand.Parameters.AddWithValue("@TotalItem", Item.TotalItem);
                        objCommand.Parameters.AddWithValue("@DescontoFidel", Item.DescontoFidelidade);
                        objCommand.Parameters.AddWithValue("@ItemCancelado", Item.ItemCancelado);
                        objCommand.Parameters.AddWithValue("@idOperadorCancel", Item.IdOperadorCancel);
                        objCommand.Parameters.AddWithValue("@idOperadorDesc", Item.IdOperadorDesc);
                        objCommand.Parameters.AddWithValue("@DescontoItem", Item.DescontoItem);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaItensOrdemServico(long idOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public long AbreOrdemServico(ModOrdemServico objServico)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCpfOperador", objServico.IdFuncionario);
                        objCommand.Parameters.AddWithValue("@IdCpfCliente", objServico.IdCliente);
                        objCommand.Parameters.AddWithValue("@NomeProduto", objServico.NomeProduto);
                        objCommand.Parameters.AddWithValue("@CodigoIdent", objServico.CodigoIdent);
                        objCommand.Parameters.AddWithValue("@NumSerie", objServico.NumSerie);
                        objCommand.Parameters.AddWithValue("@Marca", objServico.Marca);
                        objCommand.Parameters.AddWithValue("@ModeloProduto", objServico.Modelo);
                        objCommand.Parameters.AddWithValue("@DataOrdem", objServico.DataOrdem);
                        objCommand.Parameters.AddWithValue("@DataEntrada", objServico.DateEntrada);
                        objCommand.Parameters.AddWithValue("@idSituacao", objServico.IdSitucaoOrdem);

                        var dt = clsDados.RetornaDados(objCommand);

                        long idSacola = 0;

                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.Rows[0];
                            idSacola = Convert.ToInt64((row["IdOrdem"].ToString()));
                            return idSacola;
                        }
                        else
                        {
                            idSacola = -1;
                            return idSacola;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ConfirmarOrdemServico(long idOrdem, decimal subTotal, decimal desconto, decimal total, int condicao)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ConfirmarOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);
                        objCommand.Parameters.AddWithValue("@Subtotal", subTotal);
                        objCommand.Parameters.AddWithValue("@Desconto", desconto);
                        objCommand.Parameters.AddWithValue("@Total", total);
                        objCommand.Parameters.AddWithValue("@Condicao", condicao);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualiza_Situacao_OrdemServico(long idOrdem, int idSituacao)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Atualiza_Situacao_OrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);
                        objCommand.Parameters.AddWithValue("@IdSituacao", idSituacao);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CancelaItemOrdemServico(long idItemOrdem, long idOrdem, long idOperadorCancel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaItemOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdItemOrdem", idItemOrdem);
                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);
                        objCommand.Parameters.AddWithValue("@IdOperadorCancel", idOperadorCancel);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizarOrdemServico(long idOrdem, decimal subTotal, decimal desconto, decimal total, int idSituacao, int condOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizarOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);
                        objCommand.Parameters.AddWithValue("@Subtotal", subTotal);
                        objCommand.Parameters.AddWithValue("@Desconto", desconto);
                        objCommand.Parameters.AddWithValue("@Total", total);
                        objCommand.Parameters.AddWithValue("@IdSituacaoOrdem", idSituacao);
                        objCommand.Parameters.AddWithValue("@CondOrdem", condOrdem);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaOrdemServicoTodas()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaOrdemServicoTodas", objConexao))
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

        public DataTable BuscaOrdemServicoProduto(string produto)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaOrdemServicoProduto", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Produto", produto);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaOrdemServicoCliente(string cliente)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaOrdemServicoCliente", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Cliente", cliente);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaOrdemServicoNumeroOrdem(long idOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaOrdemServicoNumeroOrdem", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NumOrdem", idOrdem);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }        

        public ModOrdemServico PegaOrdemServicoIDOrdem(long idOrdem)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaOrdemServicoIDOrdem", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModOrdemServico Ordem = null;

                        if (!dr.HasRows)
                        {
                            Ordem = new ModOrdemServico
                            {
                                IdOrdem = -1,
                            };
                            return Ordem;
                        }
                        else
                        {
                            dr.Read();

                            Ordem = new ModOrdemServico
                            {
                                IdOrdem = (long)dr["Nº Ordem"],
                                CodigoIdent = (dr["Identificação"]).ToString(),
                                NumSerie = dr["NumeroSerie"].ToString(),
                                NomeProduto = dr["Produto"].ToString(),
                                Marca = dr["Marca"].ToString(),
                                Modelo = dr["Modelo"].ToString(),
                                IdSitucaoOrdem = (int)dr["IdSituação"],

                                DateRetirada = (dr["DataRetirada"] == DBNull.Value) 
                                             ? (DateTime?)null
                                             : Convert.ToDateTime(dr["DataRetirada"]),

                                DateEntrada = Convert.ToDateTime(dr["DataEntrada"]),
                                DataOrdem = Convert.ToDateTime(dr["DataEmissão"]),
                                IdCliente = (long)dr["IdCliente"],
                                IdFuncionario = (long)dr["IdOperador"],
                                CondicaoOrdem = (int)dr["Condição"],
                            };

                            return Ordem; 
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModCliente PegaClientesOrdemServico(long idOrdem)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaClientesOrdemServico", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModCliente Cliente = null;

                        if (!dr.HasRows)
                        {
                            Cliente = new ModCliente
                            {
                                IdcpfcnpjPessoa = -1,
                            };
                            return Cliente;
                        }
                        else
                        {
                            dr.Read();

                            Cliente = new ModCliente
                            {
                                IdcpfcnpjPessoa = (long)dr["CPF"],
                                NomePessoa = (dr["Nome"]).ToString(),
                                Rg = dr["RG"].ToString(),

                                Logradouro = dr["Endereço"].ToString(),
                                NumeroEnd = (int)dr["Numero"],
                                Bairro = dr["Bairro"].ToString(),
                                Cidade = dr["Cidade"].ToString(),
                                Cep = dr["CEP"].ToString(),
                                UF = (dr["UF"]).ToString(),

                                Telefone = (dr["Telefone"]).ToString(),
                                Celular = dr["Celular"].ToString(),
                                Email = dr["Email"].ToString(),
                            };

                            return Cliente;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FinalizarOrdemServico(long idOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FinalizarOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CancelaOrdemServico(long idOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaOrdemServico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaItensOrdemServicoImpressao(long idOrdem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensOrdemServicoImpressao", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrdem", idOrdem);

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
