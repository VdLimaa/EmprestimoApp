using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagarEmprestimo.Model;

namespace PagarEmprestimo.Controller
{
    public class EmprestimoController
    {
        private const string SenhaCorreta = "123"; // Simulação de senha fixa

        public List<Divida> BuscarDevedorCredor(string nomeDevedor, string nomeCredor)
        {
            return RepositorioDividas.BuscarDividas(nomeDevedor, nomeCredor);
        }

        public Divida ObterDetalhesDivida(int id)
        {
            return RepositorioDividas.ObterDividaPorId(id);
        }

        public bool ValidarAssinatura(string senha)
        {
            return senha == SenhaCorreta;
        }

        public bool ProcessarPagamento(int id)
        {
            var divida = RepositorioDividas.ObterDividaPorId(id);
            if (divida == null || divida.Paga)
            {
                return false;
            }

            return RepositorioDividas.PagarDivida(id); // Agora retorna bool
        }
    }
}
