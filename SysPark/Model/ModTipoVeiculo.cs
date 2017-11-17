 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPark.Model
{
    public class ModTipoVeiculo
    {
        private static int idTipo;
        private static string descrição;
        private static int cortesiaAte;
        private static decimal valorHora;
        private static bool ativo;


        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }

        public string Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }

        public int CortesiaAte
        {
            get { return cortesiaAte; }
            set { cortesiaAte = value; }
        }
        public decimal ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }
}
