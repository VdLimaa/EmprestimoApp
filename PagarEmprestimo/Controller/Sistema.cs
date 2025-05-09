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
           
            usuarios.Add(new Usuario("João", "123"));
            usuarios.Add(new Usuario("Maria", "456"));

            
            emprestimos.Add(new Emprestimo("João", "Maria", 100));
            emprestimos.Add(new Emprestimo("João", "Maria", 250));
            emprestimos.Add(new Emprestimo("João", "Maria", 500));
            emprestimos.Add(new Emprestimo("João", "Carlos", 200));
            emprestimos.Add(new Emprestimo("Maria", "Ana", 300));

            
            emprestimos[0].DataEmprestimo = DateTime.Now.AddDays(-40);
            emprestimos[1].DataEmprestimo = DateTime.Now.AddDays(-70);
            emprestimos[2].DataEmprestimo = DateTime.Now.AddDays(-15);
        }

        public List<Emprestimo> ObterDividas(string credor, string devedor)
        {
            return emprestimos
                .Where(e => e.Credor == credor && e.Devedor == devedor && !e.Pago)
                .ToList();
        }

        public bool ValidarAssinatura(string credor, string senha)
        {
            return usuarios.Any(u => u.Nome == credor && u.Senha == senha);
        }

        public bool ProcessarPagamento(string credor, string senha, Emprestimo emprestimo)
        {
            // Validação da assinatura digital do credor
            bool assinaturaValida = usuarios.Any(u => u.Nome == credor && u.Senha == senha);

            if (!assinaturaValida)
            {
                return false; // Credor ou senha inválidos
            }

            // Localiza o empréstimo correspondente ainda não quitado
            var item = emprestimos.FirstOrDefault(e =>
                e.Credor == emprestimo.Credor &&
                e.Devedor == emprestimo.Devedor &&
                e.Valor == emprestimo.Valor &&
                e.DataEmprestimo == emprestimo.DataEmprestimo &&
                !e.Pago);

            if (item != null)
            {
                item.Pago = true;
                return true; // Pagamento processado com sucesso
            }

            return false; // Empréstimo não encontrado ou já quitado
        }
    }
}
