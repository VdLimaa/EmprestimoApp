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
            dgv_emprestimos.AutoGenerateColumns = false;
            dgv_emprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_emprestimos.MultiSelect = false;

            // Garantir que o DataGridView seja somente leitura
            dgv_emprestimos.ReadOnly = true;

            // Definir as colunas do DataGridView
            dgv_emprestimos.Columns.Add("Emprestimo", "EMPRÉSTIMO");
            dgv_emprestimos.Columns.Add("Juros", "JUROS");
            dgv_emprestimos.Columns.Add("ValorTotal", "VALOR TOTAL");
            dgv_emprestimos.Columns.Add("Data", "DATA");

            // Configurar o evento de seleção de linha
            dgv_emprestimos.SelectionChanged += dgv_emprestimos_SelectionChanged;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nomeDevedor = txt_devedor.Text.Trim();
            string nomeCredor = txt_credor.Text.Trim();

            // Validar os campos de Devedor e Credor
            if (string.IsNullOrEmpty(nomeDevedor) || string.IsNullOrEmpty(nomeCredor))
            {
                MessageBox.Show("Por favor, preencha os nomes do devedor e do credor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar as dívidas com base no devedor e credor
            var dividas = controller.BuscarDevedorCredor(nomeDevedor, nomeCredor);

            if (dividas.Count == 0)
            {
                MessageBox.Show("Nenhuma dívida ativa encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_emprestimos.Rows.Clear();
                btn_pagar.Enabled = false; // Desabilitar o botão de pagar se não houver dívidas
                return;
            }

            // Limpar o DataGridView antes de adicionar as novas linhas
            dgv_emprestimos.Rows.Clear();

            // Adicionar as dívidas ao DataGridView
            foreach (var divida in dividas)
            {
                int rowIndex = dgv_emprestimos.Rows.Add(
                    divida.Valor.ToString("C"),
                    divida.Juros.ToString("C"),
                    divida.ValorTotal.ToString("C"),
                    divida.DataEmprestimo.ToString("dd/MM/yyyy"));

                // Associar a dívida ao Tag da linha
                dgv_emprestimos.Rows[rowIndex].Tag = divida;
            }

            // Após a busca, nenhuma dívida ainda está selecionada, então desabilitamos o botão "Pagar"
            dividaSelecionada = null;
            btn_pagar.Enabled = false; // Desabilitar o botão até que o usuário selecione uma dívida

        }

        private void dgv_emprestimos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emprestimos.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_emprestimos.SelectedRows[0];
                dividaSelecionada = selectedRow.Tag as Divida;

                // Habilitar o botão de pagar se uma dívida foi selecionada
                btn_pagar.Enabled = dividaSelecionada != null;
            }
            else
            {
                dividaSelecionada = null;

                // Desabilitar o botão "Pagar" se nenhuma dívida foi selecionada
                btn_pagar.Enabled = false;
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

            // Processar o pagamento da dívida
            bool sucesso = controller.ProcessarPagamento(dividaSelecionada.Id);

            if (sucesso)
            {
                MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarregar a lista de dívidas após o pagamento para atualizar o DataGridView
                btn_buscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao processar o pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

