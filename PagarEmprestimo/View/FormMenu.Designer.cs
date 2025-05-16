namespace PagarEmprestimo
{
    partial class FormMenu
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
            this.btn_cadastrarEmprestimo = new System.Windows.Forms.Button();
            this.lb_escolha = new System.Windows.Forms.Label();
            this.lb_tituloMenu = new System.Windows.Forms.Label();
            this.btn_pagarEmprestimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrarEmprestimo
            // 
            this.btn_cadastrarEmprestimo.Location = new System.Drawing.Point(4, 206);
            this.btn_cadastrarEmprestimo.Name = "btn_cadastrarEmprestimo";
            this.btn_cadastrarEmprestimo.Size = new System.Drawing.Size(482, 29);
            this.btn_cadastrarEmprestimo.TabIndex = 0;
            this.btn_cadastrarEmprestimo.Text = "Cadastrar Empréstimo";
            this.btn_cadastrarEmprestimo.UseVisualStyleBackColor = true;
            this.btn_cadastrarEmprestimo.Click += new System.EventHandler(this.btn_cadastrarEmprestimo_Click);
            // 
            // lb_escolha
            // 
            this.lb_escolha.AutoSize = true;
            this.lb_escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_escolha.Location = new System.Drawing.Point(166, 85);
            this.lb_escolha.Name = "lb_escolha";
            this.lb_escolha.Size = new System.Drawing.Size(154, 17);
            this.lb_escolha.TabIndex = 1;
            this.lb_escolha.Text = "Escolha uma opção:";
            // 
            // lb_tituloMenu
            // 
            this.lb_tituloMenu.AutoSize = true;
            this.lb_tituloMenu.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tituloMenu.Location = new System.Drawing.Point(138, 21);
            this.lb_tituloMenu.Name = "lb_tituloMenu";
            this.lb_tituloMenu.Size = new System.Drawing.Size(216, 31);
            this.lb_tituloMenu.TabIndex = 2;
            this.lb_tituloMenu.Text = "MENU INICIAL";
            // 
            // btn_pagarEmprestimo
            // 
            this.btn_pagarEmprestimo.Location = new System.Drawing.Point(4, 241);
            this.btn_pagarEmprestimo.Name = "btn_pagarEmprestimo";
            this.btn_pagarEmprestimo.Size = new System.Drawing.Size(482, 29);
            this.btn_pagarEmprestimo.TabIndex = 3;
            this.btn_pagarEmprestimo.Text = "Pagar Empréstimo";
            this.btn_pagarEmprestimo.UseVisualStyleBackColor = true;
            this.btn_pagarEmprestimo.Click += new System.EventHandler(this.btn_pagarEmprestimo_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btn_pagarEmprestimo);
            this.Controls.Add(this.lb_tituloMenu);
            this.Controls.Add(this.lb_escolha);
            this.Controls.Add(this.btn_cadastrarEmprestimo);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrarEmprestimo;
        private System.Windows.Forms.Label lb_escolha;
        private System.Windows.Forms.Label lb_tituloMenu;
        private System.Windows.Forms.Button btn_pagarEmprestimo;
    }
}