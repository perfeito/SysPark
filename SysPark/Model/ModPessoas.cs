using System;

namespace SysPark
{
    public class ModPessoas : ModAtualizacao
    {
        private static Int64 idcpfcnpjPessoa;
        private static string nomePessoa;
        private static string rg;
        private static bool situacaoPessoa;
        private static DateTime dataNascimento;
        private static byte[] imagemPessoa;

        public byte[] ImagemPessoa
        {
            get { return imagemPessoa; }
            set { imagemPessoa = value; }
        }

        public Int64 IdcpfcnpjPessoa
        {
            get { return idcpfcnpjPessoa; }
            set { idcpfcnpjPessoa = value; }
        }

        public string NomePessoa
        {
            get { return nomePessoa; }
            set { nomePessoa = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public bool SituacaoPessoa
        {
            get { return situacaoPessoa; }
            set { situacaoPessoa = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }        

        // ***ENDEREÇOS****

        private static int idEndereco;
        private static string logradouro;
        private static int numero;
        private static string bairro;
        private static string uf;
        private static string cidade;
        private static string cep;

        public int IdEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public int NumeroEnd
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string UF 
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }        

        //****CONTATOS*****


        private static int idContato;
        private static string telefone;
        private static string celular;
        private static string email;
        private static string website;

        public int IdContato
        {
            get { return idContato; }
            set { idContato = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }  
    }
}
