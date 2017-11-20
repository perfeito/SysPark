using SysPark.Model;
using System;
using System.Data;
using System.Data.SqlClient;


namespace SysPark.Controler
{
    public class BLCaixa
    {

        public ModCaixa SelecionaValeTrocaCaixa(long idvale)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("SelecionaValeTrocaCaixa", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdVale", idvale);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModCaixa objModCaixa = null;

                        if (!dr.HasRows)
                        {
                            objModCaixa = new ModCaixa
                            {
                                IdValeTroca = -1,
                            };
                            return objModCaixa;
                        }
                        else
                        {
                            dr.Read();

                            objModCaixa = new ModCaixa
                            {
                                IdValeTroca = (long)(dr["Id"]),
                                ValorValeTroca = (decimal)(dr["Valor"]),
                                ValeCancelado = (bool)(dr["Cancelado"]),
                                ValeResgatado = (bool)(dr["Resgatado"]),

                            };
                            return objModCaixa;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BaixaEstoque(long idproduto, decimal qtd)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BaixaEstoque", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdProduto", idproduto);
                        objCommand.Parameters.AddWithValue("@Qtd", qtd);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AbreCaixa(decimal troco, Int64 operador, int terminal, DateTime dataAbertura, Int64 idMovimento)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreCaixa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Troco", troco);
                        objCommand.Parameters.AddWithValue("@IdCpfOperador", operador);
                        objCommand.Parameters.AddWithValue("@IdTerminal", terminal);
                        objCommand.Parameters.AddWithValue("@DataAbertura", dataAbertura);
                        objCommand.Parameters.AddWithValue("@IdMovimentoDia", idMovimento);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModCaixa PegaOperadorCaixaAberto(int idterminal)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaOperadorCaixaAberto", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                         
                        objCommand.Parameters.AddWithValue("@IdTerminal", idterminal); 

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModCaixa objModMaterial = null;

                        if (!dr.HasRows)
                        {
                            objModMaterial = new ModCaixa
                            {
                                IdCaixa = -1,
                            };
                            return objModMaterial;
                        }
                        else
                        {
                            dr.Read();

                            objModMaterial = new ModCaixa
                            {
                                IdCaixa = Convert.ToInt64((dr["IdCaixa"]).ToString()),
                                
                                IdcpfcnpjPessoa = Convert.ToInt64((dr["IdCpfOperador"]).ToString()),
                                NomeTerminal = (dr["NomeTerminal"]).ToString(),
                                NomePessoa = (dr["NomePessoa"]).ToString(),
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

        public void FechaVenda(ModCaixa objModCaixa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FechaVenda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;



                        objCommand.Parameters.AddWithValue("@IDVENDA", objModCaixa.IdVenda);                        
                        objCommand.Parameters.AddWithValue("@DINHEIRO", objModCaixa.Dinheiro);
                        objCommand.Parameters.AddWithValue("@CREDITO", objModCaixa.Credito);
                        objCommand.Parameters.AddWithValue("@DEBITO", objModCaixa.Debito);
                        objCommand.Parameters.AddWithValue("@CHEQUE", objModCaixa.Cheque);
                        objCommand.Parameters.AddWithValue("@VALORRECEBIDO", objModCaixa.ValorRecebido);
                        objCommand.Parameters.AddWithValue("@TROCO", objModCaixa.Troco);
                        objCommand.Parameters.AddWithValue("@VALORTOTAL", objModCaixa.ValorTotal);
                        objCommand.Parameters.AddWithValue("@DESCONTO", objModCaixa.DescontoVenda);
                        objCommand.Parameters.AddWithValue("@QTDITEM", objModCaixa.QtdItem);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaCaixa(ModCaixa objModCaixa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaCaixa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCaixa", objModCaixa.IdCaixa); 
                        objCommand.Parameters.AddWithValue("@Dinheiro", objModCaixa.Dinheiro);
                        objCommand.Parameters.AddWithValue("@Credito", objModCaixa.Credito);
                        objCommand.Parameters.AddWithValue("@Debito", objModCaixa.Debito);
                        objCommand.Parameters.AddWithValue("@Cheque", objModCaixa.Cheque);
                        objCommand.Parameters.AddWithValue("@Troco", objModCaixa.Troco);
                        objCommand.Parameters.AddWithValue("@Outros", objModCaixa.Outros);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public void InsereItemNaVenda(ModProduto Item)
        //{
        //    try
        //    {
        //        using (var objConexao = clsDados.ConectaBanco())
        //        {
        //            using (var objCommand = new SqlCommand("InsereItemNaVenda", objConexao))
        //            {
        //                objCommand.CommandType = CommandType.StoredProcedure;

        //                objCommand.Parameters.AddWithValue("@CodigoItem", Item.CodBarras);
        //                objCommand.Parameters.AddWithValue("@IdVenda", Item.IdVenda);
        //                objCommand.Parameters.AddWithValue("@IdProduto", Item.IdProduto);
        //                objCommand.Parameters.AddWithValue("@PrecoUnitario", Item.PrecoVenda);
        //                objCommand.Parameters.AddWithValue("@Qtd", Item.QtdVenda);
        //                objCommand.Parameters.AddWithValue("@TotalItem", Item.TotalItem);
        //                objCommand.Parameters.AddWithValue("@DescontoItem", Item.DescontoItem);
        //                objCommand.Parameters.AddWithValue("@DescontoFidel", Item.DescontoFidelidade);
        //                objCommand.Parameters.AddWithValue("@ItemCancelado", Item.ItemCancelado);
        //                objCommand.Parameters.AddWithValue("@idOperadorDesc", Item.IdOperadorDesc);
        //                objCommand.Parameters.AddWithValue("@idOperadorCancel", Item.IdOperadorCancel);

        //                clsDados.ExecutaComando(objCommand, objConexao);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public DataTable ListaItensVenda(Int64 idvenda)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensVenda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdVenda", idvenda);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public void CancelaItem(Int64 idItemvenda, Int64 idVenda, Int64 idOperadorCancel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaItem", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdItemVenda", idItemvenda);
                        objCommand.Parameters.AddWithValue("@IdVenda", idVenda);
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

        public void CancelaUltimaVenda(Int64 idCaixa, Int64 idVenda, Int64 idOperadorCancel)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CancelaUltimaVenda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCaixa", idCaixa);
                        objCommand.Parameters.AddWithValue("@IdVenda", idVenda);
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

        public DataTable ListaItensBaixaEstoque(Int64 idvenda)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaItensBaixaEstoque", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdVenda", idvenda);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModCaixa BuscaValoresCaixa(Int64 idcaixa)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaValoresCaixa", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCaixa", idcaixa);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModCaixa objModCaixa = null;

                        if (!dr.HasRows)
                        {
                            objModCaixa = new ModCaixa
                            {
                                IdCaixa = -1,
                            };
                            return objModCaixa;
                        }
                        else
                        {
                            dr.Read();

                            objModCaixa = new ModCaixa
                            {
                                Dinheiro = (decimal)(dr["Dinheiro"]),
                                Credito = (decimal)(dr["Credito"]),
                                Debito = (decimal)(dr["Debito"]),
                                Cheque = (decimal)(dr["Cheque"]),
                                Troco = (decimal)(dr["Troco"]),
                                DescontoVenda = (decimal)(dr["Desconto"])
                            };
                            return objModCaixa;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FechaCaixa(ModCaixa objModCaixa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FechaCaixa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCaixa", objModCaixa.IdCaixa);
                        objCommand.Parameters.AddWithValue("@DataFechamento", objModCaixa.DataFechamento);                                              

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public ModProdutoServico PegaUltimaVendaCancelar(int terminal)
        //{
        //    try
        //    {
        //        using (var objConn = clsDados.ConectaBanco())
        //        {
        //            using (var objCommand = new SqlCommand("PegaUltimaVendaCancelar", objConn))
        //            {
        //                objCommand.CommandType = CommandType.StoredProcedure;

        //                objCommand.Parameters.AddWithValue("@idTerminal", terminal); 

        //                var dr = clsDados.RetornaDadosReader(objCommand, objConn);

        //                ModProdutoServico objModMaterial = null;

        //                if (!dr.HasRows)
        //                {
        //                    objModMaterial = new ModProdutoServico
        //                    {
        //                        IdCaixa = -1,
        //                    };
        //                    return objModMaterial;
        //                }
        //                else
        //                {
        //                    dr.Read();

        //                    objModMaterial = new ModProdutoServico
        //                    {
        //                        IdCaixa = (Int64)dr["IdCaixa"],
        //                        IdVenda = (Int64)dr["IdVenda"],
        //                        IdOperadorCancel = (Int64)dr["OpCancel"],
        //                        Dinheiro = (decimal)dr["Dinheiro"],
        //                        Debito = (decimal)dr["Debito"],
        //                        Credito = (decimal)dr["Credito"],
        //                        Cheque = (decimal)dr["Cheque"],
        //                        Troco = (decimal)dr["Troco"],
        //                    };
        //                    return objModMaterial;
        //                }

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public bool VerificaCaixaAbertoPorTerminal(int terminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCaixaAbertoPorTerminal", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTerminal", terminal);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaItemUnico(long idvenda)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaItemUnico", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdVenda", idvenda);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 1;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public DataTable ListaCaixasParaContagem(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaCaixasParaContagem", objConexao))
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

        public void ContagemDeCaixa(ModCaixa objModCaixa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ContagemDeCaixa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCaixa", objModCaixa.IdCaixa);
                        objCommand.Parameters.AddWithValue("@Dinheiro", objModCaixa.DinheiroContado);
                        objCommand.Parameters.AddWithValue("@Credito", objModCaixa.CreditoContado);
                        objCommand.Parameters.AddWithValue("@Debito", objModCaixa.DebitoContado);
                        objCommand.Parameters.AddWithValue("@Cheque", objModCaixa.ChequeContado);
                        objCommand.Parameters.AddWithValue("@Idusuario", objModCaixa.IdcpfcnpjPessoa);
                        objCommand.Parameters.AddWithValue("@Outros", objModCaixa.Outros);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable RelatorioCaixa(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("RelatorioCaixa", objConexao))
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

        public DataTable RelatorioCaixaUltimoMovimento()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("RelatorioCaixaUltimoMovimento", objConexao))
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

        public DataTable Relatorio_Venda_Maiores_Valores(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Venda_Maiores_Valores", objConexao))
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

        public DataTable Relatorio_Venda_Menores_Valores(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Venda_Menores_Valores", objConexao))
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

        public DataTable Relatorio_Vendas_Canceladas(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Vendas_Canceladas", objConexao))
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

        public DataTable Relatorio_Itens_Cancelados(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Itens_Cancelados", objConexao))
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

        public DataTable Relatorio_Precos_Modificados(DateTime inicio, DateTime fim)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Relatorio_Precos_Modificados", objConexao))
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
    }
}
