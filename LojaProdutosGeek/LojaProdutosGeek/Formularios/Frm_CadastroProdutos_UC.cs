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
using Microsoft.VisualBasic;
using LojaProdutosGeekBiblioteca.DataBases;

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
                P = LerFormulario();
                P.ValidaClasseProduto();
                string produtoJson = Produto.Serializar(P);

                FicharioProduto F = new FicharioProduto("C:\\Users\\dnl_3\\OneDrive\\Documentos\\ProjetosGitHub\\LojaProdutosGeek\\LojaProdutosGeek\\FicharioProduto");
                if (F.status)
                {
                    F.Incluir(P.IdProduto, produtoJson);
                    if (F.status)
                    {
                        MessageBox.Show("OK: " + F.mensagem, "ProjetoGeek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Err: " + F.mensagem, "ProjetoGeek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            LimparFormulario();
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Excluir");
        }

        Produto.Unit LerFormulario()
        {
            Produto.Unit P = new Produto.Unit();
            P.IdProduto = Msk_CodProduto.Text;
            P.NomeProduto = Txt_NomeProduto.Text;
            P.Quantidade = Txt_Quantidade.Text;
            P.CodigoBarra = Txt_CodBarra.Text;            
            P.Fabricante = Txt_Fabricante.Text;
            if(Rd_Jogos.Checked || Rd_Acessorios.Checked)
            {
                P.Plataforma = Txt_plataforma.Text;
                P.Garantia = Txt_garantia.Text;
            }

            if (Information.IsNumeric(Txt_preco.Text))
            {
                Double vPreco = Convert.ToDouble(Txt_preco.Text);
                if (vPreco < 0)
                {
                    P.Preco = 0;
                }
                else
                {
                    P.Preco = vPreco;
                }
            }

            if (Rd_Acessorios.Checked)
            {
                P.Categoria = 0;
            }
            if (Rd_Jogos.Checked)
            {
                P.Categoria = 1;
            }
            if (Rd_ProdutosGeek.Checked)
            {
                P.Categoria = 2;
            }

            return P;
        }

        private void LimparFormulario()
        {

            Msk_CodProduto.Text = "";
            Txt_CodBarra.Text = "";
            Txt_NomeProduto.Text = "";
            Txt_Quantidade.Text = "";
            Txt_preco.Text = "";
            Txt_plataforma.Text = "";
            Txt_garantia.Text = "";
            Txt_Fabricante.Text = "";
            Rd_Acessorios.Checked = false;
            Rd_Jogos.Checked = false;
            Rd_ProdutosGeek.Checked = false;
        }
    }
}
