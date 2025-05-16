using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagarEmprestimo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_cadastrarEmprestimo_Click(object sender, EventArgs e)
        {
            FormCadastrarEmprestimo telaCadastro = new FormCadastrarEmprestimo();
            telaCadastro.Show();
        }

        private void btn_pagarEmprestimo_Click(object sender, EventArgs e)
        {
            Form1 telaPagamento = new Form1();
            telaPagamento.Show();
        }
    }
}
