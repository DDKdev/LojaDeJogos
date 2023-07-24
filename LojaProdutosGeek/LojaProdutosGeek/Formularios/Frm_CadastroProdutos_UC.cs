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
    public partial class Frm_CadastroProdutos_UC : UserControl
    {
        public Frm_CadastroProdutos_UC()
        {
            InitializeComponent();
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
    }
}
