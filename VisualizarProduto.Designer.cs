namespace QuickShop
{
    partial class VisualizarProduto
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.listaProdutos = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd_estoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(321, 259);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 62);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // listaProdutos
            // 
            this.listaProdutos.AutoArrange = false;
            this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nome,
            this.preco,
            this.qtd_estoque});
            this.listaProdutos.GridLines = true;
            this.listaProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProdutos.HideSelection = false;
            this.listaProdutos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listaProdutos.Location = new System.Drawing.Point(-1, 0);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Scrollable = false;
            this.listaProdutos.Size = new System.Drawing.Size(455, 237);
            this.listaProdutos.TabIndex = 1;
            this.listaProdutos.UseCompatibleStateImageBehavior = false;
            this.listaProdutos.View = System.Windows.Forms.View.Details;
            this.listaProdutos.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listaProdutos_ColumnWidthChanged);
            this.listaProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listaProdutos_ColumnWidthChanging);
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 200;
            // 
            // preco
            // 
            this.preco.Text = "Preço";
            this.preco.Width = 100;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.Text = "Qtd. em Estoque";
            this.qtd_estoque.Width = 100;
            // 
            // VisualizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 342);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.btnFechar);
            this.Name = "VisualizarProduto";
            this.Text = "Visualizar Produto";
            this.Load += new System.EventHandler(this.VisualizarProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListView listaProdutos;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader preco;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader qtd_estoque;
    }
}