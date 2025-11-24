namespace QuickShop
{
    partial class AlterarConta
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_rec1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rec2 = new System.Windows.Forms.TextBox();
            this.txt_rec3 = new System.Windows.Forms.TextBox();
            this.txt_senha_atual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nova_senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Os campos que não possuírem nada inserido não serão alterados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "A senha atual deve ser inserida para realizar alterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(127, 101);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(357, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_rec1
            // 
            this.txt_rec1.Location = new System.Drawing.Point(127, 140);
            this.txt_rec1.Name = "txt_rec1";
            this.txt_rec1.PasswordChar = '*';
            this.txt_rec1.Size = new System.Drawing.Size(357, 20);
            this.txt_rec1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Palavra de rec. 1:";
            // 
            // txt_rec2
            // 
            this.txt_rec2.Location = new System.Drawing.Point(127, 179);
            this.txt_rec2.Name = "txt_rec2";
            this.txt_rec2.PasswordChar = '*';
            this.txt_rec2.Size = new System.Drawing.Size(357, 20);
            this.txt_rec2.TabIndex = 7;
            // 
            // txt_rec3
            // 
            this.txt_rec3.Location = new System.Drawing.Point(127, 221);
            this.txt_rec3.Name = "txt_rec3";
            this.txt_rec3.PasswordChar = '*';
            this.txt_rec3.Size = new System.Drawing.Size(357, 20);
            this.txt_rec3.TabIndex = 9;
            // 
            // txt_senha_atual
            // 
            this.txt_senha_atual.Location = new System.Drawing.Point(127, 268);
            this.txt_senha_atual.Name = "txt_senha_atual";
            this.txt_senha_atual.PasswordChar = '*';
            this.txt_senha_atual.Size = new System.Drawing.Size(357, 20);
            this.txt_senha_atual.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Senha atual:";
            // 
            // txt_nova_senha
            // 
            this.txt_nova_senha.Location = new System.Drawing.Point(127, 312);
            this.txt_nova_senha.Name = "txt_nova_senha";
            this.txt_nova_senha.PasswordChar = '*';
            this.txt_nova_senha.Size = new System.Drawing.Size(357, 20);
            this.txt_nova_senha.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nova senha:";
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(127, 354);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(357, 20);
            this.txt_confirmar.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Confirmar nova senha:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(26, 410);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(157, 60);
            this.btn_fechar.TabIndex = 16;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(354, 410);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(157, 60);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Palavra de rec. 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Palavra de rec. 3:";
            // 
            // AlterarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 482);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nova_senha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_senha_atual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rec3);
            this.Controls.Add(this.txt_rec2);
            this.Controls.Add(this.txt_rec1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlterarConta";
            this.Text = "Alterar dados da conta";
            this.Load += new System.EventHandler(this.AlterarConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_rec1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rec2;
        private System.Windows.Forms.TextBox txt_rec3;
        private System.Windows.Forms.TextBox txt_senha_atual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nova_senha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}