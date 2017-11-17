using SysPark.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLGrupo
    {
        public void InsereGrupo(ModGrupo objModGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", objModGrupo.NomeGrupo);
                        objCommand.Parameters.AddWithValue("@Situacao", objModGrupo.SitGrupo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModGrupo.NomeAtualiza);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaGrupo(string nomeGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeGrupo", nomeGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaGrupoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaGrupoTodos", objConexao))
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

        public void AtualizaGrupo(ModGrupo objModGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdGrupo", objModGrupo.IdGRupo);
                        objCommand.Parameters.AddWithValue("@NomeGrupo", objModGrupo.NomeGrupo);
                        objCommand.Parameters.AddWithValue("@SituacaoFuncao", objModGrupo.SitGrupo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModGrupo.NomeAtualiza);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaGrupoAtivos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaGrupoAtivos", objConexao))
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

        public List<KeyValuePair<string, int>> ListaGrupoAtivos()
        {
            var listCaixa = new List<KeyValuePair<string, int>>();

            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaGrupoAtivos", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;                        

                        clsDados.ExecutaComando(objCommand, objConn);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        while (dr.Read())
                        {
                            listCaixa.Add(new KeyValuePair<string, int>(dr["NomeGrupo"].ToString(), Convert.ToInt32(dr["IdGrupo"])));
                        }

                        listCaixa.Add(new KeyValuePair<string, int>("Todos", -1));

                        return listCaixa;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void InsereSubGrupo(ModGrupo objModGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereSubGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", objModGrupo.NomeSubGrupo);
                        objCommand.Parameters.AddWithValue("@Situacao", objModGrupo.SitSubGrupo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModGrupo.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModGrupo.IdGRupo);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaSubGrupo(string nomeGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaSubGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeSubGrupo", nomeGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaSubGrupoTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaSubGrupoTodos", objConexao))
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

        public void AtualizaSubGrupo(ModGrupo objModGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaSubGrupo", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdSubGrupo", objModGrupo.IdSubGRupo);
                        objCommand.Parameters.AddWithValue("@NomeGrupo", objModGrupo.NomeSubGrupo);
                        objCommand.Parameters.AddWithValue("@SituacaoFuncao", objModGrupo.SitSubGrupo);
                        objCommand.Parameters.AddWithValue("@NomeAtualiza", objModGrupo.NomeAtualiza);
                        objCommand.Parameters.AddWithValue("@IdGrupo", objModGrupo.IdGRupo);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaSubGrupoAtivos(int idGrupo)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaSubGrupoAtivos", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdGrupo", idGrupo);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<KeyValuePair<string, int>> ListaSubGrupoAtivos(int idGrupo)
        {
            var listCaixa = new List<KeyValuePair<string, int>>();

            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("ListaSubGrupoAtivos", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdGrupo", idGrupo);

                        clsDados.ExecutaComando(objCommand, objConn);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        while (dr.Read())
                        {
                            listCaixa.Add(new KeyValuePair<string, int>(dr["NomeSubGrupo"].ToString(), Convert.ToInt32(dr["IdSubGrupo"])));
                        }

                        listCaixa.Add(new KeyValuePair<string, int>("Todos", -1));

                        return listCaixa;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
        
        public ModGrupo VerificaGrupoExiste(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaGrupoExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Grupo", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModGrupo Grupo = null;

                        if (!dr.HasRows)
                        {
                            Grupo = new ModGrupo
                            {
                                NomeGrupo = " ",
                                IdGRupo = -1,
                            };
                            return Grupo;
                        }
                        else
                        {
                            dr.Read();

                            Grupo = new ModGrupo
                            {
                                NomeGrupo = (dr["NomeGrupo"]).ToString(),
                                IdGRupo = Convert.ToInt32((dr["IdGrupo"]).ToString()),
                            };

                            return Grupo;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public ModGrupo VerificaSubGrupoExiste(string nome)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaSubGrupoExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@SubGrupo", nome);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModGrupo Grupo = null;

                        if (!dr.HasRows)
                        {
                            Grupo = new ModGrupo
                            {
                                NomeSubGrupo = " ",
                                IdSubGRupo = -1,
                            };
                            return Grupo;
                        }
                        else
                        {
                            dr.Read();

                            Grupo = new ModGrupo
                            {
                                NomeSubGrupo = (dr["NomeSubGrupo"]).ToString(),
                                IdSubGRupo = Convert.ToInt32((dr["IdSubGrupo"]).ToString()),
                            };

                            return Grupo;
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
