using System;
using System.Data;

namespace SysPark.Model
{   

    public class ModCaixa : ModFuncionario
    {
        private bool valeResgatado;

        public bool ValeResgatado
        {
            get { return valeResgatado; }
            set { valeResgatado = value; }
        }

        private static DataTable dtSacola;

        public DataTable DtSacola
        {
            get { return dtSacola; }
            set { dtSacola = value; }
        }

        private bool valeCancelado;

        public bool ValeCancelado
        {
            get { return valeCancelado; }
            set { valeCancelado = value; }
        }


        private decimal valorValeTroca;

        public decimal ValorValeTroca
        {
            get { return valorValeTroca; }
            set { valorValeTroca = value; }
        }


        private long idValeTroca;

        public long IdValeTroca
        {
            get { return idValeTroca; }
            set { idValeTroca = value; }
        }

        private static Int64 idcaixa;
        private static Int64 idvenda;
        private static Int64 iditemvenda;
        private static DateTime dataAbertura;
        private static DateTime dataFechamento;
        private static decimal troco;
        private static decimal dinheiro;
        private static decimal cheque;
        private static decimal credito;
        private static decimal debito;
        private static decimal outros;
        private static decimal outrosContado;
        private static decimal dinheiroContado;
        private static decimal chequeContado;
        private static decimal creditoContado;
        private static decimal debitoContado;        
        private static bool itemCancelado;
        private static decimal valorCancelado;
        private static decimal valorTotal;
        private static decimal valorRecebido;
        private static decimal descontoVenda;
        private static int qtdItem;
        private static int qtdCupom;

        private static decimal valorSuprimento;
        public decimal ValorSuprimento
        {
            get { return valorSuprimento; }
            set { valorSuprimento = value; }
        }

        private static decimal valorSangria;

        public decimal ValorSangria
        {
            get { return valorSangria; }
            set { valorSangria = value; }
        }

        public Int64 IdCaixa
        {
            get { return idcaixa; }
            set { idcaixa = value; }
        }
        public Int64 IdItemVenda
        {
            get { return iditemvenda; }
            set { iditemvenda = value; }
        }
        public bool ItemCancelado
        {
            get { return itemCancelado; }
            set { itemCancelado = value; }
        }
        public decimal ValorCancelado
        {
            get { return valorCancelado; }
            set { valorCancelado = value; }
        }
        public Int64 IdVenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }
        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
        public DateTime DataFechamento
        {
            get { return dataFechamento; }
            set { dataFechamento = value; }
        }
        public decimal Troco
        {
            get { return troco; }
            set { troco = value; }
        }
        public decimal Dinheiro
        {
            get { return dinheiro; }
            set { dinheiro = value; }
        }
        public decimal Cheque
        {
            get { return cheque; }
            set { cheque = value; }
        }
        public decimal Credito
        {
            get { return credito; }
            set { credito = value; }
        }
        public decimal Debito
        {
            get { return debito; }
            set { debito = value; }
        }
        public decimal Outros
        {
            get { return outros; }
            set { outros = value; }
        }
        public decimal OutrosContado
        {
            get { return outrosContado; }
            set { outrosContado = value; }
        }
        public decimal DinheiroContado
        {
            get { return dinheiroContado; }
            set { dinheiroContado = value; }
        }
        public decimal ChequeContado
        {
            get { return chequeContado; }
            set { chequeContado = value; }
        }
        public decimal CreditoContado
        {
            get { return creditoContado; }
            set { creditoContado = value; }
        }
        public decimal DebitoContado
        {
            get { return debitoContado; }
            set { debitoContado = value; }
        }
        public decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        public decimal ValorRecebido
        {
            get { return valorRecebido; }
            set { valorRecebido = value; }
        }
        public decimal DescontoVenda
        {
            get { return descontoVenda; }
            set { descontoVenda = value; }
        }
        public int QtdItem
        {
            get { return qtdItem; }
            set { qtdItem = value; }
        }
        public int QtdCupom
        {
            get { return qtdCupom; }
            set { qtdCupom = value; }
        }



        //********  TERMINAL  *************


        private static int idTerminal;
        private static string mac;
        private static string nomeTerminal;
        private static bool situacaoTerminal;


        public int IdTerminal
        {
            get { return idTerminal; }
            set { idTerminal = value; }
        }
        public string Mac
        {
            get { return mac; }
            set { mac = value; }
        }
        public string NomeTerminal
        {
            get { return nomeTerminal; }
            set { nomeTerminal = value; }
        }
        public bool SituacaoTerminal
        {
            get { return situacaoTerminal; }
            set { situacaoTerminal = value; }
        }
    }
}
