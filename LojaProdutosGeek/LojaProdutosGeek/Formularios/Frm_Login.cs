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
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();

            Lbl_login.Text = "Login";
            Lbl_senha.Text = "Senha";
            Btn_Ok.Text = "Entrar";
            Btn_Cancel.Text = "Cancelar";
            Lbl_login.Focus();
        }

        public string login;
        public string senha;
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();

            login = Txt_login.Text;
            senha = Txt_Senha.Text;
        }
        bool VerSenha = false;
        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Ocultar Senha";
                VerSenha = true;
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver Senha";
                VerSenha = false;
            }
        }
    }
}
