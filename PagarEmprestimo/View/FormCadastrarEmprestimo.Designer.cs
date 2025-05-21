namespace PagarEmprestimo
{
    partial class FormCadastrarEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_credor = new System.Windows.Forms.TextBox();
            this.lb_credor = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lb_devedor = new System.Windows.Forms.Label();
            this.txt_devedor = new System.Windows.Forms.TextBox();
            this.lb_valorEmprestimo = new System.Windows.Forms.Label();
            this.txt_valorEmprestimo = new System.Windows.Forms.TextBox();
            this.lb_dtEmprestimo = new System.Windows.Forms.Label();
            this.lb_senhaDevedor = new System.Windows.Forms.Label();
            this.txt_senhaDevedor = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.dt_dataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_credor
            // 
            this.txt_credor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_credor.Location = new System.Drawing.Point(228, 147);
            this.txt_credor.Name = "txt_credor";
            this.txt_credor.Size = new System.Drawing.Size(229, 26);
            this.txt_credor.TabIndex = 0;
            // 
            // lb_credor
            // 
            this.lb_credor.AutoSize = true;
            this.lb_credor.Location = new System.Drawing.Point(93, 147);
            this.lb_credor.Name = "lb_credor";
            this.lb_credor.Size = new System.Drawing.Size(129, 20);
            this.lb_credor.TabIndex = 1;
            this.lb_credor.Text = "Nome do Credor:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(954, 517);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(144, 67);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lb_devedor
            // 
            this.lb_devedor.AutoSize = true;
            this.lb_devedor.Location = new System.Drawing.Point(81, 195);
            this.lb_devedor.Name = "lb_devedor";
            this.lb_devedor.Size = new System.Drawing.Size(141, 20);
            this.lb_devedor.TabIndex = 4;
            this.lb_devedor.Text = "Nome do Devedor:";
            // 
            // txt_devedor
            // 
            this.txt_devedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_devedor.Location = new System.Drawing.Point(228, 195);
            this.txt_devedor.Name = "txt_devedor";
            this.txt_devedor.Size = new System.Drawing.Size(229, 26);
            this.txt_devedor.TabIndex = 3;
            // 
            // lb_valorEmprestimo
            // 
            this.lb_valorEmprestimo.AutoSize = true;
            this.lb_valorEmprestimo.Location = new System.Drawing.Point(61, 252);
            this.lb_valorEmprestimo.Name = "lb_valorEmprestimo";
            this.lb_valorEmprestimo.Size = new System.Drawing.Size(161, 20);
            this.lb_valorEmprestimo.TabIndex = 6;
            this.lb_valorEmprestimo.Text = "Valor do Empréstimo:";
            // 
            // txt_valorEmprestimo
            // 
            this.txt_valorEmprestimo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_valorEmprestimo.Location = new System.Drawing.Point(228, 249);
            this.txt_valorEmprestimo.Name = "txt_valorEmprestimo";
            this.txt_valorEmprestimo.Size = new System.Drawing.Size(229, 26);
            this.txt_valorEmprestimo.TabIndex = 5;
            // 
            // lb_dtEmprestimo
            // 
            this.lb_dtEmprestimo.AutoSize = true;
            this.lb_dtEmprestimo.Location = new System.Drawing.Point(63, 305);
            this.lb_dtEmprestimo.Name = "lb_dtEmprestimo";
            this.lb_dtEmprestimo.Size = new System.Drawing.Size(159, 20);
            this.lb_dtEmprestimo.TabIndex = 8;
            this.lb_dtEmprestimo.Text = "Data do Empréstimo:";
            // 
            // lb_senhaDevedor
            // 
            this.lb_senhaDevedor.AutoSize = true;
            this.lb_senhaDevedor.Location = new System.Drawing.Point(76, 540);
            this.lb_senhaDevedor.Name = "lb_senhaDevedor";
            this.lb_senhaDevedor.Size = new System.Drawing.Size(146, 20);
            this.lb_senhaDevedor.TabIndex = 10;
            this.lb_senhaDevedor.Text = "Senha do Devedor:";
            // 
            // txt_senhaDevedor
            // 
            this.txt_senhaDevedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_senhaDevedor.Location = new System.Drawing.Point(228, 537);
            this.txt_senhaDevedor.Name = "txt_senhaDevedor";
            this.txt_senhaDevedor.Size = new System.Drawing.Size(229, 26);
            this.txt_senhaDevedor.TabIndex = 9;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(447, 18);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(359, 37);
            this.lb_titulo.TabIndex = 11;
            this.lb_titulo.Text = "Cadastrar Empréstimo";
            // 
            // dt_dataEmprestimo
            // 
            this.dt_dataEmprestimo.Location = new System.Drawing.Point(228, 299);
            this.dt_dataEmprestimo.Name = "dt_dataEmprestimo";
            this.dt_dataEmprestimo.Size = new System.Drawing.Size(200, 26);
            this.dt_dataEmprestimo.TabIndex = 12;
            // 
            // FormCadastrarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1194, 692);
            this.Controls.Add(this.dt_dataEmprestimo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_senhaDevedor);
            this.Controls.Add(this.txt_senhaDevedor);
            this.Controls.Add(this.lb_dtEmprestimo);
            this.Controls.Add(this.lb_valorEmprestimo);
            this.Controls.Add(this.txt_valorEmprestimo);
            this.Controls.Add(this.lb_devedor);
            this.Controls.Add(this.txt_devedor);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lb_credor);
            this.Controls.Add(this.txt_credor);
            this.Name = "FormCadastrarEmprestimo";
            this.Text = "FormCadastrarEmprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_credor;
        private System.Windows.Forms.Label lb_credor;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lb_devedor;
        private System.Windows.Forms.TextBox txt_devedor;
        private System.Windows.Forms.Label lb_valorEmprestimo;
        private System.Windows.Forms.TextBox txt_valorEmprestimo;
        private System.Windows.Forms.Label lb_dtEmprestimo;
        private System.Windows.Forms.Label lb_senhaDevedor;
        private System.Windows.Forms.TextBox txt_senhaDevedor;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.DateTimePicker dt_dataEmprestimo;
    }
}