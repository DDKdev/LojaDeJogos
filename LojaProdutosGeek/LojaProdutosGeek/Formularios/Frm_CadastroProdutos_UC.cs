using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using LojaProdutosGeekBiblioteca;

namespace LojaProdutosGeek
{
    public partial class Frm_CadastroProdutos_UC : UserControl
    {
        public Frm_CadastroProdutos_UC()
        {
            InitializeComponent();

            Tls_Principal_Produtos.Items[0].ToolTipText = "Salvar o produto no banco de Dados";
            Tls_Principal_Produtos.Items[1].ToolTipText = "Buscar o produto na base";
            Tls_Principal_Produtos.Items[2].ToolTipText = "Alterar dados do produto";
            Tls_Principal_Produtos.Items[3].ToolTipText = "Limpar formulário";
            Tls_Principal_Produtos.Items[4].ToolTipText = "Excluir produto do Banco de Dados";

        }

        private void Rd_Jogos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_Jogos.Checked)
            {
                Txt_plataforma.Enabled = true;
                Txt_garantia.Enabled = true;
            }
        }

        private void Rd_ProdutosGeek_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_ProdutosGeek.Checked)
            {
                Txt_plataforma.Enabled = false;
                Txt_garantia.Enabled = false;
            }
        }

        private void Rd_Acessorios_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_Acessorios.Checked)
            {
                Txt_plataforma.Enabled = true;
                Txt_garantia.Enabled = true;
            }
        }

        private void SalvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto.Unit P = new Produto.Unit();
                P.IdProduto = Msk_CodProduto.Text;
                P.ValidaClasseProduto();
                MessageBox.Show("Produto cadastrado com Sucesso!", "LojaGeek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "LojaGeek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Abrir");
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Alterar");
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Limpar");
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Excluir");
        }
    }
}
