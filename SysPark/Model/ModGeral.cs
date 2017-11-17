using System;


namespace SysPark
{
    public class ModGeral : ModPessoas
    {
        private static int idInfo;
        private static string nomeFantasia;
        private static string razaoSocial;
        private static Int64 cnpj;
        private static string iEstadual;
        private static byte[] imagemHome;
        private static byte[] imagemDescanso;

        public int IdInfo
        {
            get { return idInfo; }
            set { idInfo = value; }
        }
        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        public Int64 Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string IEstadual
        {
            get { return iEstadual; }
            set { iEstadual = value; }
        }
        public byte[] ImagemHome
        {
            get { return imagemHome; }
            set { imagemHome = value; }
        }

        public byte[] ImagemDescanso
        {
            get { return imagemDescanso; }
            set { imagemDescanso = value; }
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


        //************ MOVIMENTO DIA **************


        private static int idTerminalAbertura;
        private static int idTerminalFechamento;
        private static Int64 idUsuarioAbertura;
        private static Int64 idUsuarioFechamento;
        private static DateTime dataAbertura;
        private static DateTime dataFechamento;
        private static Int64 idMovimentoDia;


        public int IdTerminalAbertura
        {
            get { return idTerminalAbertura; }
            set { idTerminalAbertura = value; }
        }
        public int IdTerminalFechamento
        {
            get { return idTerminalFechamento; }
            set { idTerminalFechamento = value; }
        }
        public Int64 IdUsuarioAbertura
        {
            get { return idUsuarioAbertura; }
            set { idUsuarioAbertura = value; }
        }
        public Int64 IdUsuarioFechamento
        {
            get { return idUsuarioFechamento; }
            set { idUsuarioFechamento = value; }
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
        public Int64 IdMovimentoDia
        {
            get { return idMovimentoDia; }
            set { idMovimentoDia = value; }
        }
    }
}
