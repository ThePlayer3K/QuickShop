namespace QuickShop
{
    partial class CadastrarDespesa
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picker_data = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da despesa:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(119, 26);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(119, 83);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(323, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(119, 145);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // picker_data
            // 
            this.picker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_data.Location = new System.Drawing.Point(119, 202);
            this.picker_data.Name = "picker_data";
            this.picker_data.Size = new System.Drawing.Size(112, 20);
            this.picker_data.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(36, 283);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(166, 71);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(373, 283);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(166, 71);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CadastrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picker_data);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastrarDespesa";
            this.Text = "Cadastrar Despesa";
            this.Load += new System.EventHandler(this.CadastrarDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker picker_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}