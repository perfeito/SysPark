using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.View
{
    public class BLSacola
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

        public long AbreSacola(long operador, long cliente, long codsacola)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCpfOperador", operador);
                        objCommand.Parameters.AddWithValue("@IdCpfCliente", cliente);
                        objCommand.Parameters.AddWithValue("@CodSacola", codsacola);

                        var dt = clsDados.RetornaDados(objCommand);

                        long idSacola = 0;

                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.Rows[0];
                            idSacola = Convert.ToInt64((row["IdSacola"].ToString()));
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

        public void Insere_Item_Na_Sacola(ModProduto Item)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Insere_Item_Na_Sacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodigoItem", Item.CodigoItem);
                        objCommand.Parameters.AddWithValue("@IdSacola", Item.IdSacola);
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

        public DataTable ListaItensSacola(long idSacola)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSacola", idSacola);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaCodigoSacolaAtiva(Int64 codSacola)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCodigoSacolaAtiva", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodSacola", codSacola);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ConfirmaSacola(long idSacola, decimal valor, int qtditem)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ConfirmaSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSacola", idSacola);
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

        public void CancelaSacola(long idSacola, long idFuncionario)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSacola", idSacola);
                        objCommand.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaItemPraCancelarSacola(long idSacola)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItemPraCancelarSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSacola", idSacola);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CancelaItemSacola(long idItemSacola, long idSacola, long idOperadorCancel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaItemSacola", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdItemSacola", idItemSacola);
                        objCommand.Parameters.AddWithValue("@IdSacola", idSacola);
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

        public DataTable ListaSacolasAtivas()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaSacolasAtivas", objConexao))
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

        public DataTable ListaSacolasAtivasPorCodigo(long codSacola)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaSacolasAtivasPorCodigo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodigoSacola", codSacola);

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
