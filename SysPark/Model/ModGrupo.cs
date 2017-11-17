namespace SysPark.Model
{
    public class ModGrupo : ModAtualizacao
    {
        private static int idGrupo;
        private static string nomeGrupo;
        private static bool sitGrupo;
        private static bool sitSubGrupo;
        private static int idSubGrupo;
        private static string nomeSubGrupo;


        public int IdGRupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public string NomeGrupo
        {
            get { return nomeGrupo; }
            set { nomeGrupo = value; }
        }

        public bool SitGrupo
        {
            get { return sitGrupo; }
            set { sitGrupo = value; }
        }
        public int IdSubGRupo
        {
            get { return idSubGrupo; }
            set { idSubGrupo = value; }
        }

        public string NomeSubGrupo
        {
            get { return nomeSubGrupo; }
            set { nomeSubGrupo = value; }
        }

        public bool SitSubGrupo
        {
            get { return sitSubGrupo; }
            set { sitSubGrupo = value; }
        }
    }
}
