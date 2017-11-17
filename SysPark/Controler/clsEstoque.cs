using System;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Controler
{
    public class clsEstoque
    {
        public void BaixaEstoque(Int64 idvenda)
        {
            var dtlistaitens = objBlCaixa.ListaItensBaixaEstoque(idvenda);

            foreach (DataRow row in dtlistaitens.Rows)
            {
                if ((bool)row["Cancelado"] == false)
                {
                    objBlCaixa.BaixaEstoque((Int64)row["idProduto"], (decimal)row["Qtd"]);
                }
            }
        }

        //clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();

        public void BaixaEstoqueVendaCaixa(long idvenda)
        {
            var dtlistaitens = objBlCaixa.ListaItensBaixaEstoque(idvenda);

            foreach (DataRow row in dtlistaitens.Rows)
            {
                if ((bool)row["Cancelado"] == false)
                {
                    BaixaEstoque((long)row["idProduto"], (decimal)row["Qtd"]);
                }
            }
        }

        public void BaixaEstoque(long idproduto, decimal qtd)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("BaixaEstoque", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdProduto", idproduto);
                        objCommand.Parameters.AddWithValue("@Qtd", qtd);

                        clsDados.ExecutaComando(objCommand, objConexao);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EntradaEstoque(long idproduto, decimal qtd)
        {
            try
            {
                using (var objConexao = clsDados.ConectaBanco())
                {
                    using (var objCommand = new SqlCommand("EntradaEstoque", objConexao))
                    {
                        objCommand.CommandType = CommandType.StoredProcedure;

                        objCommand.Parameters.AddWithValue("@IdProduto", idproduto);
                        objCommand.Parameters.AddWithValue("@Qtd", qtd);

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
