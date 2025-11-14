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
    public partial class EditarMetPag : Form
    {
        public EditarMetPag()
        {
            InitializeComponent();
            foreach (MetPag metPag in Program.metodos_pag)
            {
                selecionarItem.Items.Add(metPag.getNome());
            }
        }

        private void EditarMetPag_Load(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_nome == null || txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Nome inválido! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nome = txt_nome.Text.Trim();
            decimal taxa;
            try
            {
                taxa = decimal.Parse(txt_taxa.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Taxa inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetPag metodoParaAlterar = Program.metodos_pag.FirstOrDefault(metodo => metodo.getNome() == selecionarItem.SelectedText);
            metodoParaAlterar.setNome(nome);
            metodoParaAlterar.setTaxa(taxa);

        }
    }
}
