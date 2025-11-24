namespace QuickShop
{
    partial class FluxoCaixa
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
            this.lbl_inicial = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aba_despesas = new System.Windows.Forms.TabPage();
            this.aba_produtos = new System.Windows.Forms.TabPage();
            this.aba_entradas = new System.Windows.Forms.TabPage();
            this.lbl_despesas = new System.Windows.Forms.Label();
            this.lbl_brutas = new System.Windows.Forms.Label();
            this.lbl_liquidas = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lista_despesas = new System.Windows.Forms.ListView();
            this.lista_produtos = new System.Windows.Forms.ListView();
            this.lista_entradas = new System.Windows.Forms.ListView();
            this.coluna_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_metodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_bruta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_liquida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.aba_despesas.SuspendLayout();
            this.aba_produtos.SuspendLayout();
            this.aba_entradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_inicial
            // 
            this.lbl_inicial.AutoSize = true;
            this.lbl_inicial.Location = new System.Drawing.Point(57, 23);
            this.lbl_inicial.Name = "lbl_inicial";
            this.lbl_inicial.Size = new System.Drawing.Size(62, 13);
            this.lbl_inicial.TabIndex = 0;
            this.lbl_inicial.Text = "Data inicial:";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Location = new System.Drawing.Point(371, 23);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(55, 13);
            this.lbl_final.TabIndex = 1;
            this.lbl_final.Text = "Data final:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aba_despesas);
            this.tabControl1.Controls.Add(this.aba_produtos);
            this.tabControl1.Controls.Add(this.aba_entradas);
            this.tabControl1.Location = new System.Drawing.Point(2, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 272);
            this.tabControl1.TabIndex = 2;
            // 
            // aba_despesas
            // 
            this.aba_despesas.Controls.Add(this.lista_despesas);
            this.aba_despesas.Location = new System.Drawing.Point(4, 24);
            this.aba_despesas.Name = "aba_despesas";
            this.aba_despesas.Size = new System.Drawing.Size(554, 244);
            this.aba_despesas.TabIndex = 0;
            this.aba_despesas.Text = "Despesas";
            this.aba_despesas.UseVisualStyleBackColor = true;
            // 
            // aba_produtos
            // 
            this.aba_produtos.Controls.Add(this.lista_produtos);
            this.aba_produtos.Location = new System.Drawing.Point(4, 24);
            this.aba_produtos.Name = "aba_produtos";
            this.aba_produtos.Size = new System.Drawing.Size(554, 244);
            this.aba_produtos.TabIndex = 1;
            this.aba_produtos.Text = "Produtos";
            this.aba_produtos.UseVisualStyleBackColor = true;
            // 
            // aba_entradas
            // 
            this.aba_entradas.Controls.Add(this.lista_entradas);
            this.aba_entradas.Location = new System.Drawing.Point(4, 24);
            this.aba_entradas.Name = "aba_entradas";
            this.aba_entradas.Size = new System.Drawing.Size(554, 244);
            this.aba_entradas.TabIndex = 2;
            this.aba_entradas.Text = "Entradas";
            this.aba_entradas.UseVisualStyleBackColor = true;
            // 
            // lbl_despesas
            // 
            this.lbl_despesas.AutoSize = true;
            this.lbl_despesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_despesas.Location = new System.Drawing.Point(24, 365);
            this.lbl_despesas.Name = "lbl_despesas";
            this.lbl_despesas.Size = new System.Drawing.Size(110, 20);
            this.lbl_despesas.TabIndex = 3;
            this.lbl_despesas.Text = "Despesas: R$";
            // 
            // lbl_brutas
            // 
            this.lbl_brutas.AutoSize = true;
            this.lbl_brutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_brutas.Location = new System.Drawing.Point(24, 398);
            this.lbl_brutas.Name = "lbl_brutas";
            this.lbl_brutas.Size = new System.Drawing.Size(152, 20);
            this.lbl_brutas.TabIndex = 4;
            this.lbl_brutas.Text = "Entradas brutas: R$";
            // 
            // lbl_liquidas
            // 
            this.lbl_liquidas.AutoSize = true;
            this.lbl_liquidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_liquidas.Location = new System.Drawing.Point(24, 432);
            this.lbl_liquidas.Name = "lbl_liquidas";
            this.lbl_liquidas.Size = new System.Drawing.Size(160, 20);
            this.lbl_liquidas.TabIndex = 5;
            this.lbl_liquidas.Text = "Entradas líquidas: R$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_total.Location = new System.Drawing.Point(196, 499);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(151, 24);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total Líquido: R$";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(412, 554);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(128, 39);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lista_despesas
            // 
            this.lista_despesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_id,
            this.coluna_nome,
            this.coluna_valor,
            this.coluna_data});
            this.lista_despesas.GridLines = true;
            this.lista_despesas.HideSelection = false;
            this.lista_despesas.Location = new System.Drawing.Point(0, 0);
            this.lista_despesas.Name = "lista_despesas";
            this.lista_despesas.Size = new System.Drawing.Size(558, 248);
            this.lista_despesas.TabIndex = 0;
            this.lista_despesas.UseCompatibleStateImageBehavior = false;
            this.lista_despesas.View = System.Windows.Forms.View.Details;
            // 
            // lista_produtos
            // 
            this.lista_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_produto,
            this.coluna_quantidade});
            this.lista_produtos.GridLines = true;
            this.lista_produtos.HideSelection = false;
            this.lista_produtos.Location = new System.Drawing.Point(-2, -2);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(558, 248);
            this.lista_produtos.TabIndex = 1;
            this.lista_produtos.UseCompatibleStateImageBehavior = false;
            this.lista_produtos.View = System.Windows.Forms.View.Details;
            // 
            // lista_entradas
            // 
            this.lista_entradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_metodo,
            this.coluna_bruta,
            this.coluna_liquida});
            this.lista_entradas.GridLines = true;
            this.lista_entradas.HideSelection = false;
            this.lista_entradas.Location = new System.Drawing.Point(-2, -2);
            this.lista_entradas.Name = "lista_entradas";
            this.lista_entradas.Size = new System.Drawing.Size(558, 248);
            this.lista_entradas.TabIndex = 1;
            this.lista_entradas.UseCompatibleStateImageBehavior = false;
            this.lista_entradas.View = System.Windows.Forms.View.Details;
            // 
            // coluna_id
            // 
            this.coluna_id.Text = "Código";
            this.coluna_id.Width = 100;
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Despesa";
            this.coluna_nome.Width = 250;
            // 
            // coluna_valor
            // 
            this.coluna_valor.Text = "Valor";
            this.coluna_valor.Width = 100;
            // 
            // coluna_data
            // 
            this.coluna_data.Text = "Data";
            this.coluna_data.Width = 90;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 100;
            // 
            // coluna_produto
            // 
            this.coluna_produto.Text = "Produto";
            this.coluna_produto.Width = 300;
            // 
            // coluna_quantidade
            // 
            this.coluna_quantidade.Text = "Qtd. Vendida";
            this.coluna_quantidade.Width = 140;
            // 
            // coluna_metodo
            // 
            this.coluna_metodo.Text = "Mét. pagamento";
            this.coluna_metodo.Width = 250;
            // 
            // coluna_bruta
            // 
            this.coluna_bruta.Text = "Entr. Bruta";
            this.coluna_bruta.Width = 150;
            // 
            // coluna_liquida
            // 
            this.coluna_liquida.Text = "Entr. Líquida";
            this.coluna_liquida.Width = 150;
            // 
            // FluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 605);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_liquidas);
            this.Controls.Add(this.lbl_brutas);
            this.Controls.Add(this.lbl_despesas);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_final);
            this.Controls.Add(this.lbl_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FluxoCaixa";
            this.Text = "Fluxo de Caixa";
            this.Load += new System.EventHandler(this.FluxoCaixa_Load);
            this.tabControl1.ResumeLayout(false);
            this.aba_despesas.ResumeLayout(false);
            this.aba_produtos.ResumeLayout(false);
            this.aba_entradas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inicial;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aba_despesas;
        private System.Windows.Forms.TabPage aba_produtos;
        private System.Windows.Forms.TabPage aba_entradas;
        private System.Windows.Forms.Label lbl_despesas;
        private System.Windows.Forms.Label lbl_brutas;
        private System.Windows.Forms.Label lbl_liquidas;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ListView lista_despesas;
        private System.Windows.Forms.ColumnHeader coluna_id;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_valor;
        private System.Windows.Forms.ColumnHeader coluna_data;
        private System.Windows.Forms.ListView lista_produtos;
        private System.Windows.Forms.ListView lista_entradas;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_produto;
        private System.Windows.Forms.ColumnHeader coluna_quantidade;
        private System.Windows.Forms.ColumnHeader coluna_metodo;
        private System.Windows.Forms.ColumnHeader coluna_bruta;
        private System.Windows.Forms.ColumnHeader coluna_liquida;
    }
}