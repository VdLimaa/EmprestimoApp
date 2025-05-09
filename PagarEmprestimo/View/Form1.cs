using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using PagarEmprestimo.Model;
using PagarEmprestimo.Controller;

namespace PagarEmprestimo
{
    public partial class Form1 : Form
    {
        private Sistema service;
        private List<Emprestimo> listaAtual;

        public Form1()
        {
            InitializeComponent();
            service = new Sistema();

            dgv_emprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_emprestimos.MultiSelect = false;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string credor = txt_credor.Text.Trim();
            string devedor = txt_devedor.Text.Trim();

            if (string.IsNullOrEmpty(credor) || string.IsNullOrEmpty(devedor))
            {
                MessageBox.Show("Informe o nome do credor e do devedor.");
                return;
            }

            listaAtual = service.ObterDividas(credor, devedor);

            if (listaAtual.Count == 0)
            {
                MessageBox.Show("Nenhuma dívida encontrada.");
                dgv_emprestimos.DataSource = null;
            }
            else
            {
                dgv_emprestimos.DataSource = listaAtual.Select(emp => new
                {
                    Valor = emp.Valor,
                    ValorAtualizado = emp.CalcularValorAtualizado(),
                    DataEmprestimo = emp.DataEmprestimo.ToShortDateString()
                }).ToList();
            }

        }

        private void dgv_emprestimos_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (dgv_emprestimos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma dívida para pagar.");
                return;
            }

            string senha = txt_senha.Text.Trim();
            string credor = txt_credor.Text.Trim();

            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(credor))
            {
                MessageBox.Show("Informe o nome e a senha do credor.");
                return;
            }

            int index = dgv_emprestimos.SelectedRows[0].Index;
            Emprestimo emprestimo = listaAtual[index];

            // Chamada atualizada passando credor, senha e empréstimo
            if (service.ProcessarPagamento(credor, senha, emprestimo))
            {
                MessageBox.Show("Pagamento realizado com sucesso!");
                btn_buscar.PerformClick(); // Atualiza lista
            }
            else
            {
                MessageBox.Show("Erro ao processar pagamento. Verifique a senha ou se a dívida já foi quitada.");
            }
        }
    }
    

}

