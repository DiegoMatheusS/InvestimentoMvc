using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestimentoMvc.Models
{
    public class MoedaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataVenda { get; set; }
        public double Lucro { get; set; }
        public double Prejuizo { get; set; }
        public double Imposto { get; set; }

    }
}