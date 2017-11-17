using System;

namespace SysPark.Model
{
    public class ModFornecedor : ModPessoas
    {
        private static string nomeFantasi;
        private static string razaoSocial;
        private static string iEstadual;
        private static bool tipoPessoa;
        private static DateTime dataCadFornecedor;

        public string NomeFantasia
        {
            get { return nomeFantasi; }
            set { nomeFantasi = value; }
        }
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        public string IEstadual
        {
            get { return iEstadual; }
            set { iEstadual = value; }
        }
        public bool TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = value; }
        }
        public DateTime DataCadFornecedor
        {
            get { return dataCadFornecedor; }
            set { dataCadFornecedor = value; }
        }        
    }
}
