namespace SysPark
{
    public class ModImpressora : ModAtualizacao
    {
        private static int idImpressora;
        private static string marca;
        private static bool situacao;
        public static int idImpTer;

        public int IdImpTer
        {
            get { return idImpTer; }
            set { idImpTer = value; }
        }

        public int IdImpressora
        {
            get { return idImpressora; }
            set { idImpressora = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public bool SituacaoImpressora
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
