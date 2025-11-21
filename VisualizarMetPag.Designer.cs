namespace QuickShop
{
    partial class VisualizarMetPag
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
            this.lista_metodos = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_taxa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_metodos
            // 
            this.lista_metodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_nome,
            this.coluna_taxa});
            this.lista_metodos.HideSelection = false;
            this.lista_metodos.Location = new System.Drawing.Point(12, 12);
            this.lista_metodos.Name = "lista_metodos";
            this.lista_metodos.Size = new System.Drawing.Size(515, 320);
            this.lista_metodos.TabIndex = 0;
            this.lista_metodos.UseCompatibleStateImageBehavior = false;
            this.lista_metodos.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Nome";
            // 
            // coluna_taxa
            // 
            this.coluna_taxa.Text = "Taxa";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(373, 358);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(144, 47);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // VisualizarMetPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 426);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lista_metodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarMetPag";
            this.Text = "Visualização de métodos de pagamento";
            this.Load += new System.EventHandler(this.VisualizarMetPag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista_metodos;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_taxa;
        private System.Windows.Forms.Button btn_fechar;
    }
}