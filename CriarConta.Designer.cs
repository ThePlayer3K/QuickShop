namespace QuickShop
{
    partial class CriarConta
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rec3 = new System.Windows.Forms.TextBox();
            this.txt_rec2 = new System.Windows.Forms.TextBox();
            this.txt_rec1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Palavra de rec. 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Palavra de rec. 2:";
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(137, 244);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(357, 20);
            this.txt_confirmar.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Confirmar senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(137, 200);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(357, 20);
            this.txt_senha.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Senha:";
            // 
            // txt_rec3
            // 
            this.txt_rec3.Location = new System.Drawing.Point(137, 153);
            this.txt_rec3.Name = "txt_rec3";
            this.txt_rec3.PasswordChar = '*';
            this.txt_rec3.Size = new System.Drawing.Size(357, 20);
            this.txt_rec3.TabIndex = 25;
            // 
            // txt_rec2
            // 
            this.txt_rec2.Location = new System.Drawing.Point(137, 111);
            this.txt_rec2.Name = "txt_rec2";
            this.txt_rec2.PasswordChar = '*';
            this.txt_rec2.Size = new System.Drawing.Size(357, 20);
            this.txt_rec2.TabIndex = 24;
            // 
            // txt_rec1
            // 
            this.txt_rec1.Location = new System.Drawing.Point(137, 72);
            this.txt_rec1.Name = "txt_rec1";
            this.txt_rec1.PasswordChar = '*';
            this.txt_rec1.Size = new System.Drawing.Size(357, 20);
            this.txt_rec1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Palavra de rec. 1:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(137, 33);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(357, 20);
            this.txt_nome.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome:";
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(46, 305);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(121, 44);
            this.btn_criar.TabIndex = 32;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(337, 305);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(121, 44);
            this.btn_fechar.TabIndex = 33;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 375);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rec3);
            this.Controls.Add(this.txt_rec2);
            this.Controls.Add(this.txt_rec1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CriarConta";
            this.Text = "Criar conta de vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rec3;
        private System.Windows.Forms.TextBox txt_rec2;
        private System.Windows.Forms.TextBox txt_rec1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_fechar;
    }
}