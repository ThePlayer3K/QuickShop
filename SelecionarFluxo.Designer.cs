namespace QuickShop
{
    partial class SelecionarFluxo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picker_inicial = new System.Windows.Forms.DateTimePicker();
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, selecione as datas inicial e final do período de sua consulta.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data final:";
            // 
            // picker_inicial
            // 
            this.picker_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_inicial.Location = new System.Drawing.Point(174, 64);
            this.picker_inicial.Name = "picker_inicial";
            this.picker_inicial.Size = new System.Drawing.Size(112, 20);
            this.picker_inicial.TabIndex = 3;
            // 
            // picker_final
            // 
            this.picker_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_final.Location = new System.Drawing.Point(174, 119);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(112, 20);
            this.picker_final.TabIndex = 4;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(279, 177);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(101, 34);
            this.btn_visualizar.TabIndex = 5;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(32, 177);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 34);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // SelecionarFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 230);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.picker_final);
            this.Controls.Add(this.picker_inicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelecionarFluxo";
            this.Text = "Fluxo de Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker picker_inicial;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}