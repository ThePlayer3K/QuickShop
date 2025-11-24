namespace QuickShop
{
    partial class Comissoes
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
            this.lista_comissoes = new System.Windows.Forms.ListView();
            this.coluna_vendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_vendas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_comissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.picker_inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_data_final = new System.Windows.Forms.Label();
            this.lbl_data_inicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_comissao = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_comissoes
            // 
            this.lista_comissoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_vendedor,
            this.coluna_vendas,
            this.coluna_comissao});
            this.lista_comissoes.GridLines = true;
            this.lista_comissoes.Location = new System.Drawing.Point(38, 158);
            this.lista_comissoes.MultiSelect = false;
            this.lista_comissoes.Name = "lista_comissoes";
            this.lista_comissoes.Size = new System.Drawing.Size(656, 229);
            this.lista_comissoes.TabIndex = 20;
            this.lista_comissoes.UseCompatibleStateImageBehavior = false;
            this.lista_comissoes.View = System.Windows.Forms.View.Details;
            this.lista_comissoes.SelectedIndexChanged += new System.EventHandler(this.lista_comissoes_SelectedIndexChanged);
            // 
            // coluna_vendedor
            // 
            this.coluna_vendedor.Text = "Vendedor";
            this.coluna_vendedor.Width = 300;
            // 
            // coluna_vendas
            // 
            this.coluna_vendas.Text = "Vendas líquidas totais";
            this.coluna_vendas.Width = 175;
            // 
            // coluna_comissao
            // 
            this.coluna_comissao.Text = "Valor da comissão";
            this.coluna_comissao.Width = 175;
            // 
            // picker_final
            // 
            this.picker_final.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_final.Location = new System.Drawing.Point(556, 57);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(96, 20);
            this.picker_final.TabIndex = 19;
            // 
            // picker_inicial
            // 
            this.picker_inicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_inicial.Location = new System.Drawing.Point(141, 50);
            this.picker_inicial.Name = "picker_inicial";
            this.picker_inicial.Size = new System.Drawing.Size(106, 20);
            this.picker_inicial.TabIndex = 18;
            // 
            // lbl_data_final
            // 
            this.lbl_data_final.AutoSize = true;
            this.lbl_data_final.Location = new System.Drawing.Point(478, 57);
            this.lbl_data_final.Name = "lbl_data_final";
            this.lbl_data_final.Size = new System.Drawing.Size(58, 13);
            this.lbl_data_final.TabIndex = 17;
            this.lbl_data_final.Text = "Data Final:";
            // 
            // lbl_data_inicial
            // 
            this.lbl_data_inicial.AutoSize = true;
            this.lbl_data_inicial.Location = new System.Drawing.Point(49, 57);
            this.lbl_data_inicial.Name = "lbl_data_inicial";
            this.lbl_data_inicial.Size = new System.Drawing.Size(63, 13);
            this.lbl_data_inicial.TabIndex = 16;
            this.lbl_data_inicial.Text = "Data Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Taxa da comissão (%):";
            // 
            // txt_comissao
            // 
            this.txt_comissao.Location = new System.Drawing.Point(384, 106);
            this.txt_comissao.Name = "txt_comissao";
            this.txt_comissao.Size = new System.Drawing.Size(100, 20);
            this.txt_comissao.TabIndex = 22;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(52, 433);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 52);
            this.btn_fechar.TabIndex = 24;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(295, 433);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(161, 52);
            this.btn_calcular.TabIndex = 23;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Enabled = false;
            this.btn_registrar.Location = new System.Drawing.Point(505, 433);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(161, 52);
            this.btn_registrar.TabIndex = 25;
            this.btn_registrar.Text = "Registrar como despesa";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // Comissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 529);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_comissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_comissoes);
            this.Controls.Add(this.picker_final);
            this.Controls.Add(this.picker_inicial);
            this.Controls.Add(this.lbl_data_final);
            this.Controls.Add(this.lbl_data_inicial);
            this.Name = "Comissoes";
            this.Text = "Comissoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_comissoes;
        private System.Windows.Forms.ColumnHeader coluna_vendedor;
        private System.Windows.Forms.ColumnHeader coluna_vendas;
        private System.Windows.Forms.ColumnHeader coluna_comissao;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.DateTimePicker picker_inicial;
        private System.Windows.Forms.Label lbl_data_final;
        private System.Windows.Forms.Label lbl_data_inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_comissao;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_registrar;
    }
}