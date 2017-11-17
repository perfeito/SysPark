using System;

namespace SysPark.Model
{
    public class ModOrdemServico : ModFuncionario
    {
        private static int id;
        private static string nome;
        private static bool situacao;

        private static long idFuncionario;
        private static long idOrdem;
        private static long idCliente;
        private static string nomeProduto;
        private static string nomeFunc;
        private static string codigoIdent;
        private static string numSerie;
        private static string marca;
        private static string modelo;
        private static DateTime? dataOrdem;
        private static DateTime? dateEntrada;
        private static DateTime? dateRetirada;
        private static int condicaoOrdem;
        private static decimal subtotalOS;
        private static decimal descontoOS;
        private static decimal totalOS;


        public int IdSitucaoOrdem
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeSituacao
        {
            get { return nome; }
            set { nome = value; }
        }
        public bool SituacaoOrdem
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public long IdOrdem
        {
            get { return idOrdem; }
            set { idOrdem = value; }
        }
        public long IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
        public long IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        public string NomeFunc
        {
            get { return nomeFunc; }
            set { nomeFunc = value; }
        }
        public string CodigoIdent
        {
            get { return codigoIdent; }
            set { codigoIdent = value; }
        }
        public string NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public DateTime? DataOrdem
        {
            get { return dataOrdem; }
            set { dataOrdem = value; }
        }
        public DateTime? DateEntrada
        {
            get { return dateEntrada; }
            set { dateEntrada = value; }
        }
        public DateTime? DateRetirada
        {
            get { return dateRetirada; }
            set { dateRetirada = value; }
        }
        public int CondicaoOrdem
        {
            get { return condicaoOrdem; }
            set { condicaoOrdem = value; }
        }
        public decimal SubtotalOS
        {
            get { return subtotalOS; }
            set { subtotalOS = value; }
        }
        public decimal DescontoOS
        {
            get { return descontoOS; }
            set { descontoOS = value; }
        }
        public decimal TotalOS
        {
            get { return totalOS; }
            set { totalOS = value; }
        }
    }
}
