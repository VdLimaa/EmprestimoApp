using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagarEmprestimo.Model;

namespace PagarEmprestimo.Controller
{
    public class Sistema
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public Sistema()
        {
           
            


            var joao = new Usuario("João", "123");
            var maria = new Usuario("Maria", "456");
            var carlos = new Usuario("Carlos", "789");
            var ana = new Usuario("Ana", "321");

            usuarios.AddRange(new[] { joao, maria, carlos, ana });

            emprestimos.Add(new Emprestimo(joao, maria, 100, DateTime.Now.AddDays(-40)));
            emprestimos.Add(new Emprestimo(joao, maria, 250, DateTime.Now.AddDays(-70)));
            emprestimos.Add(new Emprestimo(joao, maria, 500, DateTime.Now.AddDays(-15)));
            emprestimos.Add(new Emprestimo(joao, carlos, 200, DateTime.Now.AddDays(-10)));
            emprestimos.Add(new Emprestimo(maria, ana, 300, DateTime.Now.AddDays(-20)));


            emprestimos[0].DataEmprestimo = DateTime.Now.AddDays(-40);
            emprestimos[1].DataEmprestimo = DateTime.Now.AddDays(-70);
            emprestimos[2].DataEmprestimo = DateTime.Now.AddDays(-15);
        }

        public List<Emprestimo> ObterDividas(string credor, string devedor)
        {
            return emprestimos
                .Where(e => e.Credor.Nome == credor && e.Devedor.Nome == devedor && !e.Pago)
                .ToList();
        }

        public bool ValidarAssinatura(string credor, string senha)
        {
            return usuarios.Any(u => u.Nome == credor && u.Senha == senha);
        }

        public bool ProcessarPagamento(string senha, Emprestimo emprestimo)
        {
            bool assinaturaValida2 = emprestimo.Credor.Senha == senha;
            
            if (!assinaturaValida2)
            {
                return false; 
            }


            var item = emprestimos.FirstOrDefault(e =>
                e.Credor.Nome == emprestimo.Credor.Nome &&
                e.Devedor.Nome == emprestimo.Devedor.Nome &&
                e.Valor == emprestimo.Valor &&
                e.DataEmprestimo == emprestimo.DataEmprestimo &&
                !e.Pago);


            if (item != null)
            {
                item.Pago = true;
                return true;
            }

            return false; 
        }

        public string CadastrarEmprestimo(string nomeCredor, string nomeDevedor, float valor, DateTime data, string senhaDevedor)
        {
            var credor = usuarios.FirstOrDefault(u => u.Nome == nomeCredor);
            var devedor = usuarios.FirstOrDefault(u => u.Nome == nomeDevedor);

            if (credor == null || devedor == null)
                return "Credor ou devedor não encontrado.";

            if (credor.Nome == devedor.Nome)
                return "Credor e devedor não podem ser a mesma pessoa.";

            if (devedor.Senha != senhaDevedor)
                return "Senha do devedor incorreta.";

            emprestimos.Add(new Emprestimo(credor, devedor, valor, data));
            return "Empréstimo cadastrado com sucesso!";
        }
    }
}
