using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagarEmprestimo.Model
{
    public class Emprestimo
    {
        public Usuario Credor { get; set; }
        public Usuario Devedor { get; set; }
        public float Valor { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public bool Pago { get; set; }

        public Emprestimo(Usuario credor, Usuario devedor, float valor, DateTime dataEmprestimo)
        {
            Credor = credor;
            Devedor = devedor;
            Valor = valor;
            DataEmprestimo = dataEmprestimo;
            Pago = false;
        }

        public float CalcularValorAtualizado()
        {
            var dias = (DateTime.Now - DataEmprestimo).Days;
            if (dias <= 0) return (float)Valor;

            var jurosDiarios = dias * 0.001f; 
            var juros30Dias = (dias / 30) * 0.10f; 

            var valorAtualizado = (float)(Valor * (1 + jurosDiarios + juros30Dias));
            return (float)Math.Round(valorAtualizado, 2);
        }
    }
}
