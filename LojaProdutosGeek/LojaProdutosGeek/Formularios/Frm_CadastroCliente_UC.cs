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
using Microsoft.VisualBasic;
using LojaProdutosGeekBiblioteca.Classes;
using LojaProdutosGeekBiblioteca.DataBases;

namespace LojaProdutosGeek
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public string caminho = "C:\\Users\\dnl_3\\OneDrive\\Documentos\\ProjetosGitHub\\LojaProdutosGeek\\LojaProdutosGeek\\Fichario";
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
                C = LerFormulario();
                C.ValidaCPF();
                C.ValidaClasseCliente();

                string clienteJson = Cliente.Serializar(C);

                FicharioCliente F = new FicharioCliente(caminho);
                if (F.status)
                {
                    F.Incluir(C.IdCliente, clienteJson);
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
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "LojaGeek", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AbrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Msk_IdCliente.Text == "")
            {
                MessageBox.Show("O campo Id não pdoe estar vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FicharioCliente F = new FicharioCliente(caminho);
                string clienteJson = F.Buscar(Msk_IdCliente.Text);

                Cliente.Unit C = new Cliente.Unit();
                C = Cliente.Desserializar(clienteJson);
                EscreverFormulario(C);
            }

        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Msk_IdCliente.Text == "")
            {
                MessageBox.Show("O campo Id não pdoe estar vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    Cliente.Unit C = new Cliente.Unit();
                    C = LerFormulario();
                    C.ValidaClasseCliente();
                    C.ValidaCPF();
                    string clienteJson = Cliente.Serializar(C);
                    FicharioCliente F = new FicharioCliente(caminho);
                    if (F.status)
                    {
                        F.Alterar(C.IdCliente, clienteJson);
                        if (F.status)
                        {
                            MessageBox.Show("OK: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Msk_IdCliente.Text == "")
            {
                MessageBox.Show("O campo Id não pdoe estar vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FicharioCliente F = new FicharioCliente(caminho);
                if (F.status)
                {
                    string clienteJson = F.Buscar(Msk_IdCliente.Text);
                    Cliente.Unit C = new Cliente.Unit();
                    C = Cliente.Desserializar(clienteJson);
                    EscreverFormulario(C);

                    //Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Deseja realmente excluir?");
                    //Db.ShowDialog();
                    //if (Db.DialogResult == DialogResult.Yes)
                    if (MessageBox.Show("Deseja mesmo Excluir?", "geek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        F.Apagar(Msk_IdCliente.Text);
                        if (F.status)
                        {
                            MessageBox.Show("OK: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                        else
                        {
                            MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        Cliente.Unit LerFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.IdCliente = Msk_IdCliente.Text;
            C.NomeCliente = Txt_NomeCliente.Text;
            C.DtCadastro = Msk_DtCadastro.Text;
            C.Rg = Txt_Rg.Text;
            C.Cpf = Msk_Cpf.Text;
            C.Telefone = Msk_Telefone.Text;
            C.Cep = Msk_Cep.Text;
            C.Rua = Txt_Rua.Text;
            C.Numero = Txt_Numero.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;
            
            if (Rd_masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rd_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rd_Indefinido.Checked)
            {
                C.Genero = 2;
            }

            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            return C;

        }

        private void Msk_Cep_MouseLeave(object sender, EventArgs e)
        {
            string vCep = Msk_Cep.Text;
            vCep = vCep.Replace("-", "");
            if (vCep != "")
            {
                if(Msk_Cep.Text.Length >= 8)
                {
                    var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                    Cep.Unit CEP = new Cep.Unit();
                    CEP = Cep.Desserializar(vJson);
                    Txt_Rua.Text = CEP.logradouro;
                    Txt_Bairro.Text = CEP.bairro;
                    Txt_Cidade.Text = CEP.localidade;
                    Txt_Numero.Text = "";
                    Txt_Complemento.Text = "";

                    Cmb_Estados.SelectedIndex = -1;
                    for (int i = 0; i < Cmb_Estados.Items.Count - 1; i++)
                    {
                        var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ')');
                        if (vPos > 0)
                        {
                            Cmb_Estados.SelectedIndex = i;
                        }
                    }
                }
            }
        }
        void EscreverFormulario(Cliente.Unit C)
        {
            Msk_IdCliente.Text = C.IdCliente;
            Msk_DtCadastro.Text = C.DtCadastro;
            Txt_NomeCliente.Text = C.NomeCliente;
            Msk_Cpf.Text = C.Cpf;
            Txt_Rg.Text = C.Rg;
            Msk_Telefone.Text = C.Telefone;
            Msk_Cep.Text = C.Cep;
            Txt_Rua.Text = C.Rua;
            Txt_Numero.Text = C.Numero;
            Txt_Complemento.Text = C.Complemento;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;
            
            if (C.Genero == 1)
            {
                Rd_masculino.Checked = true;
            }
            if (C.Genero == 2)
            {
               Rd_Feminino.Checked = true;
            }
            if (C.Genero == 3)
            {
                Rd_Indefinido.Checked = true;
            }
            
            if (C.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }
        }

        private void LimparFormulario()
        {
            Msk_IdCliente.Text = "";
            Msk_DtCadastro.Text = "";
            Txt_NomeCliente.Text = "";
            Msk_Cpf.Text = "";
            Txt_Rg.Text = "";
            Msk_Telefone.Text = "";
            Rd_Feminino.Checked = false;
            Rd_masculino.Checked = false;
            Rd_Indefinido.Checked = false;
            Txt_Rua.Text = "";
            Msk_Cep.Text = "";
            Txt_Cidade.Text = "";
            Txt_Bairro.Text = "";
            Txt_Rua.Text = "";
            Txt_Numero.Text = "";
            Txt_Complemento.Text = "";
            Cmb_Estados.SelectedIndex = -1;
        }
    }
}
