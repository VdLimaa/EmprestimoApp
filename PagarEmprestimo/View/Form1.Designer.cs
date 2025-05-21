namespace PagarEmprestimo
{
    partial class Form1
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
            this.lb_devedor = new System.Windows.Forms.Label();
            this.txt_devedor = new System.Windows.Forms.TextBox();
            this.dgv_emprestimos = new System.Windows.Forms.DataGridView();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.txt_credor = new System.Windows.Forms.TextBox();
            this.lb_credor = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lb_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_devedor
            // 
            this.lb_devedor.AutoSize = true;
            this.lb_devedor.BackColor = System.Drawing.Color.Azure;
            this.lb_devedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_devedor.Location = new System.Drawing.Point(111, 114);
            this.lb_devedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_devedor.Name = "lb_devedor";
            this.lb_devedor.Size = new System.Drawing.Size(141, 20);
            this.lb_devedor.TabIndex = 0;
            this.lb_devedor.Text = "Nome do Devedor:";
            // 
            // txt_devedor
            // 
            this.txt_devedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_devedor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_devedor.Location = new System.Drawing.Point(266, 109);
            this.txt_devedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_devedor.Name = "txt_devedor";
            this.txt_devedor.Size = new System.Drawing.Size(194, 26);
            this.txt_devedor.TabIndex = 1;
            // 
            // dgv_emprestimos
            // 
            this.dgv_emprestimos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_emprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emprestimos.Location = new System.Drawing.Point(18, 258);
            this.dgv_emprestimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_emprestimos.Name = "dgv_emprestimos";
            this.dgv_emprestimos.RowHeadersWidth = 62;
            this.dgv_emprestimos.Size = new System.Drawing.Size(1164, 272);
            this.dgv_emprestimos.TabIndex = 2;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(998, 562);
            this.btn_pagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(135, 46);
            this.btn_pagar.TabIndex = 3;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // txt_credor
            // 
            this.txt_credor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_credor.Location = new System.Drawing.Point(266, 178);
            this.txt_credor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_credor.Name = "txt_credor";
            this.txt_credor.Size = new System.Drawing.Size(194, 26);
            this.txt_credor.TabIndex = 4;
            // 
            // lb_credor
            // 
            this.lb_credor.AutoSize = true;
            this.lb_credor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_credor.Location = new System.Drawing.Point(111, 183);
            this.lb_credor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_credor.Name = "lb_credor";
            this.lb_credor.Size = new System.Drawing.Size(129, 20);
            this.lb_credor.TabIndex = 5;
            this.lb_credor.Text = "Nome do Credor:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(998, 178);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(135, 46);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_senha.Location = new System.Drawing.Point(111, 571);
            this.lb_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(134, 20);
            this.lb_senha.TabIndex = 8;
            this.lb_senha.Text = "Senha do Credor:";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_senha.Location = new System.Drawing.Point(255, 566);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(148, 26);
            this.txt_senha.TabIndex = 7;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_titulo.Location = new System.Drawing.Point(504, 14);
            this.lb_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(264, 32);
            this.lb_titulo.TabIndex = 9;
            this.lb_titulo.Text = "Pagar Empréstimo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lb_credor);
            this.Controls.Add(this.txt_credor);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.dgv_emprestimos);
            this.Controls.Add(this.txt_devedor);
            this.Controls.Add(this.lb_devedor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_devedor;
        private System.Windows.Forms.TextBox txt_devedor;
        private System.Windows.Forms.DataGridView dgv_emprestimos;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.TextBox txt_credor;
        private System.Windows.Forms.Label lb_credor;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lb_titulo;
    }
}

