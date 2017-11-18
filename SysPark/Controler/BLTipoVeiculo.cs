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

        public DataTable BuscaTipoVeiculoAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaTipoVeiculoAtivos", objConexao))
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
