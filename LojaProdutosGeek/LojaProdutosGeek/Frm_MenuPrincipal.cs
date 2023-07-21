using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaProdutosGeek
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            abrirToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();

            string login = f.login;
            string senha = f.senha;

            if (f.DialogResult == DialogResult.OK)
            {
                if (LojaProdutosGeekBiblioteca.Cls_Uteis.ValidaAcesso(login, senha))
                {
                    MessageBox.Show("Bem Vindo " + login + "!!!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    abrirToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Q = new Frm_Questao("Deseja mesmo desconectar. As abas serão fechadas!");
            Q.ShowDialog();

            if(Q.DialogResult == DialogResult.Yes)
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                abrirToolStripMenuItem.Enabled = false;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int controleAbaCliente = 0;
        int controleAbaProduto = 0;

        private void formulárioProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(controleAbaProduto == 0)
            {
                controleAbaProduto += 1;
                Frm_CadastroProdutos_UC U = new Frm_CadastroProdutos_UC();
                TabPage TB = new TabPage();
                TB.Name = "Produto";
                TB.Text = "Produto";
                TB.Dock = DockStyle.Fill;
                TB.ImageIndex = 4;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Já existe um formulário de Produto aberto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formulárioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controleAbaCliente == 0)
            {
                controleAbaCliente += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                TabPage TB = new TabPage();
                TB.Name = "Cliente";
                TB.Text = "Cliente";
                TB.Dock = DockStyle.Fill;
                TB.ImageIndex = 5;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Já existe um formulário de Cliente aberto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar Todas as Esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar Todas as Direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar Todas menos Esta", "DeleteAll");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
            }
        }
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image MyImage = (Image)global::LojaProdutosGeek.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            return vToolTip;
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1;
                   i > ItemSelecionado; i += -1)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i += -1)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        void ApagaAba(TabPage TB)
        {
            if (TB.Name == "Cliente")
            {
                controleAbaCliente = 0;
            }
            if (TB.Name == "Produto")
            {
                controleAbaProduto = 0;

            }
            Tbc_Aplicacoes.TabPages.Remove(TB);
        }

    }
}
