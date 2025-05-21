using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagarEmprestimo.Controller;
using PagarEmprestimo.Model;

namespace PagarEmprestimo
{
    public partial class FormCadastrarEmprestimo : Form
    {
        private Sistema sistema;
        public FormCadastrarEmprestimo(Sistema sistema)
        {
            InitializeComponent();
            this.sistema = sistema;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string nomeCredor = txt_credor.Text.Trim();
            string nomeDevedor = txt_devedor.Text.Trim();
            string senhaDevedor = txt_senhaDevedor.Text.Trim();
            string valorTexto = txt_valorEmprestimo.Text.Trim();
            DateTime data = dt_dataEmprestimo.Value;

            if (string.IsNullOrEmpty(nomeCredor) || string.IsNullOrEmpty(nomeDevedor) ||
                string.IsNullOrEmpty(senhaDevedor) || string.IsNullOrEmpty(valorTexto))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!float.TryParse(valorTexto, out float valor))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            string resultado = sistema.CadastrarEmprestimo(nomeCredor, nomeDevedor, valor, data, senhaDevedor);
            MessageBox.Show(resultado);
        }
    }
}
