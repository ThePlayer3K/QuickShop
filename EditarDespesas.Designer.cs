namespace QuickShop
{
    partial class EditarDespesa
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.picker_data = new System.Windows.Forms.DateTimePicker();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.check_inalterar_data = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(382, 313);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(166, 71);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(45, 313);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(166, 71);
            this.btn_editar.TabIndex = 18;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data:";
            // 
            // picker_data
            // 
            this.picker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_data.Location = new System.Drawing.Point(128, 232);
            this.picker_data.Name = "picker_data";
            this.picker_data.Size = new System.Drawing.Size(112, 20);
            this.picker_data.TabIndex = 16;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(128, 175);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(128, 113);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(323, 20);
            this.txt_nome.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(128, 60);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código da despesa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "CAIXAS VAZIAS REPRESENTAM ITENS QUE NÃO SERÃO ALTERADOS.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(127, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "É NECESSÁRIO PREENCHER O CÓDIGO ";
            // 
            // check_inalterar_data
            // 
            this.check_inalterar_data.AutoSize = true;
            this.check_inalterar_data.Location = new System.Drawing.Point(271, 232);
            this.check_inalterar_data.Name = "check_inalterar_data";
            this.check_inalterar_data.Size = new System.Drawing.Size(102, 17);
            this.check_inalterar_data.TabIndex = 22;
            this.check_inalterar_data.Text = "Não alterar data";
            this.check_inalterar_data.UseVisualStyleBackColor = true;
            this.check_inalterar_data.CheckedChanged += new System.EventHandler(this.check_inalterar_data_CheckedChanged);
            // 
            // EditarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 405);
            this.Controls.Add(this.check_inalterar_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picker_data);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarDespesa";
            this.Text = "Editar Despesa";
            this.Load += new System.EventHandler(this.EditarDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker picker_data;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox check_inalterar_data;
    }
}