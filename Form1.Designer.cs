namespace QuickShop
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_esqueci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logo.Image = global::QuickShop.Properties.Resources.images_removebg_preview;
            this.logo.Location = new System.Drawing.Point(12, 60);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(220, 217);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Noto Naskh Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(64, 226);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(122, 39);
            this.name.TabIndex = 1;
            this.name.Text = "QuickShop";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Noto Naskh Arabic", 30F, System.Drawing.FontStyle.Bold);
            this.close.Location = new System.Drawing.Point(657, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 81);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_usuario.Location = new System.Drawing.Point(316, 117);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(116, 31);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_senha.Location = new System.Drawing.Point(316, 234);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(100, 31);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_usuario.Location = new System.Drawing.Point(477, 124);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(176, 26);
            this.txt_usuario.TabIndex = 5;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_senha.Location = new System.Drawing.Point(477, 241);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(176, 26);
            this.txt_senha.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(241, 327);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(252, 93);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Logar!";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_esqueci
            // 
            this.lbl_esqueci.AutoSize = true;
            this.lbl_esqueci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline);
            this.lbl_esqueci.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_esqueci.Location = new System.Drawing.Point(472, 289);
            this.lbl_esqueci.Name = "lbl_esqueci";
            this.lbl_esqueci.Size = new System.Drawing.Size(199, 25);
            this.lbl_esqueci.TabIndex = 8;
            this.lbl_esqueci.Text = "Esqueci minha senha";
            this.lbl_esqueci.Click += new System.EventHandler(this.lbl_esqueci_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.lbl_esqueci);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.close);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_esqueci;
    }
}

