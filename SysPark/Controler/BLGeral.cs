using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using SysPark.Properties;

namespace SysPark.Controler
{
    public class BLGeral
    {

        public void BackupBanco()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BackupBanco", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AbreMovimentoDiaCaixa(int idTerminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreMovimentoDiaCaixa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

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

        public void InsereInformacoes(ModGeral objModGeral)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("InsereInformacoes", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@NomeFantasia", objModGeral.NomeFantasia);
                        objCommand.Parameters.AddWithValue("@RazaoSocial", objModGeral.RazaoSocial);
                        objCommand.Parameters.AddWithValue("@Cnpj", objModGeral.Cnpj);
                        objCommand.Parameters.AddWithValue("@IEstadual", objModGeral.IEstadual);
                        objCommand.Parameters.AddWithValue("@Logradouro", objModGeral.Logradouro);
                        objCommand.Parameters.AddWithValue("@Numero", objModGeral.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModGeral.Bairro);
                        objCommand.Parameters.AddWithValue("@UF", objModGeral.UF);
                        objCommand.Parameters.AddWithValue("@Cidade", objModGeral.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep ", objModGeral.Cep);
                        objCommand.Parameters.AddWithValue("@Telefone", objModGeral.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModGeral.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModGeral.Email);
                        objCommand.Parameters.AddWithValue("@WebSite", objModGeral.Website);
                        objCommand.Parameters.AddWithValue("@LogoHome", objModGeral.ImagemHome);
                        objCommand.Parameters.AddWithValue("@LogoDescanso", objModGeral.ImagemDescanso);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaMovimentoDiaCaixaAtualFechado(int idterminal)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaCaixaAtualFechado", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTerminal", idterminal);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModGeral VerificaMovimentoDiaCaixaAberto(int idTerminal)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaCaixaAberto", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTerminal", idTerminal);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModGeral objModMov = null;

                        if (!dr.HasRows)
                        {
                            objModMov = new ModGeral
                            {
                                IdMovimentoDia = -1,
                            };
                            return objModMov;
                        }
                        else
                        {
                            dr.Read();

                            objModMov = new ModGeral
                            {
                                IdMovimentoDia = Convert.ToInt32(dr["IdMovimentoDiaCaixa"]),
                                DataAbertura = Convert.ToDateTime(dr["DataAbertura"]),
                            };
                            return objModMov;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModGeral VerificaMovimentoDiaCaixaAntigoAberto(int idTerminal)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaCaixaAntigoAberto", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@idTerminal", idTerminal);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModGeral objModMov = null;

                        if (!dr.HasRows)
                        {
                            objModMov = new ModGeral
                            {
                                IdMovimentoDia = -1,
                            };
                            return objModMov;
                        }
                        else
                        {
                            dr.Read();

                            objModMov = new ModGeral
                            {
                                IdMovimentoDia = Convert.ToInt32(dr["IdMovimentoDiaCaixa"]),
                                DataAbertura = Convert.ToDateTime(dr["DataAbertura"]),
                            };
                            return objModMov;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizaInformacoes(ModGeral objModGeral)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AtualizaInformacoes", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdInfo", objModGeral.IdInfo);
                        objCommand.Parameters.AddWithValue("@NomeFantasia", objModGeral.NomeFantasia);
                        objCommand.Parameters.AddWithValue("@RazaoSocial", objModGeral.RazaoSocial);
                        objCommand.Parameters.AddWithValue("@Cnpj", objModGeral.Cnpj);
                        objCommand.Parameters.AddWithValue("@IEstadual", objModGeral.IEstadual);
                        objCommand.Parameters.AddWithValue("@Logradouro", objModGeral.Logradouro);
                        objCommand.Parameters.AddWithValue("@Numero", objModGeral.NumeroEnd);
                        objCommand.Parameters.AddWithValue("@Bairro", objModGeral.Bairro);
                        objCommand.Parameters.AddWithValue("@UF", objModGeral.UF);
                        objCommand.Parameters.AddWithValue("@Cidade", objModGeral.Cidade);
                        objCommand.Parameters.AddWithValue("@Cep ", objModGeral.Cep);
                        objCommand.Parameters.AddWithValue("@Telefone", objModGeral.Telefone);
                        objCommand.Parameters.AddWithValue("@Celular", objModGeral.Celular);
                        objCommand.Parameters.AddWithValue("@Email", objModGeral.Email);
                        objCommand.Parameters.AddWithValue("@WebSite", objModGeral.Website);
                        objCommand.Parameters.AddWithValue("@LogoHome", objModGeral.ImagemHome);
                        objCommand.Parameters.AddWithValue("@LogoDescanso", objModGeral.ImagemDescanso);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Verifica_Existe_Empresa()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Verifica_Existe_Empresa", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Verifica_Primeiro_Usuario()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Verifica_Primeiro_Usuario", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscaInformacoes()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaInformacoes", objConexao))
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

        public byte[] BuscaLogo_Home()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaLogo_Home", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        byte[] logoHome;

