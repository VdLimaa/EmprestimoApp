using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagarEmprestimo.Model
{
    public class RepositorioDividas
    {
        private static List<Divida> dividas = new List<Divida>
        {
            new Divida
            {
                Id = 1,
                Devedor = new Pessoa { Nome = "João" },
                Credor = new Pessoa { Nome = "Maria" },
                Valor = 10.00m,
                DataEmprestimo = new DateTime(2011, 9, 3),
                DataVencimento = new DateTime(2011, 10, 3),
                Paga = false
            }
        };

        public static List<Divida> BuscarDividas(string nomeDevedor, string nomeCredor)
        {
            if (string.IsNullOrEmpty(nomeDevedor) || string.IsNullOrEmpty(nomeCredor))
            {
                return new List<Divida>(); // Retornar lista vazia se os parâmetros forem nulos ou vazios
            }

            var dividasEncontradas = dividas
                .Where(d => d.Devedor.Nome.Equals(nomeDevedor, StringComparison.OrdinalIgnoreCase) &&
                            d.Credor.Nome.Equals(nomeCredor, StringComparison.OrdinalIgnoreCase) &&
                            !d.Paga)
                .ToList();

            // Calcular juros para cada dívida
            foreach (var divida in dividasEncontradas)
            {
                divida.CalcularJuros();
            }

            return dividasEncontradas;
        }

        public static Divida ObterDividaPorId(int id)
        {
            var divida = dividas.FirstOrDefault(d => d.Id == id); 
            if (divida != null)
            {
                divida.CalcularJuros();
            }
            return divida;
        }

        public static bool PagarDivida(int id)
        {
            var divida = dividas.FirstOrDefault(d => d.Id == id);
            if (divida != null)
            {
                divida.Paga = true;
                return true;
            }
            return false;
        }
    }
}
