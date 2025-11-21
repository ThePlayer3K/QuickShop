namespace QuickShop
{
    partial class SelecionarMetodoVenda
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
            this.lbl_total_vista = new System.Windows.Forms.Label();
            this.lista_metodos = new System.Windows.Forms.ListView();
            this.coluna_metodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_liquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_total_vista
            // 
            this.lbl_total_vista.AutoSize = true;
            this.lbl_total_vista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_total_vista.Location = new System.Drawing.Point(158, 24);
            this.lbl_total_vista.Name = "lbl_total_vista";
            this.lbl_total_vista.Size = new System.Drawing.Size(263, 31);
            this.lbl_total_vista.TabIndex = 0;
            this.lbl_total_vista.Text = "TOTAL À VISTA: R$";
            // 
            // lista_metodos
            // 
            this.lista_metodos.CheckBoxes = true;
            this.lista_metodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_metodo,
            this.coluna_liquido});
            this.lista_metodos.HideSelection = false;
            this.lista_metodos.Location = new System.Drawing.Point(12, 81);
            this.lista_metodos.MultiSelect = false;
            this.lista_metodos.Name = "lista_metodos";
            this.lista_metodos.Size = new System.Drawing.Size(591, 143);
            this.lista_metodos.TabIndex = 1;
            this.lista_metodos.UseCompatibleStateImageBehavior = false;
            this.lista_metodos.View = System.Windows.Forms.View.Details;
            // 
            // coluna_metodo
            // 
            this.coluna_metodo.Text = "Método";
            this.coluna_metodo.Width = 311;
            // 
            // coluna_liquido
            // 
            this.coluna_liquido.Text = "Entrada líquida";
            this.coluna_liquido.Width = 117;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 277);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(148, 52);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(438, 277);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(148, 52);
            this.btn_confirmar.TabIndex = 3;
            this.btn_confirmar.Text = "Confirmar Venda";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // SelecionarMetodoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lista_metodos);
            this.Controls.Add(this.lbl_total_vista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelecionarMetodoVenda";
            this.Text = "Selecione seu método de pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total_vista;
        private System.Windows.Forms.ListView lista_metodos;
        private System.Windows.Forms.ColumnHeader coluna_metodo;
        private System.Windows.Forms.ColumnHeader coluna_liquido;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}