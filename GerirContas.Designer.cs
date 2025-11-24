namespace QuickShop
{
    partial class GerirContas
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
            this.lista_contas = new System.Windows.Forms.ListBox();
            this.btn_resetar_palavras = new System.Windows.Forms.Button();
            this.btn_resetar_senha = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_contas
            // 
            this.lista_contas.FormattingEnabled = true;
            this.lista_contas.Location = new System.Drawing.Point(12, 12);
            this.lista_contas.Name = "lista_contas";
            this.lista_contas.Size = new System.Drawing.Size(589, 186);
            this.lista_contas.TabIndex = 0;
            // 
            // btn_resetar_palavras
            // 
            this.btn_resetar_palavras.Location = new System.Drawing.Point(12, 335);
            this.btn_resetar_palavras.Name = "btn_resetar_palavras";
            this.btn_resetar_palavras.Size = new System.Drawing.Size(113, 46);
            this.btn_resetar_palavras.TabIndex = 1;
            this.btn_resetar_palavras.Text = "Resetar Palavras";
            this.btn_resetar_palavras.UseVisualStyleBackColor = true;
            this.btn_resetar_palavras.Click += new System.EventHandler(this.btn_resetar_palavras_Click);
            // 
            // btn_resetar_senha
            // 
            this.btn_resetar_senha.Location = new System.Drawing.Point(131, 335);
            this.btn_resetar_senha.Name = "btn_resetar_senha";
            this.btn_resetar_senha.Size = new System.Drawing.Size(113, 46);
            this.btn_resetar_senha.TabIndex = 2;
            this.btn_resetar_senha.Text = "Resetar Senha";
            this.btn_resetar_senha.UseVisualStyleBackColor = true;
            this.btn_resetar_senha.Click += new System.EventHandler(this.btn_resetar_senha_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(250, 335);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(113, 46);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir Conta";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(369, 335);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(113, 46);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar conta de vendedor";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(488, 335);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 46);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // GerirContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 393);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_resetar_senha);
            this.Controls.Add(this.btn_resetar_palavras);
            this.Controls.Add(this.lista_contas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerirContas";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.GerirContas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista_contas;
        private System.Windows.Forms.Button btn_resetar_palavras;
        private System.Windows.Forms.Button btn_resetar_senha;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_fechar;
    }
}