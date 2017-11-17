using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLLogin
    {
        public ModFuncionario VerificaAutorizacaoFuncionario(Int64 codigo)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaAutorizacaoFuncionario", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CodFunc", codigo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModFuncionario objModFuncionario = null;

                        if (!dr.HasRows)
                        {
                            objModFuncionario = new ModFuncionario
                            {
                                Usuario = " ",
                                Senha = " ",
                                CodFunc = -1,
                            };
                            return objModFuncionario;
                        }
                        else
                        {
                            dr.Read();

                            objModFuncionario = new ModFuncionario
                            {
                                Usuario = dr["Usuario"].ToString(),
                                Senha = dr["Senha"].ToString(),
                                NomePessoa = dr["NomePessoa"].ToString(),
                                IdcpfcnpjPessoa = (Int64)dr["IdcpfcnpjPessoa"],
                                CodFunc = (Int64)dr["CodFunc"],
                            };

                            return objModFuncionario;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsereLogin(ModFuncionario objModFuncionario, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereLogin", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Usuario", objModFuncionario.Usuario);
                        objCommand.Parameters.AddWithValue("@Senha", objModFuncionario.Senha);
                        objCommand.Parameters.AddWithValue("@CpfFuncionario", objModPessoas.IdcpfcnpjPessoa);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 

        public void AtualizaLogin(ModFuncionario objModFuncionario, ModPessoas objModPessoas)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaLogin", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Usuario", objModFuncionario.Usuario);
                        objCommand.Parameters.AddWithValue("@Senha", objModFuncionario.Senha);
                        objCommand.Parameters.AddWithValue("@CpfFuncionario", objModPessoas.IdcpfcnpjPessoa);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public bool VerificaLoginExiste(ModFuncionario objModFuncionario)
        //{
        //    try
        //    {
        //        using (var objConexao = clsDados.ConectaBanco())
        //        {
        //            using (var objCommand = new SqlCommand("VerificaLoginExiste", objConexao))
        //            {
        //                objCommand.CommandType = CommandType.StoredProcedure;

        //                objCommand.Parameters.AddWithValue("@Usuario", objModFuncionario.Usuario);

        //                return clsDados.RetornaDados(objCommand).Rows.Count > 0;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public ModFuncionario VerificaLoginExiste(string usuario)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaLoginExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Usuario", usuario);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModFuncionario Login = null;

                        if (!dr.HasRows)
                        {
                            Login = new ModFuncionario
                            {
                                Usuario = " ",
                                IdcpfcnpjPessoa = -1,
                            };
                            return Login;
                        }
                        else
                        {
                            dr.Read();

                            Login = new ModFuncionario
                            {
                                Usuario = (dr["Usuario"]).ToString(),
                                IdcpfcnpjPessoa = Convert.ToInt64((dr["IdcpfcnpjPessoa"]).ToString()),
                            };

                            return Login;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public ModFuncionario VerificaLoginEntrada(string usuario)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaLoginEntrada", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Usuario", usuario);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);                     

                        ModFuncionario objModFuncionario = null;

                        if (!dr.HasRows)
                        {
                            objModFuncionario = new ModFuncionario
                            {
                                Usuario = " ",
                                Senha = " ",
                            };
                            return objModFuncionario;
                        }
                        else
                        {
                            dr.Read();

                            objModFuncionario = new ModFuncionario
                            {
                                Usuario = (dr["Usuario"]).ToString(),
                                Senha = (dr["Senha"]).ToString(),
                                NomePessoa = (dr["NomePessoa"]).ToString(),
                                IdcpfcnpjPessoa = Convert.ToInt64((dr["IdcpfcnpjPessoa"]).ToString()),
                            };

                            return objModFuncionario;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsereUsuarioLogado(Int64 idcpf, int idterminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereUsuarioLogado", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCpf", idcpf);
                        objCommand.Parameters.AddWithValue("@IdTerminal", idterminal);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable PegaUsuarioLogado(int idterminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("PegaUsuarioLogado", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdTerminal", idterminal);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LogoutUsuario(Int64 idcpf, int idterminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("LogoutUsuario", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CpfFuncionario", idcpf);
                        objCommand.Parameters.AddWithValue("@Terminal ", idterminal);

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
