namespace LojaProdutosGeek
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.Img_Lista = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulárioProdutoToolStripMenuItem,
            this.formulárioClienteToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // formulárioProdutoToolStripMenuItem
            // 
            this.formulárioProdutoToolStripMenuItem.Image = global::LojaProdutosGeek.Properties.Resources.money;
            this.formulárioProdutoToolStripMenuItem.Name = "formulárioProdutoToolStripMenuItem";
            this.formulárioProdutoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.formulárioProdutoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.formulárioProdutoToolStripMenuItem.Text = "Formulário Produto";
            this.formulárioProdutoToolStripMenuItem.Click += new System.EventHandler(this.formulárioProdutoToolStripMenuItem_Click);
            // 
            // formulárioClienteToolStripMenuItem
            // 
            this.formulárioClienteToolStripMenuItem.Image = global::LojaProdutosGeek.Properties.Resources.user;
            this.formulárioClienteToolStripMenuItem.Name = "formulárioClienteToolStripMenuItem";
            this.formulárioClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.formulárioClienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.formulárioClienteToolStripMenuItem.Text = "Formulário Cliente";
            this.formulárioClienteToolStripMenuItem.Click += new System.EventHandler(this.formulárioClienteToolStripMenuItem_Click);
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.ImageList = this.Img_Lista;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(884, 437);
            this.Tbc_Aplicacoes.TabIndex = 1;
            this.Tbc_Aplicacoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Aplicacoes_MouseDown);
            // 
            // Img_Lista
            // 
            this.Img_Lista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_Lista.ImageStream")));
            this.Img_Lista.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_Lista.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.Img_Lista.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.Img_Lista.Images.SetKeyName(2, "Frm_Mascara.png");
            this.Img_Lista.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.Img_Lista.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.Img_Lista.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            this.Img_Lista.Images.SetKeyName(6, "key.png");
            this.Img_Lista.Images.SetKeyName(7, "question.png");
            this.Img_Lista.Images.SetKeyName(8, "senha (1).png");
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Administration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioClienteToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList Img_Lista;
    }
}