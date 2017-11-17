using System;

namespace SysPark.Model
{
    public class ModCliente : ModPessoas
    {
        private static DateTime dataCadCliente;
        private static bool fidelidade;
        private static bool contas;
        private static int desconto;
        private static decimal taxaEntrega;
        private static Int64 acumulado;
        private static Int64 pontosAtual;
        private static Int64 qtdVisita;
        private static DateTime ultimaVisita;
        private static Int64 idTipoFidelidade;
        private static string nomeFidelidadde;
        private static bool situacaoFidelidade;

        public DateTime DataCadCliente
        {
            get { return dataCadCliente; }
            set { dataCadCliente = value; }
        }
        public bool Fidelidade
        {
            get { return fidelidade; }
            set { fidelidade = value; }
        }
        public bool Contas
        {
            get { return contas; }
            set { contas = value; }
        }
        public int Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        public decimal TaxaEntrega
        {
            get { return taxaEntrega; }
            set { taxaEntrega = value; }
        }
        public Int64 PontosAtual
        {
            get { return pontosAtual; }
            set { pontosAtual = value; }
        }
        public Int64 Acululados
        {
            get { return acumulado; }
            set { acumulado = value; }
        }
        public Int64 QtdVisita
        {
            get { return qtdVisita; }
            set { qtdVisita = value; }
        }
        public DateTime UltimaVisita
        {
            get { return ultimaVisita; }
            set { ultimaVisita = value; }
        }
        public Int64 IdTipoFidelidade
        {
            get { return idTipoFidelidade; }
            set { idTipoFidelidade = value; }
        }
        public string NomeFidelidadde
        {
            get { return nomeFidelidadde; }
            set { nomeFidelidadde = value; }
        }
        public bool SituacaoFidelidade
        {
            get { return situacaoFidelidade; }
            set { situacaoFidelidade = value; }
        }
    }
}
