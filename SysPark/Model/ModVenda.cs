using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPark.Model
{
    public class ModVenda
    {
        public long ID { get; set; }
        public string Descricao { get; set; }
        public string Placa { get; set; }
        public int IDTipoVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public decimal HoraValor { get; set; }
        public int MinCortesia { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public DateTime HoraSaida { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Dinheiro { get; set; }
        public long IdVeiculoMensalista { get; set; }
        public long IdCaixaAbertura { get; set; }
        public long IdCaixaFechamento { get; set; }
    }
}