                        if (!dr.HasRows)
                        {
                            logoHome = ConverteImagem_Byte(Resources.image_black);
                            return logoHome;
                        }
                        else
                        {
                            dr.Read();

                            logoHome = (byte[])dr["LogoHome"];
                            return logoHome;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte[] BuscaLogo_Descanso()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaLogo_Descanso", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        byte[] logoDescanso;                      

                        if (! dr.HasRows)
                        {                            
                            logoDescanso = ConverteImagem_Byte(Resources.image_black);
                            return logoDescanso;
                        }
                        else
                        {
                            dr.Read();

                            logoDescanso = (byte[])dr["LogoDescanso"];
                            return logoDescanso;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private byte[] ConverteImagem_Byte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public string BuscaNomeFantasia()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaNomeFantasia", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        string nomeFantasia;

                        if (!dr.HasRows)
                        {
                            nomeFantasia = "";
                            return nomeFantasia;
                        }
                        else
                        {
                            dr.Read();

                            nomeFantasia = dr["NomeFantasia"].ToString().Length >= 31
                                         ? dr["NomeFantasia"].ToString().Substring(0, 31)
                                         : dr["NomeFantasia"].ToString();
                            return nomeFantasia;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AbreMovimentoDia(Int64 idOperador, int idTerminal, DateTime dataAbertura)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("AbreMovimentoDia", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdCpfOperador", idOperador);
                        objCommand.Parameters.AddWithValue("@IdTerminal", idTerminal);
                        objCommand.Parameters.AddWithValue("@DataAbertura", dataAbertura);                        

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FechaMovimentoDia(Int64 idOperador, int idTerminal, DateTime dataFechamento, Int64 idMovimentoDia)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("FechaMovimentoDia", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdUsuarioFechamento", idOperador);
                        objCommand.Parameters.AddWithValue("@IdTerminal", idTerminal);
                        objCommand.Parameters.AddWithValue("@DataFechamento", dataFechamento);
                        objCommand.Parameters.AddWithValue("@IdMovimentoDia", idMovimentoDia);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable VerificaMovimentoDiaAberto()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaAberto", objConexao))
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

        public DataTable VerificaMovimentoDiaAntigoAberto()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaAntigoAberto", objConexao))
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

        public bool VerificaCaixaAberto()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaCaixaAberto", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);                       

                        if (!dr.HasRows)
                        {                            
                            return false;
                        }
                        else
                        {
                            dr.Read();                            
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaMovimentoDiaAtualFechado()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaAtualFechado", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;
                        
                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Verifica_Pessoa_Existe(long cpf)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaPessoaExiste", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdcpfcnpjPessoa", cpf);

                        return clsDados.RetornaDados(objCommand).Rows.Count > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModPessoas Busca_Dados_Pessoa_CPF(long cpf)
        {
            try
            {
                using (var objConn = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("Busca_Dados_Pessoa_CPF", objConn))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@CPF", cpf);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConn);

                        ModPessoas objModPessoas = null;

                        if (!dr.HasRows)
                        {
                            objModPessoas = new ModPessoas
                            {
                                IdcpfcnpjPessoa = -1,
                            };
                            return objModPessoas;
                        }
                        else
                        {
                            dr.Read();

                            objModPessoas = new ModPessoas
                            {
                                IdcpfcnpjPessoa = (long)dr["CPF"],
                                NomePessoa = (string)dr["Nome"],
                                Rg = (string)dr["RG"],
                                ImagemPessoa = (byte[])dr["ImagemPessoa"],
                                SituacaoPessoa = (bool)dr["Ativo"],                                
                                DataNascimento = Convert.ToDateTime(dr["Data Nascimento"]),
                                NomeAtualiza = (string)dr["Atualizado Por"],
                                DataAtualiza = Convert.ToDateTime(dr["Data Atualização"]),
                                Cep = (string)dr["CEP"],
                                Logradouro = (string)dr["Endereço"],
                                NumeroEnd = (int)dr["Numero"],
                                Bairro = (string)dr["Bairro"],
                                Cidade = (string)dr["Cidade"],
                                UF = (string)dr["UF"],
                                Telefone = (string)dr["Telefone"],
                                Celular = (string)dr["Celular"],
                                Email = (string)dr["Email"],
                                Website = (string)dr["Site"],
                            };
                            return objModPessoas;
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*public ModGeral VerificaMovimentoDiaAbertosAntesDaDataAtual()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("VerificaMovimentoDiaAbertosAntesDaDataAtual", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        ModGeral objModGeral = null;

                        if (!dr.HasRows)
                        {
                            objModGeral = new ModGeral
                            {
                                IdMovimentoDia = -1,
                            };
                            return objModGeral;
                        }
                        else
                        {
                            dr.Read();

                            objModGeral = new ModGeral
                            {
                                IdMovimentoDia = Convert.ToInt64(dr["IdMovimentoDia"].ToString()),

                            };
                            return objModGeral;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        /*public byte[] BuscaImagemUsuario()
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BuscaImagemUsuario", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdInfo", objModGeral.IdInfo);

                        var dr = clsDados.RetornaDadosReader(objCommand, objConexao);

                        byte[] imagemUsuario;

                        if (!dr.HasRows)
                        {
                            imagemUsuario = ConverteImagem_Byte(Resources.image_black);
                            return imagemUsuario;
                        }
                        else
                        {
                            dr.Read();

                            imagemUsuario = (byte[])dr["imagemPessoa"];
                            return imagemUsuario;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
