namespace LojaProdutosGeek
{
    partial class Frm_BuscaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscaProduto));
            this.Tls_BuscarProduto = new System.Windows.Forms.ToolStrip();
            this.Lst_BuscarProduto = new System.Windows.Forms.ListBox();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FecharToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Tls_BuscarProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_BuscarProduto
            // 
            this.Tls_BuscarProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.FecharToolStripButton1});
            this.Tls_BuscarProduto.Location = new System.Drawing.Point(0, 0);
            this.Tls_BuscarProduto.Name = "Tls_BuscarProduto";
            this.Tls_BuscarProduto.Size = new System.Drawing.Size(304, 25);
            this.Tls_BuscarProduto.TabIndex = 3;
            this.Tls_BuscarProduto.Text = "toolStrip1";
            // 
            // Lst_BuscarProduto
            // 
            this.Lst_BuscarProduto.FormattingEnabled = true;
            this.Lst_BuscarProduto.Location = new System.Drawing.Point(12, 51);
            this.Lst_BuscarProduto.Name = "Lst_BuscarProduto";
            this.Lst_BuscarProduto.Size = new System.Drawing.Size(280, 173);
            this.Lst_BuscarProduto.TabIndex = 2;
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // FecharToolStripButton1
            // 
            this.FecharToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FecharToolStripButton1.Image = global::LojaProdutosGeek.Properties.Resources.ExcluirBarra;
            this.FecharToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FecharToolStripButton1.Name = "FecharToolStripButton1";
            this.FecharToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.FecharToolStripButton1.Text = "toolStripButton1";
            this.FecharToolStripButton1.ToolTipText = "Fechar";
            this.FecharToolStripButton1.Click += new System.EventHandler(this.FecharToolStripButton1_Click);
            // 
            // Frm_BuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.Tls_BuscarProduto);
            this.Controls.Add(this.Lst_BuscarProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscaProduto";
            this.Text = "Frm_BuscaProduto";
            this.Tls_BuscarProduto.ResumeLayout(false);
            this.Tls_BuscarProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_BuscarProduto;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton FecharToolStripButton1;
        private System.Windows.Forms.ListBox Lst_BuscarProduto;
    }
}