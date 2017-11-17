using System;

namespace SysPark.Model
{
    public class ModServicos : ModGrupo
    {
        private static Int64 idServico;
        private static Int64 codigo;
        private static string nomeServico;
        private static string descricao;        
        private static bool situacaoServico;
        private static DateTime dataCadastro;
        private static byte[] imagemServico;        
        private static string unidadeSaida;      
        private static decimal precoVenda;
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
        public Int64 IdServico
        {
            get { return idServico; }
            set { idServico = value; }
        }
        public Int64 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string NomeServico
        {
            get { return nomeServico; }
            set { nomeServico = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }        
        public bool SituacaoServico
        {
            get { return situacaoServico; }
            set { situacaoServico = value; }
        }
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public byte[] ImagemServico
        {
            get { return imagemServico; }
            set { imagemServico = value; }
        }        
        public string UnidadeSaida
        {
            get { return unidadeSaida; }
            set { unidadeSaida = value; }
        }        
        public decimal PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }     

    }
}
