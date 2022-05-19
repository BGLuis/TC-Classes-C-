namespace Classes_Nome
{
    partial class FrmPrefeito
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefeitoToolStripMenuItem,
            this.lojaToolStripMenuItem,
            this.alimentoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // prefeitoToolStripMenuItem
            // 
            this.prefeitoToolStripMenuItem.Name = "prefeitoToolStripMenuItem";
            this.prefeitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prefeitoToolStripMenuItem.Text = "Prefeito";
            this.prefeitoToolStripMenuItem.Click += new System.EventHandler(this.prefeitoToolStripMenuItem_Click);
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lojaToolStripMenuItem.Text = "Loja";
            this.lojaToolStripMenuItem.Click += new System.EventHandler(this.lojaToolStripMenuItem_Click);
            // 
            // alimentoToolStripMenuItem
            // 
            this.alimentoToolStripMenuItem.Name = "alimentoToolStripMenuItem";
            this.alimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alimentoToolStripMenuItem.Text = "Alimento";
            this.alimentoToolStripMenuItem.Click += new System.EventHandler(this.alimentoToolStripMenuItem_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(156, 176);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(178, 45);
            this.btnCadastra.TabIndex = 1;
            this.btnCadastra.Text = "Cadastra";
            this.btnCadastra.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(456, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 45);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(68, 118);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(111, 20);
            this.txtCEP.TabIndex = 6;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(34, 121);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 5;
            this.lblCEP.Text = "CEP";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(381, 46);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(145, 20);
            this.txtCPF.TabIndex = 8;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(348, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(642, 46);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(100, 20);
            this.txtNasc.TabIndex = 10;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(532, 49);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(104, 13);
            this.lblNasc.TabIndex = 9;
            this.lblNasc.Text = "Data de Nascimento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(680, 82);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(630, 85);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(286, 82);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(147, 20);
            this.txtRua.TabIndex = 14;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(234, 85);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(46, 13);
            this.lblRua.TabIndex = 13;
            this.lblRua.Text = "Rua/AV";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(516, 82);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 18;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(439, 85);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 17;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(642, 118);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 16;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(607, 121);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(81, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(134, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(29, 85);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 21;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(237, 118);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(179, 20);
            this.txtCidade.TabIndex = 26;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(191, 121);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(479, 118);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(122, 20);
            this.txtEstado.TabIndex = 30;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(433, 121);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado";
            // 
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrefeito";
            this.Text = "Prefeito";
            this.Load += new System.EventHandler(this.FrmPrefeito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}

