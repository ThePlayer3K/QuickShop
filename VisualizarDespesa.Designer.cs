namespace QuickShop
{
    partial class VisualizarDespesas
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.picker_inicial = new System.Windows.Forms.DateTimePicker();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.lbl_data_final = new System.Windows.Forms.Label();
            this.lbl_data_inicial = new System.Windows.Forms.Label();
            this.lista_despesas = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_total.Location = new System.Drawing.Point(297, 371);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(73, 20);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total: R$";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(95, 427);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 52);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // picker_final
            // 
            this.picker_final.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_final.Location = new System.Drawing.Point(592, 19);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(96, 20);
            this.picker_final.TabIndex = 12;
            // 
            // picker_inicial
            // 
            this.picker_inicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picker_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_inicial.Location = new System.Drawing.Point(176, 19);
            this.picker_inicial.Name = "picker_inicial";
            this.picker_inicial.Size = new System.Drawing.Size(106, 20);
            this.picker_inicial.TabIndex = 11;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(567, 427);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(161, 52);
            this.btn_procurar.TabIndex = 10;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // lbl_data_final
            // 
            this.lbl_data_final.AutoSize = true;
            this.lbl_data_final.Location = new System.Drawing.Point(504, 26);
            this.lbl_data_final.Name = "lbl_data_final";
            this.lbl_data_final.Size = new System.Drawing.Size(58, 13);
            this.lbl_data_final.TabIndex = 9;
            this.lbl_data_final.Text = "Data Final:";
            // 
            // lbl_data_inicial
            // 
            this.lbl_data_inicial.AutoSize = true;
            this.lbl_data_inicial.Location = new System.Drawing.Point(92, 25);
            this.lbl_data_inicial.Name = "lbl_data_inicial";
            this.lbl_data_inicial.Size = new System.Drawing.Size(63, 13);
            this.lbl_data_inicial.TabIndex = 8;
            this.lbl_data_inicial.Text = "Data Inicial:";
            // 
            // lista_despesas
            // 
            this.lista_despesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_nome,
            this.coluna_valor,
            this.coluna_data});
            this.lista_despesas.GridLines = true;
            this.lista_despesas.HideSelection = false;
            this.lista_despesas.Location = new System.Drawing.Point(57, 80);
            this.lista_despesas.Name = "lista_despesas";
            this.lista_despesas.Size = new System.Drawing.Size(689, 254);
            this.lista_despesas.TabIndex = 15;
            this.lista_despesas.UseCompatibleStateImageBehavior = false;
            this.lista_despesas.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 70;
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Despesa";
            this.coluna_nome.Width = 400;
            // 
            // coluna_valor
            // 
            this.coluna_valor.Text = "Valor";
            this.coluna_valor.Width = 100;
            // 
            // coluna_data
            // 
            this.coluna_data.Text = "Data";
            this.coluna_data.Width = 110;
            // 
            // VisualizarDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 506);
            this.Controls.Add(this.lista_despesas);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.picker_final);
            this.Controls.Add(this.picker_inicial);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.lbl_data_final);
            this.Controls.Add(this.lbl_data_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarDespesas";
            this.Text = "Visualizar despesas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.DateTimePicker picker_inicial;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Label lbl_data_final;
        private System.Windows.Forms.Label lbl_data_inicial;
        private System.Windows.Forms.ListView lista_despesas;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_valor;
        private System.Windows.Forms.ColumnHeader coluna_data;
    }
}