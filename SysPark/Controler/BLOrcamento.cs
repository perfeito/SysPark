using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.View
{
    public class BLOrcamento
    {
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

        public long AbreOrcamento(long operador, long cliente)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreOrcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        objCommand.Parameters.AddWithValue("@IdCpfOperador", operador);
                        objCommand.Parameters.AddWithValue("@IdCpfCliente", cliente);

                        var dt = clsDados.RetornaDados(objCommand);

                        long idOrcamento = 0;

                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.Rows[0];
                            idOrcamento = Convert.ToInt64((row["IdOrçamento"].ToString()));
                            return idOrcamento;
                        }
                        else
                        {
                            idOrcamento = -1;
                            return idOrcamento;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insere_Item_No_Orcamento(ModProduto Item)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Insere_Item_No_Orcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodigoItem", Item.CodigoItem);
                        objCommand.Parameters.AddWithValue("@IdOrcamento", Item.IdOrcamento);
                        objCommand.Parameters.AddWithValue("@IdProduto", Item.IdProduto);
                        objCommand.Parameters.AddWithValue("@PrecoUnitario", Item.PrecoVenda);
                        objCommand.Parameters.AddWithValue("@Qtd", Item.QtdVenda);
                        objCommand.Parameters.AddWithValue("@TotalItem", Item.TotalItem);                       
                        objCommand.Parameters.AddWithValue("@DescontoFidel", Item.DescontoFidelidade);
                        objCommand.Parameters.AddWithValue("@ItemCancelado", Item.ItemCancelado);                        
                        objCommand.Parameters.AddWithValue("@idOperadorCancel", Item.IdOperadorCancel);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaItensOrcamento(long idOrcamento)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensOrcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModProduto PegaItemPraCancelarOrcamento(long codigo, long idOrcamento)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaItemPraCancelarOrcamento", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);
                        objCommand.Parameters.AddWithValue("@Codigo", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModProduto objModMaterial = null;

                        if (!dr.HasRows)
                        {
                            objModMaterial = new ModProduto
                            {
                                IdItemOrcamento = -1,
                            };
                            return objModMaterial;
                        }
                        else
                        {
                            dr.Read();

                            objModMaterial = new ModProduto
                            {
                                IdItemOrcamento = Convert.ToInt64((dr["IdItem"]).ToString()),
                                CodBarras = Convert.ToInt64((dr["Código"]).ToString()),
                                NomeProduto = (dr["Nome"]).ToString(),
                                PrecoVenda = Convert.ToDecimal((dr["Preço"]).ToString()),
                                QtdVenda = Convert.ToDecimal((dr["Qtd"]).ToString()),
                                TotalItem = Convert.ToDecimal((dr["Total"]).ToString()),
                                CodigoItem = (int)dr["Cod. Item"],
                                DescontoFidelidade = (decimal)dr["DescFidel"],
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

        public DataTable ListaItemPraCancelarOrcamento(long idOrcamento)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItemPraCancelarOrcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CancelaItemOrcamento(long idItemOrcamento, long idOrcamento, long idOperadorCancel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaItemOrcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdItemOrcamento", idItemOrcamento);
                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);
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

        public DataTable Pega_Orcamento_Para_Imprimir(long idOrcamento)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Pega_Orcamento_Para_Imprimir", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FechaOrcamento(long idOrcamento, decimal valor,  int qtditem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FechaOrcamento", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdOrcamento", idOrcamento);
                        objCommand.Parameters.AddWithValue("@Valor", valor);
                        objCommand.Parameters.AddWithValue("@QtdItem", qtditem);

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
