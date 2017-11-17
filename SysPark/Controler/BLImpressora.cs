using System;
using System.Data;
using System.Data.SqlClient;


namespace SysPark.Controler
{
    public class BLImpressora
    {
        public ModImpressora VerificaImpressoraUsoCaixa(int idTerminal)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaImpressoraUsoCaixa", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdTerminal", idTerminal);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModImpressora Imp = null;

                        if (!dr.HasRows)
                        {
                            Imp = new ModImpressora
                            {
                                Marca = " ",
                                IdImpressora = -1,
                            };
                            return Imp;
                        }
                        else
                        {
                            dr.Read();

                            Imp = new ModImpressora
                            {
                                Marca = dr["Marca"].ToString(),
                                IdImpressora = (Int32)dr["IdImpressora"],
                                IdImpTer = (Int32)dr["IdImpTer"],
                            };

                            return Imp;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CadastraImpressora(ModImpressora objModImp)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("CadastraImpressora", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Marca", objModImp.Marca);
                        objCommand.Parameters.AddWithValue("@Situacao", objModImp.SituacaoImpressora);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModImp.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 

        public DataTable BuscaImpressora(string marca)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaImpressora", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Marca", marca);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaImpressoraTodas()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaImpressoraTodas", objConexao))
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

        public void AtualizaImpressora(ModImpressora objModImp)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaImpressora", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdImpressora", objModImp.IdImpressora);
                        objCommand.Parameters.AddWithValue("@Marca", objModImp.Marca);
                        objCommand.Parameters.AddWithValue("@SituacaoImp", objModImp.SituacaoImpressora);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModImp.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaImpressorasAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaImpressorasAtivos", objConexao))
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

        public ModImpressora VerificaImpressoraExiste(string marca)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaImpressoraExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Marca", marca);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModImpressora Imp = null;

                        if (!dr.HasRows)
                        {
                            Imp = new ModImpressora
                            {
                                Marca = " ",
                                IdImpressora = -1,
                            };
                            return Imp;
                        }
                        else
                        {
                            dr.Read();

                            Imp = new ModImpressora
                            {
                                Marca = dr["Marca"].ToString(),
                                IdImpressora = (Int32)dr["IdImpressora"],
                            };

                            return Imp;
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
