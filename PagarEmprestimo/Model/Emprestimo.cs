using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagarEmprestimo.Model
{
    public class Emprestimo
    {
        public string Credor { get; set; }
        public string Devedor { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public bool Pago { get; set; }

        public Emprestimo(string credor, string devedor, decimal valor)
        {
            Credor = credor;
            Devedor = devedor;
            Valor = valor;
            DataEmprestimo = DateTime.Now.AddDays(-45); // valor fictício
            Pago = false;
        }

        public decimal CalcularValorAtualizado()
        {
            var dias = (DateTime.Now - DataEmprestimo).Days;
            if (dias <= 0) return Valor;

            var jurosDiarios = dias * 0.001m; // 0.1% ao dia
            var juros30Dias = (dias / 30) * 0.10m; // 10% a cada 30 dias

            var valorAtualizado = Valor * (1 + jurosDiarios + juros30Dias);
            return Math.Round(valorAtualizado, 2);
        }
    }
}
