using System;

namespace SysPark
{
    public class ModAtualizacao
    {
        private static string nomeAtualiza;
        private static DateTime dataAtualiza;

        public string NomeAtualiza
        {
            get { return nomeAtualiza; }
            set { nomeAtualiza = value; }
        }
        public DateTime DataAtualiza
        {
            get { return dataAtualiza; }
            set { dataAtualiza = value; }
        }
    }
}
