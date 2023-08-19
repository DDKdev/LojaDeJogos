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
    public partial class frm_BuscaCliente : Form
    {
        List<List<string>> _ListaBuscaCliente = new List<List<string>>();
        public string idSelect { get; set; }
        public frm_BuscaCliente(List<List<string>> ListaBuscaCliente)
        {
            _ListaBuscaCliente = ListaBuscaCliente;
            InitializeComponent();
            this.Text = "Buscar Clientes";
            Tls_BuscarCliente.Items[0].ToolTipText = "Preencher formulário com a seleção";
            Tls_BuscarCliente.Items[1].ToolTipText = "Fechar Buscar clientes";
            PreencherListaCliente();
            Lst_BuscarCliente.Sorted = true;

        }
        private void PreencherListaCliente()
        {
            Lst_BuscarCliente.Items.Clear();
            for (int i = 0; i <= _ListaBuscaCliente.Count - 1; i++)
            {
                //Lst_BuscarCliente.Items.Add(_ListaBuscaCliente[i][1]);
                ItemBox X = new ItemBox();
                X.IdCliente = _ListaBuscaCliente[i][0];
                X.NomeCliente = _ListaBuscaCliente[i][1];
                Lst_BuscarCliente.Items.Add(X);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)Lst_BuscarCliente.Items[Lst_BuscarCliente.SelectedIndex];
            idSelect = ItemSelecionado.IdCliente;
            //idSelect = _ListaBuscaCliente[Lst_BuscarCliente.SelectedIndex][0];
            this.Close();
        }

        private void FecharToolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        class ItemBox
        {
            public string IdCliente { get; set; }
            public string NomeCliente { get; set; }

            public override string ToString()
            {
                return NomeCliente;
            }

        }
    }
}
