﻿using SysPark.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPark.Controler
{
    public class BLVenda
    {
        public ModVenda BuscaVendaPorPlaca(string placa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaVendaPorPlaca", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Placa", placa);

                        var dt = clsDados.RetornaDados(objCommand);

                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.Rows[0];
                            ModVenda modVenda = new ModVenda
                            {
                                ID = Convert.ToInt64((row["ID"].ToString())),
                                Placa = row["Placa"].ToString(),
                                Descricao = row["Descricao"].ToString(),
                                IDTipoVeiculo = Convert.ToInt32(row["IDTipoVeiculo"].ToString()),
                                HoraEntrada = Convert.ToDateTime(row["HoraEntrada"].ToString()),
                                MinCortesia = Convert.ToInt32(row["MinCortesia"].ToString()),
                                IdVeiculoMensalista = Convert.ToInt64(row["IdVeiculoMensalista"].ToString()),
                            };
                            return modVenda;
                        }
                        else
                        {
                            return new ModVenda
                            {
                                ID = -1
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void InsereVeiculoMensalista(ModVeiculoMensalista modVeiculoMensalista)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereVeiculoMensalista", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        objCommand.Parameters.AddWithValue("@IDCliente", modVeiculoMensalista.idCliente);
                        objCommand.Parameters.AddWithValue("@Placa", modVeiculoMensalista.placa);
                        objCommand.Parameters.AddWithValue("@IDTipoVeiculo", modVeiculoMensalista.idTipoVeiculo);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void DeleteVeiculoMensalista(long ID)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("DeleteVeiculoMensalista", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@ID", ID);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public long VerificaVeiculoMensalista(string placa)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaVeiculoMensalista", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Placa", placa);

                        DataTable data = clsDados.RetornaDados(objCommand);

                        if (data.Rows.Count == 0)
                        {
                            return Convert.ToInt64( -1);
                        }
                        else
                        {
                            return Convert.ToInt64(data.Rows[0]["IDCliente"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaVeiculosMensalistas(long CPF)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaVeiculosMensalistas", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IDCliente", CPF);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsereVenda(ModVenda modVenda)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereVenda", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Placa", modVenda.Placa);
                        objCommand.Parameters.AddWithValue("@descricao", modVenda.Descricao);
                        
                        objCommand.Parameters.AddWithValue("@IDTipoVeiculo", modVenda.IDTipoVeiculo);
                        objCommand.Parameters.AddWithValue("@HoraEntrada", modVenda.HoraEntrada);
                        objCommand.Parameters.AddWithValue("@HoraValor", modVenda.HoraValor);
                        objCommand.Parameters.AddWithValue("@MinCortesia", modVenda.MinCortesia);
                        objCommand.Parameters.AddWithValue("@IdCaixaAbertura", modVenda.IdCaixaAbertura);
                        objCommand.Parameters.AddWithValue("@IdVeiculoMensalista", modVenda.IdVeiculoMensalista);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FechaVendaPorPlaca(ModVenda modVenda)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FechaVendaPorPlaca", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Placa", modVenda.Placa);
                        objCommand.Parameters.AddWithValue("@SubTotal", modVenda.SubTotal);
                        objCommand.Parameters.AddWithValue("@Desconto", modVenda.Desconto);
                        objCommand.Parameters.AddWithValue("@HoraSaida", modVenda.HoraSaida);
                        objCommand.Parameters.AddWithValue("@Dinheiro", modVenda.Dinheiro);
                        objCommand.Parameters.AddWithValue("@Credito", modVenda.Credito);
                        objCommand.Parameters.AddWithValue("@Debito", modVenda.Debito);
                        objCommand.Parameters.AddWithValue("@Cheque", modVenda.Cheque);
                        objCommand.Parameters.AddWithValue("@IdCaixaFechamento", modVenda.IdCaixaFechamento);

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
