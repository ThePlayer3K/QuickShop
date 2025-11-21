using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickShop
{
    public partial class CadastrarMetPag : Form
    {
        public CadastrarMetPag()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome;
            decimal taxa;
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Nome inválido! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nome = txt_nome.Text.Trim();
            try
            {
                taxa = decimal.Parse(txt_taxa.Text);
            }
            catch
            {
                MessageBox.Show("Taxa inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetPag metPag = new MetPag(nome, taxa);
            metPag.adicionarMetodo(nome, taxa);
            MessageBox.Show("Método de pagamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.metodos_pag.Add(metPag);
            Program.metodos_pag_historicos.Add(metPag);
            this.Hide();
        }

        private void CadastrarMetPag_Load(object sender, EventArgs e)
        {

        }
    }
}
