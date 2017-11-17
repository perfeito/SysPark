using System;

namespace SysPark
{
    public class ModFuncionario : ModPessoas
    {
        private static Int64 carteiraTrabalho;
        private static DateTime dataAdmissao;
        private static DateTime? dataDemissao;
        private static decimal salario;
        private static Int64 comissao;
        private static bool contas;
        private static Int64 codFunc;

        public Int64 CarteiraTrabalho
        {
            get { return carteiraTrabalho; }
            set { carteiraTrabalho = value; }
        }
        public Int64 CodFunc
        {
            get { return codFunc; }
            set { codFunc = value; }
        }
        public DateTime DataAdimissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        public DateTime? DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Int64 Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public bool Contas
        {
            get { return contas; }
            set { contas = value; }
        }

        //public Int64 CarteiraTrabalho { get; set; }
        //public DateTime DataAdimissao { get; set; }
        //public DateTime? DataDemissao { get; set; }
        //public decimal Salario { get; set; }
        //public Int64 Comissao{ get; set; }

        //************LOGIN**************

        private static string usuario;
        private static string senha;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        //public string Usuario { get; set; }
        //public string Senha { get; set; }

    }
}
