namespace QuickShop
{
    partial class HistoricoFluxos
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
            this.lista_fluxos = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_fechar = new System.Windows.Forms.Button();
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.picker_inicial = new System.Windows.Forms.DateTimePicker();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.lbl_data_final = new System.Windows.Forms.Label();
            this.lbl_data_inicial = new System.Windows.Forms.Label();
            this.coluna_data_inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_data_fim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_despesas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_entradas_brutas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_entradas_liquidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista_fluxos
            // 
            this.lista_fluxos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_data_inicio,
            this.coluna_data_fim,
            this.coluna_despesas,
            this.coluna_entradas_brutas,
            this.coluna_entradas_liquidas,
            this.coluna_total});
            this.lista_fluxos.GridLines = true;
            this.lista_fluxos.HideSelection = false;
            this.lista_fluxos.Location = new System.Drawing.Point(42, 84);
            this.lista_fluxos.Name = "lista_fluxos";
            this.lista_fluxos.Size = new System.Drawing.Size(689, 254);
            this.lista_fluxos.TabIndex = 22;
            this.lista_fluxos.UseCompatibleStateImageBehavior = false;
            this.lista_fluxos.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 70;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(80, 431);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 52);
            this.btn_fechar.TabIndex = 21;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // picker_final
            // 
            this.picker_final.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_final.Location = new System.Drawing.Point(577, 42);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(96, 20);
            this.picker_final.TabIndex = 20;
            // 
            // picker_inicial
            // 
            this.picker_inicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_inicial.Location = new System.Drawing.Point(146, 43);
            this.picker_inicial.Name = "picker_inicial";
            this.picker_inicial.Size = new System.Drawing.Size(106, 20);
            this.picker_inicial.TabIndex = 19;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(552, 431);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(161, 52);
            this.btn_procurar.TabIndex = 18;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // lbl_data_final
            // 
            this.lbl_data_final.AutoSize = true;
            this.lbl_data_final.Location = new System.Drawing.Point(489, 49);
            this.lbl_data_final.Name = "lbl_data_final";
            this.lbl_data_final.Size = new System.Drawing.Size(58, 13);
            this.lbl_data_final.TabIndex = 17;
            this.lbl_data_final.Text = "Data Final:";
            // 
            // lbl_data_inicial
            // 
            this.lbl_data_inicial.AutoSize = true;
            this.lbl_data_inicial.Location = new System.Drawing.Point(77, 48);
            this.lbl_data_inicial.Name = "lbl_data_inicial";
            this.lbl_data_inicial.Size = new System.Drawing.Size(63, 13);
            this.lbl_data_inicial.TabIndex = 16;
            this.lbl_data_inicial.Text = "Data Inicial:";
            // 
            // coluna_data_inicio
            // 
            this.coluna_data_inicio.Text = "Data de início";
            this.coluna_data_inicio.Width = 100;
            // 
            // coluna_data_fim
            // 
            this.coluna_data_fim.Text = "Data final";
            this.coluna_data_fim.Width = 100;
            // 
            // coluna_despesas
            // 
            this.coluna_despesas.Text = "Saídas";
            this.coluna_despesas.Width = 100;
            // 
            // coluna_entradas_brutas
            // 
            this.coluna_entradas_brutas.Text = "Entradas brutas";
            this.coluna_entradas_brutas.Width = 100;
            // 
            // coluna_entradas_liquidas
            // 
            this.coluna_entradas_liquidas.Text = "Entradas líquidas";
            this.coluna_entradas_liquidas.Width = 100;
            // 
            // coluna_total
            // 
            this.coluna_total.Text = "Total";
            this.coluna_total.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Esta janela mostra todos os fluxos que envolvem as datas do período que você indi" +
    "car.";
            // 
            // HistoricoFluxos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_fluxos);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.picker_final);
            this.Controls.Add(this.picker_inicial);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.lbl_data_final);
            this.Controls.Add(this.lbl_data_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricoFluxos";
            this.Text = "Histórico de fluxos de caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_fluxos;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.DateTimePicker picker_inicial;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Label lbl_data_final;
        private System.Windows.Forms.Label lbl_data_inicial;
        private System.Windows.Forms.ColumnHeader coluna_data_inicio;
        private System.Windows.Forms.ColumnHeader coluna_data_fim;
        private System.Windows.Forms.ColumnHeader coluna_despesas;
        private System.Windows.Forms.ColumnHeader coluna_entradas_brutas;
        private System.Windows.Forms.ColumnHeader coluna_entradas_liquidas;
        private System.Windows.Forms.ColumnHeader coluna_total;
        private System.Windows.Forms.Label label1;
    }
}