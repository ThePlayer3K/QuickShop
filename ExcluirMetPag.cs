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
    public partial class ExcluirMetPag : Form
    {
        public ExcluirMetPag()
        {
            InitializeComponent();
            foreach (MetPag metPag in Program.metodos_pag)
            {
                combo_selecionar_metodo.Items.Add(metPag.getNome());
            }
        }

        private void ExcluirMetPag_Load(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (combo_selecionar_metodo.SelectedText == null || combo_selecionar_metodo.SelectedText.Trim() == "")
            {
                MessageBox.Show("Selecione um método de pagamento para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetPag metodoParaExcluir = Program.metodos_pag.FirstOrDefault(metodo => metodo.getNome() == combo_selecionar_metodo.SelectedText);
            DialogResult confirmacao = MessageBox.Show("Tem certeza de que quer remover o método de pagamento " + metodoParaExcluir.getNome() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                metodoParaExcluir.removerBanco();
                Program.metodos_pag.Remove(metodoParaExcluir);
                MessageBox.Show("Método removido com sucesso!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
