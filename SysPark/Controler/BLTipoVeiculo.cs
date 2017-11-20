using SysPark.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPark.Controler
{
    public class BLTipoVeiculo
    {
        public void InsereTipoVeiculo(ModTipoVeiculo objModTipoVeiculo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereTipoVeiculo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        objCommand.Parameters.AddWithValue("@Descrição", objModTipoVeiculo.Descrição);
                        objCommand.Parameters.AddWithValue("@ValorHora", objModTipoVeiculo.ValorHora);
                        objCommand.Parameters.AddWithValue("@CortesiaAte", objModTipoVeiculo.CortesiaAte);
                        objCommand.Parameters.AddWithValue("@Ativo", objModTipoVeiculo.Ativo);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

            public ModTipoVeiculo BuscaTipoVeiculoPorID(int id)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaTipoVeiculoPorID", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@ID", id);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        ModTipoVeiculo modTipoVeiculo = new ModTipoVeiculo();

                        while (dr.Read())
                        {
                            modTipoVeiculo = new ModTipoVeiculo
                            {
                                Descrição = dr["Descrição"].ToString(),
                                Ativo = true,
                                CortesiaAte = Convert.ToInt32( dr["Minutos de Cortesia"]),
                                IdTipo = Convert.ToInt32(dr["ID"]),
                                ValorHora = Convert.ToDecimal(dr["Valor da hora"])
                            };
                        }

                        return modTipoVeiculo;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaTipoVeiculo(string nomeTipoVeiculo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaTipoVeiculo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Descricao", nomeTipoVeiculo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaTipoVeiculoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaTipoVeiculoTodos", objConexao))
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

        public List<KeyValuePair<string, int>> BuscaTipoVeiculoAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaTipoVeiculoAtivos", objConexao))
                    {
                        var listTipoVeiculo = new List<KeyValuePair<string, int>>();

                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        while (dr.Read())
                        {
                            listTipoVeiculo.Add(new KeyValuePair<string, int>(dr["Descrição"].ToString(), Convert.ToInt32(dr["ID"])));
                        }

                        return listTipoVeiculo;


                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaTipoVeiculo(ModTipoVeiculo objTipoVeiculo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaTipoVeiculo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdTipo", objTipoVeiculo.IdTipo);
                        objCommand.Parameters.AddWithValue("@Descrição", objTipoVeiculo.Descrição);
                        objCommand.Parameters.AddWithValue("@ValorHora", objTipoVeiculo.ValorHora);
                        objCommand.Parameters.AddWithValue("@CortesiaAte", objTipoVeiculo.CortesiaAte);
                        objCommand.Parameters.AddWithValue("@Ativo", objTipoVeiculo.Ativo);

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
