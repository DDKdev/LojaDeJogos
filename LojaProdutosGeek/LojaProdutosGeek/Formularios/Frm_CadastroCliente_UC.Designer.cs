namespace LojaProdutosGeek
{
    partial class Frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Rua = new System.Windows.Forms.TextBox();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Rg = new System.Windows.Forms.TextBox();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Msk_DtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.Msk_IdCliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Rua = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Rg = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_DtCadastro = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.Grp_Controle = new System.Windows.Forms.GroupBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rd_Indefinido = new System.Windows.Forms.RadioButton();
            this.Lbl_genero = new System.Windows.Forms.Label();
            this.Rd_Feminino = new System.Windows.Forms.RadioButton();
            this.Rd_masculino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Tls_Principal_Cliente = new System.Windows.Forms.ToolStrip();
            this.SalvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AbrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AlterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LimparToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grp_Controle.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Tls_Principal_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(312, 88);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(136, 20);
            this.Txt_Cidade.TabIndex = 15;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(160, 88);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(143, 20);
            this.Txt_Bairro.TabIndex = 14;
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(15, 88);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(130, 20);
            this.Txt_Complemento.TabIndex = 13;
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(515, 44);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(60, 20);
            this.Txt_Numero.TabIndex = 12;
            // 
            // Msk_Cep
            // 
            this.Msk_Cep.Location = new System.Drawing.Point(15, 44);
            this.Msk_Cep.Mask = "00000-000";
            this.Msk_Cep.Name = "Msk_Cep";
            this.Msk_Cep.Size = new System.Drawing.Size(64, 20);
            this.Msk_Cep.TabIndex = 10;
            this.Msk_Cep.MouseLeave += new System.EventHandler(this.Msk_Cep_MouseLeave);
            // 
            // Txt_Rua
            // 
            this.Txt_Rua.Location = new System.Drawing.Point(91, 44);
            this.Txt_Rua.Name = "Txt_Rua";
            this.Txt_Rua.Size = new System.Drawing.Size(415, 20);
            this.Txt_Rua.TabIndex = 11;
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(269, 83);
            this.Msk_Telefone.Mask = "(00)000000000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(108, 20);
            this.Msk_Telefone.TabIndex = 6;
            // 
            // Msk_Cpf
            // 
            this.Msk_Cpf.Location = new System.Drawing.Point(12, 83);
            this.Msk_Cpf.Mask = "000,000,000-00";
            this.Msk_Cpf.Name = "Msk_Cpf";
            this.Msk_Cpf.Size = new System.Drawing.Size(91, 20);
            this.Msk_Cpf.TabIndex = 4;
            // 
            // Txt_Rg
            // 
            this.Txt_Rg.Location = new System.Drawing.Point(128, 83);
            this.Txt_Rg.Name = "Txt_Rg";
            this.Txt_Rg.Size = new System.Drawing.Size(112, 20);
            this.Txt_Rg.TabIndex = 5;
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(12, 32);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(415, 20);
            this.Txt_NomeCliente.TabIndex = 3;
            // 
            // Msk_DtCadastro
            // 
            this.Msk_DtCadastro.Location = new System.Drawing.Point(138, 43);
            this.Msk_DtCadastro.Mask = "00/00/0000";
            this.Msk_DtCadastro.Name = "Msk_DtCadastro";
            this.Msk_DtCadastro.Size = new System.Drawing.Size(67, 20);
            this.Msk_DtCadastro.TabIndex = 2;
            this.Msk_DtCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Msk_IdCliente
            // 
            this.Msk_IdCliente.Location = new System.Drawing.Point(26, 43);
            this.Msk_IdCliente.Mask = "00000";
            this.Msk_IdCliente.Name = "Msk_IdCliente";
            this.Msk_IdCliente.Size = new System.Drawing.Size(49, 20);
            this.Msk_IdCliente.TabIndex = 1;
            this.Msk_IdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(266, 67);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Telefone.TabIndex = 39;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Lbl_Rua
            // 
            this.Lbl_Rua.AutoSize = true;
            this.Lbl_Rua.Location = new System.Drawing.Point(88, 27);
            this.Lbl_Rua.Name = "Lbl_Rua";
            this.Lbl_Rua.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Rua.TabIndex = 38;
            this.Lbl_Rua.Text = "Rua";
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Location = new System.Drawing.Point(12, 27);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Cep.TabIndex = 37;
            this.Lbl_Cep.Text = "CEP";
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(512, 27);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Numero.TabIndex = 36;
            this.Lbl_Numero.Text = "Número";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(12, 72);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Complemento.TabIndex = 35;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(463, 72);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Estado.TabIndex = 34;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Rg
            // 
            this.Lbl_Rg.AutoSize = true;
            this.Lbl_Rg.Location = new System.Drawing.Point(125, 66);
            this.Lbl_Rg.Name = "Lbl_Rg";
            this.Lbl_Rg.Size = new System.Drawing.Size(23, 13);
            this.Lbl_Rg.TabIndex = 33;
            this.Lbl_Rg.Text = "RG";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(9, 66);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 32;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(9, 16);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(82, 13);
            this.Lbl_NomeCliente.TabIndex = 31;
            this.Lbl_NomeCliente.Text = "Nome Completo";
            // 
            // Lbl_DtCadastro
            // 
            this.Lbl_DtCadastro.AutoSize = true;
            this.Lbl_DtCadastro.Location = new System.Drawing.Point(135, 27);
            this.Lbl_DtCadastro.Name = "Lbl_DtCadastro";
            this.Lbl_DtCadastro.Size = new System.Drawing.Size(90, 13);
            this.Lbl_DtCadastro.TabIndex = 30;
            this.Lbl_DtCadastro.Text = "Data do Cadastro";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(309, 72);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 29;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(157, 72);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 28;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_IdCliente
            // 
            this.Lbl_IdCliente.AutoSize = true;
            this.Lbl_IdCliente.Location = new System.Drawing.Point(23, 27);
            this.Lbl_IdCliente.Name = "Lbl_IdCliente";
            this.Lbl_IdCliente.Size = new System.Drawing.Size(68, 13);
            this.Lbl_IdCliente.TabIndex = 27;
            this.Lbl_IdCliente.Text = "ID do Cliente";
            // 
            // Grp_Controle
            // 
            this.Grp_Controle.Controls.Add(this.Lbl_DtCadastro);
            this.Grp_Controle.Controls.Add(this.Lbl_IdCliente);
            this.Grp_Controle.Controls.Add(this.Msk_IdCliente);
            this.Grp_Controle.Controls.Add(this.Msk_DtCadastro);
            this.Grp_Controle.Location = new System.Drawing.Point(12, 50);
            this.Grp_Controle.Name = "Grp_Controle";
            this.Grp_Controle.Size = new System.Drawing.Size(239, 79);
            this.Grp_Controle.TabIndex = 53;
            this.Grp_Controle.TabStop = false;
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_Cpf);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Rg);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Telefone);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_Rg);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_Telefone);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(12, 135);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(625, 117);
            this.Grp_DadosPessoais.TabIndex = 54;
            this.Grp_DadosPessoais.TabStop = false;
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rd_Indefinido);
            this.Grp_Genero.Controls.Add(this.Lbl_genero);
            this.Grp_Genero.Controls.Add(this.Rd_Feminino);
            this.Grp_Genero.Controls.Add(this.Rd_masculino);
            this.Grp_Genero.Location = new System.Drawing.Point(456, 11);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(144, 106);
            this.Grp_Genero.TabIndex = 60;
            this.Grp_Genero.TabStop = false;
            // 
            // Rd_Indefinido
            // 
            this.Rd_Indefinido.AutoSize = true;
            this.Rd_Indefinido.Location = new System.Drawing.Point(27, 78);
            this.Rd_Indefinido.Name = "Rd_Indefinido";
            this.Rd_Indefinido.Size = new System.Drawing.Size(71, 17);
            this.Rd_Indefinido.TabIndex = 9;
            this.Rd_Indefinido.TabStop = true;
            this.Rd_Indefinido.Text = "Indefinido";
            this.Rd_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Lbl_genero
            // 
            this.Lbl_genero.AutoSize = true;
            this.Lbl_genero.Location = new System.Drawing.Point(23, 16);
            this.Lbl_genero.Name = "Lbl_genero";
            this.Lbl_genero.Size = new System.Drawing.Size(42, 13);
            this.Lbl_genero.TabIndex = 56;
            this.Lbl_genero.Text = "Gênero";
            // 
            // Rd_Feminino
            // 
            this.Rd_Feminino.AutoSize = true;
            this.Rd_Feminino.Location = new System.Drawing.Point(27, 55);
            this.Rd_Feminino.Name = "Rd_Feminino";
            this.Rd_Feminino.Size = new System.Drawing.Size(67, 17);
            this.Rd_Feminino.TabIndex = 8;
            this.Rd_Feminino.TabStop = true;
            this.Rd_Feminino.Text = "Feminino";
            this.Rd_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rd_masculino
            // 
            this.Rd_masculino.AutoSize = true;
            this.Rd_masculino.Location = new System.Drawing.Point(27, 32);
            this.Rd_masculino.Name = "Rd_masculino";
            this.Rd_masculino.Size = new System.Drawing.Size(72, 17);
            this.Rd_masculino.TabIndex = 7;
            this.Rd_masculino.TabStop = true;
            this.Rd_masculino.Text = "masculino";
            this.Rd_masculino.UseVisualStyleBackColor = true;
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cep);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Rua);
            this.Grp_Endereco.Controls.Add(this.Msk_Cep);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Rua);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Controls.Add(this.Txt_Numero);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Numero);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Location = new System.Drawing.Point(12, 258);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(644, 119);
            this.Grp_Endereco.TabIndex = 55;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "Endereço";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.ItemHeight = 13;
            this.Cmb_Estados.Location = new System.Drawing.Point(466, 88);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(159, 21);
            this.Cmb_Estados.TabIndex = 53;
            // 
            // Tls_Principal_Cliente
            // 
            this.Tls_Principal_Cliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalvarToolStripButton,
            this.AbrirToolStripButton,
            this.AlterarToolStripButton,
            this.LimparToolStripButton,
            this.ExcluirToolStripButton});
            this.Tls_Principal_Cliente.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal_Cliente.Name = "Tls_Principal_Cliente";
            this.Tls_Principal_Cliente.Size = new System.Drawing.Size(669, 25);
            this.Tls_Principal_Cliente.TabIndex = 56;
            this.Tls_Principal_Cliente.Text = "toolStrip1";
            // 
            // SalvarToolStripButton
            // 
            this.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SalvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalvarToolStripButton.Image")));
            this.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalvarToolStripButton.Name = "SalvarToolStripButton";
            this.SalvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SalvarToolStripButton.Text = "&Novo";
            this.SalvarToolStripButton.Click += new System.EventHandler(this.SalvarToolStripButton_Click);
            // 
            // AbrirToolStripButton
            // 
            this.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AbrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AbrirToolStripButton.Image")));
            this.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AbrirToolStripButton.Name = "AbrirToolStripButton";
            this.AbrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AbrirToolStripButton.Text = "&Abrir";
            this.AbrirToolStripButton.Click += new System.EventHandler(this.AbrirToolStripButton_Click);
            // 
            // AlterarToolStripButton
            // 
            this.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AlterarToolStripButton.Image")));
            this.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton.Name = "AlterarToolStripButton";
            this.AlterarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AlterarToolStripButton.Text = "&Salvar";
            this.AlterarToolStripButton.Click += new System.EventHandler(this.AlterarToolStripButton_Click);
            // 
            // LimparToolStripButton
            // 
            this.LimparToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimparToolStripButton.Image = global::LojaProdutosGeek.Properties.Resources.LimparBarra;
            this.LimparToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimparToolStripButton.Name = "LimparToolStripButton";
            this.LimparToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LimparToolStripButton.Text = "toolStripButton1";
            this.LimparToolStripButton.Click += new System.EventHandler(this.LimparToolStripButton_Click);
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcluirToolStripButton.Image = global::LojaProdutosGeek.Properties.Resources.ExcluirBarra;
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExcluirToolStripButton.Text = "toolStripButton2";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tls_Principal_Cliente);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_Controle);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(669, 401);
            this.Grp_Controle.ResumeLayout(false);
            this.Grp_Controle.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Tls_Principal_Cliente.ResumeLayout(false);
            this.Tls_Principal_Cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.MaskedTextBox Msk_Cep;
        private System.Windows.Forms.TextBox Txt_Rua;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.MaskedTextBox Msk_Cpf;
        private System.Windows.Forms.TextBox Txt_Rg;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.MaskedTextBox Msk_DtCadastro;
        private System.Windows.Forms.MaskedTextBox Msk_IdCliente;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.Label Lbl_Rua;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Rg;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_DtCadastro;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.GroupBox Grp_Controle;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.ComboBox Cmb_Estados;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rd_Indefinido;
        private System.Windows.Forms.Label Lbl_genero;
        private System.Windows.Forms.RadioButton Rd_Feminino;
        private System.Windows.Forms.RadioButton Rd_masculino;
        private System.Windows.Forms.ToolStrip Tls_Principal_Cliente;
        private System.Windows.Forms.ToolStripButton SalvarToolStripButton;
        private System.Windows.Forms.ToolStripButton AbrirToolStripButton;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripButton LimparToolStripButton;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
    }
}
