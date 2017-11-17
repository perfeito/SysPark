using System;

namespace SysPark.Model
{
    public class ModProduto : ModGrupo
    {
        private static Int64 idProduto;
        private static Int64 codBarras;
        private static string nomeProduto;
        private static string descricao;
        private static string marca;
        private static bool situacao;
        private static DateTime dataCadastro;
        private static byte[] imagemProduto;
        private static decimal qtdEstoque;
        private static decimal qtdMinEstoque;
        private static string unidadeEntrada;
        private static string unidadeSaida;
        private static Int64 fator;
        private static DateTime ultimaCompra;
        private static decimal qtdComprada;
        private static decimal precoCusto;
        private static decimal precoVenda;
        private static int margemLucro;
        private static string aliquota;
        private static decimal ibpt;
        private static Int64 idOperadorDesc;
        private static Int64 idOperadorCancel;
        private static int codigoItem;
        private static decimal totalItem;
        private static decimal descontoItem;
        private static decimal descontoFidelidade;
        private static decimal qtdVenda;


        public string Aliquota
        {
            get { return aliquota; }
            set { aliquota = value; }
        }
        public decimal Ibpt
        {
            get { return ibpt; }
            set { ibpt = value; }
        }
        public Int64 IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        public Int64 CodBarras
        {
            get { return codBarras; }
            set { codBarras = value; }
        }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public bool Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public byte[] ImagemProduto
        {
            get { return imagemProduto; }
            set { imagemProduto = value; }
        }
        public decimal QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }
        public decimal QtdMinEstoque
        {
            get { return qtdMinEstoque; }
            set { qtdMinEstoque = value; }
        }
        public string UnidadeEntrada
        {
            get { return unidadeEntrada; }
            set { unidadeEntrada = value; }
        }
        public string UnidadeSaida
        {
            get { return unidadeSaida; }
            set { unidadeSaida = value; }
        }
        public Int64 Fator
        {
            get { return fator; }
            set { fator = value; }
        }
        public DateTime UltimaCompra
        {
            get { return ultimaCompra; }
            set { ultimaCompra = value; }
        }
        public decimal QtdComprada
        {
            get { return qtdComprada; }
            set { qtdComprada = value; }
        }
        public decimal PrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }
        public decimal PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }
        public int MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }
        public Int64 IdOperadorDesc
        {
            get { return idOperadorDesc; }
            set { idOperadorDesc = value; }
        }
        public Int64 IdOperadorCancel
        {
            get { return idOperadorCancel; }
            set { idOperadorCancel = value; }
        }
        public int CodigoItem
        {
            get { return codigoItem; }
            set { codigoItem = value; }
        }
        public decimal TotalItem
        {
            get { return totalItem; }
            set { totalItem = value; }
        }
        public decimal DescontoItem
        {
            get { return descontoItem; }
            set { descontoItem = value; }
        }
        public decimal QtdVenda
        {
            get { return qtdVenda; }
            set { qtdVenda = value; }
        }
        public decimal DescontoFidelidade
        {
            get { return descontoFidelidade; }
            set { descontoFidelidade = value; }
        }

        //============= PERDAS DE PRODUTOS =====================

        private static int idCausaPerda;
        private static string nomeCausa;
        private static bool situacaoCausa;
        private static decimal qtdPerda;
        private static long idPerda;


        public int IdCausaPerda
        {
            get { return idCausaPerda; }
            set { idCausaPerda = value; }
        }
        public string NomeCausa
        {
            get { return nomeCausa; }
            set { nomeCausa = value; }
        }
        public bool SituacaoCausa
        {
            get { return situacaoCausa; }
            set { situacaoCausa = value; }
        }
        public decimal QtdPerda
        {
            get { return qtdPerda; }
            set { qtdPerda = value; }
        }
        public long IdPerda
        {
            get { return idPerda; }
            set { idPerda = value; }
        }

        // =================== ORÇAMENTO ====================

        private static long idOrcamento;
        private static bool itemCancelado;
        private static long idSacola;
        private static long iditemorcamento;
        private static long iditemvenda;
        private static long idOrdemServico;       


        public long IdOrcamento
        {
            get { return idOrcamento; }
            set { idOrcamento = value; }
        }
        public bool ItemCancelado
        {
            get { return itemCancelado; }
            set { itemCancelado = value; }
        }
        public long IdSacola
        {
            get { return idSacola; }
            set { idSacola = value; }
        }
        public long IdItemOrcamento
        {
            get { return iditemorcamento; }
            set { iditemorcamento = value; }
        }
        public long IdItemVenda
        {
            get { return iditemvenda; }
            set { iditemvenda = value; }
        }
        public long IdOrdemServico
        {
            get { return idOrdemServico; }
            set { idOrdemServico = value; }
        }
    }
}
