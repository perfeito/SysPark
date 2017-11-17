using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class BLSeguranca
    {
        public void InsereSeguranca(ModSeguranca objModSeguranca)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereSeguranca", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdFuncionario", objModSeguranca.IdFuncionario);
                        objCommand.Parameters.AddWithValue("@Cadastros", objModSeguranca.Cadastro);
                        objCommand.Parameters.AddWithValue("@Pesquisas", objModSeguranca.Pesquisa);
                        objCommand.Parameters.AddWithValue("@Configuracoes", objModSeguranca.Configuracoes);
                        objCommand.Parameters.AddWithValue("@Relatorios", objModSeguranca.Relatorio);
                        objCommand.Parameters.AddWithValue("@Procedimentos", objModSeguranca.Procedimento);
                        objCommand.Parameters.AddWithValue("@CadClientes", objModSeguranca.CadClientes);
                        objCommand.Parameters.AddWithValue("@CadFuncionarios", objModSeguranca.CadFuncionarios);
                        objCommand.Parameters.AddWithValue("@CadFornecedores", objModSeguranca.CadFornecedores);
                        objCommand.Parameters.AddWithValue("@CadCargos", objModSeguranca.CadCargo);
                        objCommand.Parameters.AddWithValue("@CadGrupos", objModSeguranca.CadGrupo);
                        objCommand.Parameters.AddWithValue("@CadSubGrupos", objModSeguranca.CadSubGrupo);
                        objCommand.Parameters.AddWithValue("@CadLogin", objModSeguranca.CadLogin);
                        objCommand.Parameters.AddWithValue("@CadProdutos", objModSeguranca.CadProdutos);
                        objCommand.Parameters.AddWithValue("@CadServicos", objModSeguranca.CadServicos);
                        objCommand.Parameters.AddWithValue("@CadPromocao", objModSeguranca.CadPromocao);
                        objCommand.Parameters.AddWithValue("@PesClientes", objModSeguranca.PesClientes);
                        objCommand.Parameters.AddWithValue("@PesFuncionarios", objModSeguranca.PesFuncionarios);
                        objCommand.Parameters.AddWithValue("@PesFornecedores", objModSeguranca.PesFornecedor);
                        objCommand.Parameters.AddWithValue("@PesCargos", objModSeguranca.PesCargo);
                        objCommand.Parameters.AddWithValue("@PesGrupos", objModSeguranca.PesGrupo);
                        objCommand.Parameters.AddWithValue("@PesSubGrupos", objModSeguranca.PesSubGrupo);
                        objCommand.Parameters.AddWithValue("@PesProdutos", objModSeguranca.PesProdutos);
                        objCommand.Parameters.AddWithValue("@PesServicos", objModSeguranca.PesServicos);
                        objCommand.Parameters.AddWithValue("@PesPromocao", objModSeguranca.PesPromocao);
                        objCommand.Parameters.AddWithValue("@Terminal", objModSeguranca.Terminal);
                        objCommand.Parameters.AddWithValue("@Informacoes", objModSeguranca.Informacoes);
                        objCommand.Parameters.AddWithValue("@MovimentoDia", objModSeguranca.MovimentoDia);
                        objCommand.Parameters.AddWithValue("@ModificarPreco", objModSeguranca.ModificarPreco);
                        objCommand.Parameters.AddWithValue("@CancelarItem", objModSeguranca.CancelarItem);
                        objCommand.Parameters.AddWithValue("@FecharCaixa", objModSeguranca.FechaCaixa);
                        objCommand.Parameters.AddWithValue("@AbreCaixa", objModSeguranca.AbreCaixa);
                        objCommand.Parameters.AddWithValue("@Home", objModSeguranca.Home);
                        objCommand.Parameters.AddWithValue("@Seguranca", objModSeguranca.Seguranca);
                        objCommand.Parameters.AddWithValue("@AbreDia", objModSeguranca.AbreDia);
                        objCommand.Parameters.AddWithValue("@FechaDia", objModSeguranca.FechaDia);
                        objCommand.Parameters.AddWithValue("@LeituraX", objModSeguranca.LeituraX);
                        objCommand.Parameters.AddWithValue("@ReducaoZ", objModSeguranca.ReducaoZ);
                        objCommand.Parameters.AddWithValue("@ProgAliquota", objModSeguranca.ProgAliquota);
                        objCommand.Parameters.AddWithValue("@CancelUltimoCupom", objModSeguranca.CancelUltimoCupom);
                        objCommand.Parameters.AddWithValue("@CadTipoFidel", objModSeguranca.CadTipoFidel);
                        objCommand.Parameters.AddWithValue("@CadPrecoFidel", objModSeguranca.CadPrecoFidel);
                        objCommand.Parameters.AddWithValue("@BackupInfo", objModSeguranca.Backup);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AtualizaSeguranca(ModSeguranca objModSeguranca)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaSeguranca", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        objCommand.Parameters.AddWithValue("@IdFuncionario", objModSeguranca.IdFuncionario);
                        objCommand.Parameters.AddWithValue("@Cadastros", objModSeguranca.Cadastro);
                        objCommand.Parameters.AddWithValue("@Pesquisas", objModSeguranca.Pesquisa);
                        objCommand.Parameters.AddWithValue("@Configuracoes", objModSeguranca.Configuracoes);
                        objCommand.Parameters.AddWithValue("@Relatorios", objModSeguranca.Relatorio);
                        objCommand.Parameters.AddWithValue("@Procedimentos", objModSeguranca.Procedimento);
                        objCommand.Parameters.AddWithValue("@CadClientes", objModSeguranca.CadClientes);
                        objCommand.Parameters.AddWithValue("@CadFuncionarios", objModSeguranca.CadFuncionarios);
                        objCommand.Parameters.AddWithValue("@CadFornecedores", objModSeguranca.CadFornecedores);
                        objCommand.Parameters.AddWithValue("@CadCargos", objModSeguranca.CadCargo);
                        objCommand.Parameters.AddWithValue("@CadGrupos", objModSeguranca.CadGrupo);
                        objCommand.Parameters.AddWithValue("@CadSubGrupos", objModSeguranca.CadSubGrupo);
                        objCommand.Parameters.AddWithValue("@CadLogin", objModSeguranca.CadLogin);
                        objCommand.Parameters.AddWithValue("@CadProdutos", objModSeguranca.CadProdutos);
                        objCommand.Parameters.AddWithValue("@CadServicos", objModSeguranca.CadServicos);
                        objCommand.Parameters.AddWithValue("@CadPromocao", objModSeguranca.CadPromocao);
                        objCommand.Parameters.AddWithValue("@PesClientes", objModSeguranca.PesClientes);
                        objCommand.Parameters.AddWithValue("@PesFuncionarios", objModSeguranca.PesFuncionarios);
                        objCommand.Parameters.AddWithValue("@PesFornecedores", objModSeguranca.PesFornecedor);
                        objCommand.Parameters.AddWithValue("@PesCargos", objModSeguranca.PesCargo);
                        objCommand.Parameters.AddWithValue("@PesGrupos", objModSeguranca.PesGrupo);
                        objCommand.Parameters.AddWithValue("@PesSubGrupos", objModSeguranca.PesSubGrupo);
                        objCommand.Parameters.AddWithValue("@PesProdutos", objModSeguranca.PesProdutos);
                        objCommand.Parameters.AddWithValue("@PesServicos", objModSeguranca.PesServicos);
                        objCommand.Parameters.AddWithValue("@PesPromocao", objModSeguranca.PesPromocao);
                        objCommand.Parameters.AddWithValue("@Terminal", objModSeguranca.Terminal);
                        objCommand.Parameters.AddWithValue("@Informacoes", objModSeguranca.Informacoes);
                        objCommand.Parameters.AddWithValue("@MovimentoDia", objModSeguranca.MovimentoDia);
                        objCommand.Parameters.AddWithValue("@ModificarPreco", objModSeguranca.ModificarPreco);
                        objCommand.Parameters.AddWithValue("@CancelarItem", objModSeguranca.CancelarItem);
                        objCommand.Parameters.AddWithValue("@FecharCaixa", objModSeguranca.FechaCaixa);
                        objCommand.Parameters.AddWithValue("@AbreCaixa", objModSeguranca.AbreCaixa);
                        objCommand.Parameters.AddWithValue("@Home", objModSeguranca.Home);
                        objCommand.Parameters.AddWithValue("@Seguranca", objModSeguranca.Seguranca);
                        objCommand.Parameters.AddWithValue("@AbreDia", objModSeguranca.AbreDia);
                        objCommand.Parameters.AddWithValue("@FechaDia", objModSeguranca.FechaDia);
                        objCommand.Parameters.AddWithValue("@LeituraX", objModSeguranca.LeituraX);
                        objCommand.Parameters.AddWithValue("@ReducaoZ", objModSeguranca.ReducaoZ);
                        objCommand.Parameters.AddWithValue("@ProgAliquota", objModSeguranca.ProgAliquota);
                        objCommand.Parameters.AddWithValue("@CancelUltimoCupom", objModSeguranca.CancelUltimoCupom);
                        objCommand.Parameters.AddWithValue("@CadTipoFidel", objModSeguranca.CadTipoFidel);
                        objCommand.Parameters.AddWithValue("@CadPrecoFidel", objModSeguranca.CadPrecoFidel);
                        objCommand.Parameters.AddWithValue("@BackupInfo", objModSeguranca.Backup);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ModSeguranca VerificaPermissaoSeguranca(long idFuncionario)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaPermissaoSeguranca", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModSeguranca Seguranca = null;

                        if (!dr.HasRows)
                        {
                            Seguranca = new ModSeguranca
                            {
                                IdSeguanca = -1,                                
                            };
                            return Seguranca;
                        }
                        else
                        {
                            dr.Read();

                            Seguranca = new ModSeguranca
                            {
                                IdSeguanca = Convert.ToInt64(dr["IdSeguranca"]),
                                Cadastro = (bool)dr["Cadastros"],
                                Pesquisa = (bool)dr["Pesquisas"],
                                Configuracoes = (bool)dr["Configuracoes"],
                                Relatorio = (bool)dr["Relatorios"],
                                Procedimento = (bool)dr["Procedimentos"],
                                CadCargo = (bool)dr["CadCargos"],
                                CadClientes = (bool)dr["CadClientes"],
                                CadFornecedores = (bool)dr["CadFornecedores"],
                                CadFuncionarios = (bool)dr["CadFuncionarios"],
                                CadGrupo = (bool)dr["CadGrupos"],
                                CadLogin = (bool)dr["CadLogin"],
                                CadProdutos = (bool)dr["CadProdutos"],
                                CadPromocao = (bool)dr["CadPromocao"],
                                CadServicos = (bool)dr["CadServicos"],
                                CadSubGrupo = (bool)dr["CadSubGrupos"],
                                PesCargo = (bool)dr["PesCargos"],
                                PesClientes = (bool)dr["PesClientes"],
                                PesFornecedor = (bool)dr["PesFornecedores"],
                                PesFuncionarios = (bool)dr["PesFuncionarios"],
                                PesGrupo = (bool)dr["PesGrupos"],
                                PesProdutos = (bool)dr["PesProdutos"],
                                PesPromocao = (bool)dr["PesPromocao"],
                                PesServicos = (bool)dr["PesServicos"],
                                PesSubGrupo = (bool)dr["PesSubGrupos"],
                                Terminal = (bool)dr["Terminal"],
                                Informacoes = (bool)dr["Informacoes"],
                                MovimentoDia = (bool)dr["MovimentoDia"],
                                ModificarPreco = (bool)dr["ModificarPreco"],
                                CancelarItem = (bool)dr["CancelarItem"],
                                FechaCaixa = (bool)dr["FecharCaixa"],
                                AbreCaixa = (bool)dr["AbreCaixa"],
                                Home = (bool)dr["Home"],
                                Seguranca = (bool)dr["Seguranca"],
                                AbreDia = (bool)dr["AbreDia"],
                                FechaDia = (bool)dr["FechaDia"],
                                LeituraX = (bool)dr["LeituraX"],
                                ReducaoZ = (bool)dr["ReducaoZ"],
                                ProgAliquota = (bool)dr["ProgAliquota"],
                                CancelUltimoCupom = (bool)dr["CancelUltimoCupom"],
                                CadTipoFidel = (bool)dr["CadTipoFidelidade"],
                                CadPrecoFidel = (bool)dr["CadPrecoFidelidade"],
                                Backup = (bool)dr["BackupInfo"],
                            };
                            return Seguranca;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaFuncionarioSegurancaNome(string nome)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFuncionarioSegurancaNome", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@Nome", nome);

                        return clsDados.RetornaDados(objCommand);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscaFuncionarioSegurancaTodos()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaFuncionarioSegurancaTodos", objConexao))
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
        public bool VerificaSegurancaExiste(Int64 idFuncionario)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaSegurancaExiste", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        bool Seguranca;

                        if (!dr.HasRows)
                        {
                            Seguranca = false;

                            return Seguranca;
                        }
                        else
                        {
                            Seguranca = true;

                            return Seguranca;
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
