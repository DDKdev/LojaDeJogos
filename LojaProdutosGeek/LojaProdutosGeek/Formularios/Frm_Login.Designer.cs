namespace LojaProdutosGeek
{
    partial class Frm_Login
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
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_login = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_login = new System.Windows.Forms.Label();
            this.Lbl_senha = new System.Windows.Forms.Label();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(241, 146);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(86, 34);
            this.Btn_Ok.TabIndex = 0;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(37, 157);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "button2";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Txt_login
            // 
            this.Txt_login.Location = new System.Drawing.Point(118, 32);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(187, 20);
            this.Txt_login.TabIndex = 3;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(118, 93);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(156, 20);
            this.Txt_Senha.TabIndex = 4;
            // 
            // Lbl_login
            // 
            this.Lbl_login.AutoSize = true;
            this.Lbl_login.Location = new System.Drawing.Point(118, 13);
            this.Lbl_login.Name = "Lbl_login";
            this.Lbl_login.Size = new System.Drawing.Size(35, 13);
            this.Lbl_login.TabIndex = 5;
            this.Lbl_login.Text = "label1";
            // 
            // Lbl_senha
            // 
            this.Lbl_senha.AutoSize = true;
            this.Lbl_senha.Location = new System.Drawing.Point(118, 77);
            this.Lbl_senha.Name = "Lbl_senha";
            this.Lbl_senha.Size = new System.Drawing.Size(35, 13);
            this.Lbl_senha.TabIndex = 6;
            this.Lbl_senha.Text = "label2";
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Image = global::LojaProdutosGeek.Properties.Resources.senha__1_;
            this.Btn_VerSenha.Location = new System.Drawing.Point(281, 93);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(38, 22);
            this.Btn_VerSenha.TabIndex = 7;
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Pic_Login
            // 
            this.Pic_Login.Image = global::LojaProdutosGeek.Properties.Resources.key;
            this.Pic_Login.Location = new System.Drawing.Point(13, 13);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(90, 100);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Login.TabIndex = 2;
            this.Pic_Login.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 212);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Lbl_senha);
            this.Controls.Add(this.Lbl_login);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.Pic_Login);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.TextBox Txt_login;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_login;
        private System.Windows.Forms.Label Lbl_senha;
        private System.Windows.Forms.Button Btn_VerSenha;
    }
}