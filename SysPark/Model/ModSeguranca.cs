using System;

namespace SysPark
{
    public class ModSeguranca
    {
        private static Int64 idSeguanca;
        private static Int64 idFuncionario;
        private static bool cadastro;
        private static bool pesquisa;
        private static bool configuracoes;
        private static bool relatorio;
        private static bool procedimento;
        private static bool cadClientes;
        private static bool cadFuncionarios;
        private static bool cadFornecedores;
        private static bool cadCargo;
        private static bool cadGrupo;
        private static bool cadSubGrupo;
        private static bool cadLogin;
        private static bool cadProdutos;
        private static bool cadServicos;
        private static bool cadPromocao;
        private static bool pesClientes;
        private static bool pesFuncionarios;
        private static bool pesFornecedor;
        private static bool pesCargo;
        private static bool pesGrupo;
        private static bool pesSubGrupo;
        private static bool pesProdutos;
        private static bool pesServicos;
        private static bool pesPromocao;
        private static bool terminal;
        private static bool informacoes;
        private static bool movimentoDia;
        private static bool modificarPreco;
        private static bool cancelarItem;
        private static bool fechaCaixa;
        private static bool abreCaixa;
        private static bool home;
        private static bool abreDia;
        private static bool fechaDia;
        private static bool leituraX;
        private static bool reducaoZ;
        private static bool progAliquota;
        private static bool cancelUltimoCupom;
        private static bool seguranca;
        private static bool cadTipoFidel;
        private static bool cadPrecoFidel;
        private static bool backup;


        public Int64 IdSeguanca
        {
            get { return idSeguanca; }
            set { idSeguanca = value; }
        }
        public Int64 IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
        public bool Cadastro
        {
            get { return cadastro; }
            set { cadastro = value; }
        }
        public bool CadTipoFidel
        {
            get { return cadTipoFidel; }
            set { cadTipoFidel = value; }
        }
        public bool CadPrecoFidel
        {
            get { return cadPrecoFidel; }
            set { cadPrecoFidel = value; }
        }

        public bool Backup
        {
            get { return backup; }
            set { backup = value; }
        }
        public bool Pesquisa
        {
            get { return pesquisa; }
            set { pesquisa = value; }
        }
        public bool Configuracoes
        {
            get { return configuracoes; }
            set { configuracoes = value; }
        }
        public bool Relatorio
        {
            get { return relatorio; }
            set { relatorio = value; }
        }
        public bool Procedimento
        {
            get { return procedimento; }
            set { procedimento = value; }
        }
        public bool CadClientes
        {
            get { return cadClientes; }
            set { cadClientes = value; }
        }
        public bool CadFuncionarios
        {
            get { return cadFuncionarios; }
            set { cadFuncionarios = value; }
        }
        public bool CadFornecedores
        {
            get { return cadFornecedores; }
            set { cadFornecedores = value; }
        }
        public bool CadCargo
        {
            get { return cadCargo; }
            set { cadCargo = value; }
        }
        public bool CadGrupo
        {
            get { return cadGrupo; }
            set { cadGrupo = value; }
        }
        public bool CadSubGrupo
        {
            get { return cadSubGrupo; }
            set { cadSubGrupo = value; }
        }
        public bool CadLogin
        {
            get { return cadLogin; }
            set { cadLogin = value; }
        }
        public bool CadProdutos
        {
            get { return cadProdutos; }
            set { cadProdutos = value; }
        }
        public bool CadServicos
        {
            get { return cadServicos; }
            set { cadServicos = value; }
        }
        public bool CadPromocao
        {
            get { return cadPromocao; }
            set { cadPromocao = value; }
        }
        public bool PesClientes
        {
            get { return pesClientes; }
            set { pesClientes = value; }
        }
        public bool PesFuncionarios
        {
            get { return pesFuncionarios; }
            set { pesFuncionarios = value; }
        }
        public bool PesFornecedor
        {
            get { return pesFornecedor; }
            set { pesFornecedor = value; }
        }
        public bool PesCargo
        {
            get { return pesCargo; }
            set { pesCargo = value; }
        }
        public bool PesGrupo
        {
            get { return pesGrupo; }
            set { pesGrupo = value; }
        }
        public bool PesSubGrupo
        {
            get { return pesSubGrupo; }
            set { pesSubGrupo = value; }
        }
        public bool PesProdutos
        {
            get { return pesProdutos; }
            set { pesProdutos = value; }
        }
        public bool PesServicos
        {
            get { return pesServicos; }
            set { pesServicos = value; }
        }
        public bool PesPromocao
        {
            get { return pesPromocao; }
            set { pesPromocao = value; }
        }
        public bool Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }
        public bool Informacoes
        {
            get { return informacoes; }
            set { informacoes = value; }
        }
        public bool MovimentoDia
        {
            get { return movimentoDia; }
            set { movimentoDia = value; }
        }
        public bool ModificarPreco
        {
            get { return modificarPreco; }
            set { modificarPreco = value; }
        }
        public bool CancelarItem
        {
            get { return cancelarItem; }
            set { cancelarItem = value; }
        }
        public bool FechaCaixa
        {
            get { return fechaCaixa; }
            set { fechaCaixa = value; }
        }
        public bool AbreCaixa
        {
            get { return abreCaixa; }
            set { abreCaixa = value; }
        }
        public bool Home
        {
            get { return home; }
            set { home = value; }
        }
        public bool Seguranca
        {
            get { return seguranca; }
            set { seguranca = value; }
        }
        public bool AbreDia
        {
            get { return abreDia; }
            set { abreDia = value; }
        }
        public bool FechaDia
        {
            get { return fechaDia; }
            set { fechaDia = value; }
        }
        public bool LeituraX
        {
            get { return leituraX; }
            set { leituraX = value; }
        }
        public bool ReducaoZ
        {
            get { return reducaoZ; }
            set { reducaoZ = value; }
        }
        public bool ProgAliquota
        {
            get { return progAliquota; }
            set { progAliquota = value; }
        }
        public bool CancelUltimoCupom
        {
            get { return cancelUltimoCupom; }
            set { cancelUltimoCupom = value; }
        }
    }
}
