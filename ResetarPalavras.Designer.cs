namespace QuickShop
{
    partial class ResetarPalavras
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
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra de recuperação 1:";
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(190, 45);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.PasswordChar = '*';
            this.txt_p1.Size = new System.Drawing.Size(229, 20);
            this.txt_p1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra de recuperação 2:";
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(190, 92);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.PasswordChar = '*';
            this.txt_p2.Size = new System.Drawing.Size(229, 20);
            this.txt_p2.TabIndex = 3;
            // 
            // txt_p3
            // 
            this.txt_p3.Location = new System.Drawing.Point(190, 145);
            this.txt_p3.Name = "txt_p3";
            this.txt_p3.PasswordChar = '*';
            this.txt_p3.Size = new System.Drawing.Size(229, 20);
            this.txt_p3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Palavra de recuperação 3:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(32, 214);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(119, 48);
            this.btn_confirmar.TabIndex = 6;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(318, 214);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(119, 48);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // ResetarPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 283);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_p3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetarPalavras";
            this.Text = "Resetar Palavras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.TextBox txt_p3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_fechar;
    }
}