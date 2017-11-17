using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLCargo
    {
        public void InsereCargo(ModCargo objModCargo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereCargo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", objModCargo.NomeCargo);
                        objCommand.Parameters.AddWithValue("@Situacao", objModCargo.SituacaoCargo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModCargo.NomeAtualiza);
                        
                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaCargo(string nomeCargo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaCargo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeCargo", nomeCargo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaCargoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaCargoTodos", objConexao))
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

        public void AtualizaCargo(ModCargo objModCargo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaCargo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCargo", objModCargo.IdCargo);
                        objCommand.Parameters.AddWithValue("@NomeCargo", objModCargo.NomeCargo);
                        objCommand.Parameters.AddWithValue("@SituacaoFuncao", objModCargo.SituacaoCargo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModCargo.NomeAtualiza);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaCargoAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaCargoAtivos", objConexao))
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

        public ModCargo VerificaCargoExiste(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCargoExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Cargo", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModCargo Cargo = null;

                        if (!dr.HasRows)
                        {
                            Cargo = new ModCargo
                            {
                                NomeCargo = " ",
                                IdCargo = -1,
                            };
                            return Cargo;
                        }
                        else
                        {
                            dr.Read();

                            Cargo = new ModCargo
                            {
                                NomeCargo = (dr["NomeCargo"]).ToString(),
                                IdCargo = Convert.ToInt32((dr["IdCargo"]).ToString()),                                
                            };

                            return Cargo;
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
