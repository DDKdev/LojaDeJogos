using LojaProdutosGeekBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaProdutosGeek
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal_Cliente.Items[0].ToolTipText = "Salvar o Cliente no banco de Dados";
            Tls_Principal_Cliente.Items[1].ToolTipText = "Buscar o Cliente na base";
            Tls_Principal_Cliente.Items[2].ToolTipText = "Alterar dados do Cliente";
            Tls_Principal_Cliente.Items[3].ToolTipText = "Limpar formulário";
            Tls_Principal_Cliente.Items[4].ToolTipText = "Excluir Cliente do Banco de Dados";
        }

        private void SalvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C.IdCliente = Msk_IdCliente.Text;
                C.ValidaClasseCliente();
                MessageBox.Show("Cliente cadastrado com Sucesso!", "LojaGeek", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }
    }
}
