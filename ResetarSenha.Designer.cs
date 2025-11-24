namespace QuickShop
{
    partial class ResetarSenha
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
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nova = new System.Windows.Forms.TextBox();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova senha:";
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(30, 182);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(117, 41);
            this.btn_resetar.TabIndex = 1;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(194, 182);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(117, 41);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmar senha:";
            // 
            // txt_nova
            // 
            this.txt_nova.Location = new System.Drawing.Point(101, 47);
            this.txt_nova.Name = "txt_nova";
            this.txt_nova.PasswordChar = '*';
            this.txt_nova.Size = new System.Drawing.Size(223, 20);
            this.txt_nova.TabIndex = 4;
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(101, 111);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(223, 20);
            this.txt_confirmar.TabIndex = 5;
            // 
            // ResetarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 244);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.txt_nova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetarSenha";
            this.Text = "Resetar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nova;
        private System.Windows.Forms.TextBox txt_confirmar;
    }
}