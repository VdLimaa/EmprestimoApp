using PagarEmprestimo.Controller;
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


namespace PagarEmprestimo
{
    public partial class FormMenu : Form
    {
        private Sistema sistema;
        public FormMenu()
        {
            InitializeComponent();
            sistema = new Sistema();
        }

        private void btn_cadastrarEmprestimo_Click(object sender, EventArgs e)
        {
            FormCadastrarEmprestimo telaCadastro = new FormCadastrarEmprestimo(sistema);
            telaCadastro.Show();
        }

        private void btn_pagarEmprestimo_Click(object sender, EventArgs e)
        {
            Form1 telaPagamento = new Form1(sistema);
            telaPagamento.Show();
        }
    }
}
