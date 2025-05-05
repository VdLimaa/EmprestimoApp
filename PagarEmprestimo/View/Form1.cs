using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagarEmprestimo.Model;
using PagarEmprestimo.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PagarEmprestimo
{
    public partial class Form1 : Form
    {
        private readonly EmprestimoController controller;
        private Divida dividaSelecionada;
        public Form1()
        {
            InitializeComponent();
            controller = new EmprestimoController();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar DataGridView
            dgv_emprestimos.AutoGenerateColumns = false;
            dgv_emprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_emprestimos.MultiSelect = false;

            // Definir colunas manualmente
            dgv_emprestimos.Columns.Add("Emprestimo", "EMPRÉSTIMO");
            dgv_emprestimos.Columns.Add("Juros", "JUROS");
            dgv_emprestimos.Columns.Add("ValorTotal", "VALOR TOTAL");
            dgv_emprestimos.Columns.Add("Data", "DATA");

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nomeDevedor = txt_devedor.Text.Trim();
            string nomeCredor = txt_credor.Text.Trim();

            if (string.IsNullOrEmpty(nomeDevedor) || string.IsNullOrEmpty(nomeCredor))
            {
                MessageBox.Show("Por favor, preencha os nomes do devedor e do credor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dividas = controller.BuscarDevedorCredor(nomeDevedor, nomeCredor);
            if (dividas.Count == 0)
            {
                MessageBox.Show("Nenhuma dívida ativa encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Preencher DataGridView manualmente
            dgv_emprestimos.Rows.Clear();
            foreach (var divida in dividas)
            {
                int rowIndex = dgv_emprestimos.Rows.Add(divida.Valor.ToString("C"), divida.Juros.ToString("C"), divida.ValorTotal.ToString("C"), divida.DataEmprestimo.ToString("dd/MM/yyyy"));
                dgv_emprestimos.Rows[rowIndex].Tag = divida; // Associar o objeto Divida à linha
            }
        }

        private void dgv_emprestimos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emprestimos.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_emprestimos.SelectedRows[0];
                dividaSelecionada = selectedRow.Tag as Divida;

                if (dividaSelecionada == null)
                {
                    MessageBox.Show("Erro: Dívida selecionada é nula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dividaSelecionada = null;
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (dividaSelecionada == null)
            {
                MessageBox.Show("Selecione uma dívida para pagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string senha = txt_senha.Text.Trim();
            if (!controller.ValidarAssinatura(senha))
            {
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool sucesso = controller.ProcessarPagamento(dividaSelecionada.Id);
            if (sucesso)
            {
                MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao processar o pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar a lista de dívidas
            btn_buscar_Click(sender, e);
        }

        private void dgv_emprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
