namespace LojaProdutosGeek
{
    partial class Frm_Questao
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
            this.Btn_Sim = new System.Windows.Forms.Button();
            this.Btn_Nao = new System.Windows.Forms.Button();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Sim
            // 
            this.Btn_Sim.Location = new System.Drawing.Point(159, 72);
            this.Btn_Sim.Name = "Btn_Sim";
            this.Btn_Sim.Size = new System.Drawing.Size(85, 29);
            this.Btn_Sim.TabIndex = 0;
            this.Btn_Sim.Text = "Sim";
            this.Btn_Sim.UseVisualStyleBackColor = true;
            this.Btn_Sim.Click += new System.EventHandler(this.Btn_Sim_Click);
            // 
            // Btn_Nao
            // 
            this.Btn_Nao.Location = new System.Drawing.Point(288, 72);
            this.Btn_Nao.Name = "Btn_Nao";
            this.Btn_Nao.Size = new System.Drawing.Size(76, 29);
            this.Btn_Nao.TabIndex = 1;
            this.Btn_Nao.Text = "Não";
            this.Btn_Nao.UseVisualStyleBackColor = true;
            this.Btn_Nao.Click += new System.EventHandler(this.Btn_Nao_Click);
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.Location = new System.Drawing.Point(136, 12);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Pergunta.TabIndex = 2;
            this.Lbl_Pergunta.Text = "label1";
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Image = global::LojaProdutosGeek.Properties.Resources.icons8_question_mark_96;
            this.Pic_Imagem.Location = new System.Drawing.Point(12, 12);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(100, 109);
            this.Pic_Imagem.TabIndex = 3;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 141);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Lbl_Pergunta);
            this.Controls.Add(this.Btn_Nao);
            this.Controls.Add(this.Btn_Sim);
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Questao";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sim;
        private System.Windows.Forms.Button Btn_Nao;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.PictureBox Pic_Imagem;
    }
}