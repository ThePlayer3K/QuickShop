namespace QuickShop
{
    partial class RemoverDespesa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da despesa:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(119, 25);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(12, 86);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(98, 32);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(134, 86);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 32);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // RemoverDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 143);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoverDespesa";
            this.Text = "Remover Despesa";
//            this.Load += new System.EventHandler(this.RemoverDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
    }
}