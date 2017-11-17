
namespace SysPark
{
    public class ModCargo : ModAtualizacao 
    {
        
        private static int id;
        private static string nome;
        private static bool situacao;

        
        public int IdCargo
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeCargo
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool SituacaoCargo
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
