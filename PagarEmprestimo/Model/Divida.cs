using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagarEmprestimo.Model
{
    public class Divida
    {
        public int Id { get; set; }
        public Pessoa Devedor { get; set; }
        public Pessoa Credor { get; set; }
        public decimal Valor { get; set; } // Valor original do empréstimo
        public decimal Juros { get; set; } // Juros calculados
        public decimal ValorTotal { get; set; } // Valor + Juros
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataVencimento { get; set; }
        public bool Paga { get; set; }

        // Método para calcular juros (10% ao ano, simplificado)
        public void CalcularJuros()
        {
            int anos = (DateTime.Now.Year - DataEmprestimo.Year);
            Juros = Valor * 0.10m * anos; // 10% por ano
            ValorTotal = Valor + Juros;
        }
    }
}
