namespace QuickShop
{
    partial class VisualizarVendas
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
            this.lbl_data_inicial = new System.Windows.Forms.Label();
            this.lbl_data_final = new System.Windows.Forms.Label();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.picker_inicial = new System.Windows.Forms.DateTimePicker();
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.abas = new System.Windows.Forms.TabControl();
            this.aba_valores = new System.Windows.Forms.TabPage();
            this.lista_valores = new System.Windows.Forms.ListView();
            this.coluna_metodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_bruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_liquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aba_produtos = new System.Windows.Forms.TabPage();
            this.lista_produtos = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_bruto = new System.Windows.Forms.Label();
            this.lbl_liquido = new System.Windows.Forms.Label();
            this.abas.SuspendLayout();
            this.aba_valores.SuspendLayout();
            this.aba_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_data_inicial
            // 
            this.lbl_data_inicial.AutoSize = true;
            this.lbl_data_inicial.Location = new System.Drawing.Point(27, 42);
            this.lbl_data_inicial.Name = "lbl_data_inicial";
            this.lbl_data_inicial.Size = new System.Drawing.Size(63, 13);
            this.lbl_data_inicial.TabIndex = 0;
            this.lbl_data_inicial.Text = "Data Inicial:";
            // 
            // lbl_data_final
            // 
            this.lbl_data_final.AutoSize = true;
            this.lbl_data_final.Location = new System.Drawing.Point(439, 43);
            this.lbl_data_final.Name = "lbl_data_final";
            this.lbl_data_final.Size = new System.Drawing.Size(58, 13);
            this.lbl_data_final.TabIndex = 1;
            this.lbl_data_final.Text = "Data Final:";
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(483, 444);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(161, 52);
            this.btn_procurar.TabIndex = 2;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // picker_inicial
            // 
            this.picker_inicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_inicial.Location = new System.Drawing.Point(111, 36);
            this.picker_inicial.Name = "picker_inicial";
            this.picker_inicial.Size = new System.Drawing.Size(106, 20);
            this.picker_inicial.TabIndex = 3;
            // 
            // picker_final
            // 
            this.picker_final.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_final.Location = new System.Drawing.Point(527, 36);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(96, 20);
            this.picker_final.TabIndex = 4;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(30, 444);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 52);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // abas
            // 
            this.abas.Controls.Add(this.aba_valores);
            this.abas.Controls.Add(this.aba_produtos);
            this.abas.Location = new System.Drawing.Point(30, 64);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(603, 258);
            this.abas.TabIndex = 6;
            // 
            // aba_valores
            // 
            this.aba_valores.Controls.Add(this.lista_valores);
            this.aba_valores.Location = new System.Drawing.Point(4, 24);
            this.aba_valores.Name = "aba_valores";
            this.aba_valores.Padding = new System.Windows.Forms.Padding(3);
            this.aba_valores.Size = new System.Drawing.Size(595, 230);
            this.aba_valores.TabIndex = 0;
            this.aba_valores.Text = "Valores";
            this.aba_valores.UseVisualStyleBackColor = true;
            // 
            // lista_valores
            // 
            this.lista_valores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_metodo,
            this.coluna_bruto,
            this.coluna_liquido});
            this.lista_valores.GridLines = true;
            this.lista_valores.HideSelection = false;
            this.lista_valores.Location = new System.Drawing.Point(0, 0);
            this.lista_valores.Name = "lista_valores";
            this.lista_valores.Size = new System.Drawing.Size(595, 236);
            this.lista_valores.TabIndex = 0;
            this.lista_valores.UseCompatibleStateImageBehavior = false;
            this.lista_valores.View = System.Windows.Forms.View.Details;
            // 
            // coluna_metodo
            // 
            this.coluna_metodo.Text = "Mét. pagamento";
            this.coluna_metodo.Width = 250;
            // 
            // coluna_bruto
            // 
            this.coluna_bruto.Text = "Valor Bruto";
            this.coluna_bruto.Width = 150;
            // 
            // coluna_liquido
            // 
            this.coluna_liquido.Text = "Valor Líquido";
            this.coluna_liquido.Width = 180;
            // 
            // aba_produtos
            // 
            this.aba_produtos.Controls.Add(this.lista_produtos);
            this.aba_produtos.Location = new System.Drawing.Point(4, 24);
            this.aba_produtos.Name = "aba_produtos";
            this.aba_produtos.Padding = new System.Windows.Forms.Padding(3);
            this.aba_produtos.Size = new System.Drawing.Size(595, 230);
            this.aba_produtos.TabIndex = 1;
            this.aba_produtos.Text = "Produtos";
            this.aba_produtos.UseVisualStyleBackColor = true;
            // 
            // lista_produtos
            // 
            this.lista_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_nome,
            this.coluna_qtd});
            this.lista_produtos.GridLines = true;
            this.lista_produtos.HideSelection = false;
            this.lista_produtos.Location = new System.Drawing.Point(0, -2);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(595, 236);
            this.lista_produtos.TabIndex = 1;
            this.lista_produtos.UseCompatibleStateImageBehavior = false;
            this.lista_produtos.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 150;
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Nome";
            this.coluna_nome.Width = 300;
            // 
            // coluna_qtd
            // 
            this.coluna_qtd.Text = "Qtd. Vendida";
            this.coluna_qtd.Width = 120;
            // 
            // lbl_bruto
            // 
            this.lbl_bruto.AutoSize = true;
            this.lbl_bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_bruto.Location = new System.Drawing.Point(258, 347);
            this.lbl_bruto.Name = "lbl_bruto";
            this.lbl_bruto.Size = new System.Drawing.Size(114, 20);
            this.lbl_bruto.TabIndex = 7;
            this.lbl_bruto.Text = "Total bruto: R$";
            // 
            // lbl_liquido
            // 
            this.lbl_liquido.AutoSize = true;
            this.lbl_liquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_liquido.Location = new System.Drawing.Point(250, 380);
            this.lbl_liquido.Name = "lbl_liquido";
            this.lbl_liquido.Size = new System.Drawing.Size(122, 20);
            this.lbl_liquido.TabIndex = 8;
            this.lbl_liquido.Text = "Total líquido: R$";
            // 
            // VisualizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 517);
            this.Controls.Add(this.lbl_liquido);
            this.Controls.Add(this.lbl_bruto);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.picker_final);
            this.Controls.Add(this.picker_inicial);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.lbl_data_final);
            this.Controls.Add(this.lbl_data_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarVendas";
            this.Text = "Visualização de Vendas";
            this.abas.ResumeLayout(false);
            this.aba_valores.ResumeLayout(false);
            this.aba_produtos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data_inicial;
        private System.Windows.Forms.Label lbl_data_final;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.DateTimePicker picker_inicial;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage aba_valores;
        private System.Windows.Forms.TabPage aba_produtos;
        private System.Windows.Forms.ListView lista_valores;
        private System.Windows.Forms.ColumnHeader coluna_metodo;
        private System.Windows.Forms.ColumnHeader coluna_bruto;
        private System.Windows.Forms.ColumnHeader coluna_liquido;
        private System.Windows.Forms.ListView lista_produtos;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_qtd;
        private System.Windows.Forms.Label lbl_bruto;
        private System.Windows.Forms.Label lbl_liquido;
    }
}