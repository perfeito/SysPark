using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SysPark.Model
{
    public class ModProdutoServico : ModCaixa
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
        private static decimal qtdVenda;
        private static decimal precoCusto;
        private static decimal precoVenda;
        private static decimal totalItem;
        private static decimal descontoItem;
        private static decimal descontoFidelidade;
        private static int margemLucro;
        private static Int64 idOperadorDesc;
        private static Int64 idOperadorCancel;
        private static int codigoItem;
        private static string aliquota;
        private static decimal ibpt;


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
        public decimal DescontoFidelidade
        {
            get { return descontoFidelidade; }
            set { descontoFidelidade = value; }
        }
        public Int64 IdProdutoServico
        {
            get { return idProduto; }
            set { idProduto = value; }
        }        
        public Int64 CodigoBarras
        {
            get { return codBarras; }
            set { codBarras = value; }
        }
        public int CodigoItem
        {
            get { return codigoItem; }
            set { codigoItem = value; }
        }
        public string NomeProdutoServico
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
        public byte[] ImagemProdutoServico
        {
            get { return imagemProduto; }
            set { imagemProduto = value; }
        }
        public decimal QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
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
    }
}
