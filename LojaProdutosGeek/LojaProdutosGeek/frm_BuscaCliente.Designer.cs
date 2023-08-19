namespace LojaProdutosGeek
{
    partial class frm_BuscaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuscaCliente));
            this.Lst_BuscarCliente = new System.Windows.Forms.ListBox();
            this.Tls_BuscarCliente = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FecharToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Tls_BuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lst_BuscarCliente
            // 
            this.Lst_BuscarCliente.FormattingEnabled = true;
            this.Lst_BuscarCliente.Location = new System.Drawing.Point(12, 39);
            this.Lst_BuscarCliente.Name = "Lst_BuscarCliente";
            this.Lst_BuscarCliente.Size = new System.Drawing.Size(280, 173);
            this.Lst_BuscarCliente.TabIndex = 0;
            // 
            // Tls_BuscarCliente
            // 
            this.Tls_BuscarCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.FecharToolStripButton1});
            this.Tls_BuscarCliente.Location = new System.Drawing.Point(0, 0);
            this.Tls_BuscarCliente.Name = "Tls_BuscarCliente";
            this.Tls_BuscarCliente.Size = new System.Drawing.Size(304, 25);
            this.Tls_BuscarCliente.TabIndex = 1;
            this.Tls_BuscarCliente.Text = "toolStrip1";
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
            this.FecharToolStripButton1.Click += new System.EventHandler(this.FecharToolStripButton1_Click);
            // 
            // frm_BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.Tls_BuscarCliente);
            this.Controls.Add(this.Lst_BuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BuscaCliente";
            this.Text = "frm_BuscaCliente";
            this.Tls_BuscarCliente.ResumeLayout(false);
            this.Tls_BuscarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_BuscarCliente;
        private System.Windows.Forms.ToolStrip Tls_BuscarCliente;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton FecharToolStripButton1;
    }
}