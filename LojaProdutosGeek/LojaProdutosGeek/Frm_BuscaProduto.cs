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
    public partial class Frm_BuscaProduto : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();
        public string idSelect { get; set; }
        public Frm_BuscaProduto(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Buscar produto";
            Tls_BuscarProduto.Items[0].ToolTipText = "Preencher com a seleção";
            Tls_BuscarProduto.Items[1].ToolTipText = "Fechar a seleção";
            PreencherListaProdutos();
            Lst_BuscarProduto.Sorted = true;
        }
        private void PreencherListaProdutos()
        {
            Lst_BuscarProduto.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                //Lst_BuscarProduto.Items.Add(_ListaBusca[i][1]);
                ItemBox X = new ItemBox();
                X.Id = _ListaBusca[i][0];
                X.Nome = _ListaBusca[i][1];
                Lst_BuscarProduto.Items.Add(X);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)Lst_BuscarProduto.Items[Lst_BuscarProduto.SelectedIndex];
            idSelect = ItemSelecionado.Id;
            this.Close();
        }

        private void FecharToolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        class ItemBox
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }

        }
    }
}
