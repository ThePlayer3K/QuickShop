namespace QuickShop
{
    partial class CadastroVendas
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
            this.components = new System.ComponentModel.Container();
            this.abasCadastroVendas = new System.Windows.Forms.TabControl();
            this.buscarProdutos = new System.Windows.Forms.TabPage();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vl_un = new System.Windows.Forms.Label();
            this.item_Selecionado = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco_un = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd_estoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultadoFinal = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.produtosAtivos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abasCadastroVendas.SuspendLayout();
            this.buscarProdutos.SuspendLayout();
            this.resultadoFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // abasCadastroVendas
            // 
            this.abasCadastroVendas.Controls.Add(this.buscarProdutos);
            this.abasCadastroVendas.Controls.Add(this.resultadoFinal);
            this.abasCadastroVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.abasCadastroVendas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.abasCadastroVendas.ItemSize = new System.Drawing.Size(334, 30);
            this.abasCadastroVendas.Location = new System.Drawing.Point(0, 0);
            this.abasCadastroVendas.Name = "abasCadastroVendas";
            this.abasCadastroVendas.SelectedIndex = 0;
            this.abasCadastroVendas.Size = new System.Drawing.Size(671, 496);
            this.abasCadastroVendas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.abasCadastroVendas.TabIndex = 0;
            // 
            // buscarProdutos
            // 
            this.buscarProdutos.Controls.Add(this.btn_Adicionar);
            this.buscarProdutos.Controls.Add(this.btn_Cancelar);
            this.buscarProdutos.Controls.Add(this.qtd);
            this.buscarProdutos.Controls.Add(this.label1);
            this.buscarProdutos.Controls.Add(this.vl_un);
            this.buscarProdutos.Controls.Add(this.item_Selecionado);
            this.buscarProdutos.Controls.Add(this.listProdutos);
            this.buscarProdutos.Location = new System.Drawing.Point(4, 34);
            this.buscarProdutos.Name = "buscarProdutos";
            this.buscarProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.buscarProdutos.Size = new System.Drawing.Size(663, 458);
            this.buscarProdutos.TabIndex = 0;
            this.buscarProdutos.Text = "Produtos";
            this.buscarProdutos.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Adicionar.Location = new System.Drawing.Point(441, 379);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(156, 60);
            this.btn_Adicionar.TabIndex = 6;
            this.btn_Adicionar.Text = "Adicionar Produto";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Cancelar.Location = new System.Drawing.Point(85, 379);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(156, 60);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar Venda";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.qtd.Location = new System.Drawing.Point(507, 298);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(117, 34);
            this.qtd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(366, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade:";
            // 
            // vl_un
            // 
            this.vl_un.AutoSize = true;
            this.vl_un.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.vl_un.Location = new System.Drawing.Point(122, 311);
            this.vl_un.Name = "vl_un";
            this.vl_un.Size = new System.Drawing.Size(119, 28);
            this.vl_un.TabIndex = 2;
            this.vl_un.Text = "R$ /unidade";
            // 
            // item_Selecionado
            // 
            this.item_Selecionado.AutoSize = true;
            this.item_Selecionado.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.item_Selecionado.Location = new System.Drawing.Point(32, 257);
            this.item_Selecionado.Name = "item_Selecionado";
            this.item_Selecionado.Size = new System.Drawing.Size(328, 54);
            this.item_Selecionado.TabIndex = 1;
            this.item_Selecionado.Text = "Item Selecionado";
            // 
            // listProdutos
            // 
            this.listProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cod,
            this.nome,
            this.preco_un,
            this.qtd_estoque});
            this.listProdutos.FullRowSelect = true;
            this.listProdutos.GridLines = true;
            this.listProdutos.HideSelection = false;
            this.listProdutos.Location = new System.Drawing.Point(0, 0);
            this.listProdutos.MultiSelect = false;
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listProdutos.Size = new System.Drawing.Size(663, 210);
            this.listProdutos.TabIndex = 0;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.View = System.Windows.Forms.View.Details;
            this.listProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listProdutos_ColumnWidthChanging);
            // 
            // cod
            // 
            this.cod.Text = "Código";
            this.cod.Width = 107;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nome.Width = 302;
            // 
            // preco_un
            // 
            this.preco_un.Text = "Preço Unitário";
            this.preco_un.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.preco_un.Width = 98;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.Text = "Quantidade em Estoque";
            this.qtd_estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtd_estoque.Width = 146;
            // 
            // resultadoFinal
            // 
            this.resultadoFinal.Controls.Add(this.produtosAtivos);
            this.resultadoFinal.Location = new System.Drawing.Point(4, 34);
            this.resultadoFinal.Name = "resultadoFinal";
            this.resultadoFinal.Padding = new System.Windows.Forms.Padding(3);
            this.resultadoFinal.Size = new System.Drawing.Size(663, 458);
            this.resultadoFinal.TabIndex = 1;
            this.resultadoFinal.Text = "Resultado Final";
            this.resultadoFinal.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
//            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // produtosAtivos
            // 
            this.produtosAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.produtosAtivos.FullRowSelect = true;
            this.produtosAtivos.GridLines = true;
            this.produtosAtivos.HideSelection = false;
            this.produtosAtivos.Location = new System.Drawing.Point(3, 3);
            this.produtosAtivos.MultiSelect = false;
            this.produtosAtivos.Name = "produtosAtivos";
            this.produtosAtivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.produtosAtivos.Size = new System.Drawing.Size(663, 210);
            this.produtosAtivos.TabIndex = 1;
            this.produtosAtivos.UseCompatibleStateImageBehavior = false;
            this.produtosAtivos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 302;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço Unitário";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantidade";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 146;
            // 
            // CadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 508);
            this.Controls.Add(this.abasCadastroVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroVendas";
            this.Text = "Cadastro Vendas";
            this.Load += new System.EventHandler(this.CadastroVendas_Load);
            this.abasCadastroVendas.ResumeLayout(false);
            this.buscarProdutos.ResumeLayout(false);
            this.buscarProdutos.PerformLayout();
            this.resultadoFinal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasCadastroVendas;
        private System.Windows.Forms.TabPage buscarProdutos;
        private System.Windows.Forms.TabPage resultadoFinal;
        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.ColumnHeader cod;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader preco_un;
        private System.Windows.Forms.ColumnHeader qtd_estoque;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vl_un;
        private System.Windows.Forms.Label item_Selecionado;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView produtosAtivos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}