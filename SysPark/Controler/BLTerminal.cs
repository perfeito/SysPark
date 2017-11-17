using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLTerminal
    {
        public int InsereTerminal(string terminal, string mac, bool situacao)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereTerminal", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        objCommand.Parameters.AddWithValue("@NomeTerminal", terminal);
                        objCommand.Parameters.AddWithValue("@MAC", mac);
                        objCommand.Parameters.AddWithValue("@Situacao", situacao);

                        var objSqlDataReader = clsDados.RetornaDadosReader(objCommand, objConexao);

                        var idTerminal = -1;

                        while (objSqlDataReader.Read())
                        {
                            idTerminal = Convert.ToInt32(objSqlDataReader["IDTerminal"]);
                        }

                        return idTerminal;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaTerminal(string terminal, int idTerminal, bool situacao)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaTerminal", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeTerminal", terminal);
                        objCommand.Parameters.AddWithValue("@Situacao", situacao);
                        objCommand.Parameters.AddWithValue("@IdTerminal", idTerminal);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaTerminal()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaTerminal", objConexao))
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

        public int BuscaTerminalPorMac(string mac)
        {
            using (var objConexao = clsDados.ConectaBanco())
            {
                using (var objCommand = new SqlCommand("BuscaTerminalPorMac", objConexao))
                {
                    try
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Mac", mac);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        int idterminal = -1;

                        if (!dr.HasRows)
                        {
                            return idterminal;
                        }
                        else
                        {
                            dr.Read();

                            idterminal = Convert.ToInt32(dr["IdTerminal"].ToString());

                            return idterminal;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public ModGeral VerificaTerminalExiste(string terminal)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaTerminalExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeTerminal", terminal);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModGeral Geral = null;

                        if (!dr.HasRows)
                        {
                            Geral = new ModGeral
                            {
                                NomeTerminal = " ",
                                Mac = " ",
                            };
                            return Geral;
                        }
                        else
                        {
                            dr.Read();

                            Geral = new ModGeral
                            {
                                NomeTerminal = (dr["NomeTerminal"]).ToString(),
                                Mac = (dr["MAC"]).ToString(),
                                IdTerminal = Convert.ToInt32(dr["IdTerminal"])
                            };

                            return Geral;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }     
           
        public bool VerificaTerminalExisteMAC(string mac)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaTerminalExisteMAC", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@MAC", mac);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
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
