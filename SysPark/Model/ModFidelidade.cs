namespace SysPark.Model
{
    public class ModFidelidade : ModCliente
    {
        private static long idTipoFidelidade;
        private static string nomeFidelidadde;
        private static bool situacaoFidelidade;
        private static long idProduto;
        private static int descFidel;
        private static long idPrecoFidelidade;

        public long IdTipoFidelidade
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
        public long IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        public int DescFidel
        {
            get { return descFidel; }
            set { descFidel = value; }
        }
        public long IdPrecoFidelidade
        {
            get { return idPrecoFidelidade; }
            set { idPrecoFidelidade = value; }
        }
    }
}
