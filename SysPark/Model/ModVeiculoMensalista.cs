using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPark.Model
{
    public class ModVeiculoMensalista
    {
        private int ID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        private long IDCliente;

        public long idCliente
        {
            get { return IDCliente; }
            set { IDCliente = value; }
        }

        private string Placa;

        public string placa
        {
            get { return Placa; }
            set { Placa = value; }
        }

        private int IDTipoVeiculo;

        public int idTipoVeiculo
        {
            get { return IDTipoVeiculo; }
            set { IDTipoVeiculo = value; }
        }

    }
}
