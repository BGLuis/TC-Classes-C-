namespace Classes_Nome
{
    partial class FrmLoja
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(480, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 45);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(123, 189);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(178, 45);
            this.btnCadastra.TabIndex = 4;
            this.btnCadastra.Text = "Cadastra";
            this.btnCadastra.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
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
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(480, 137);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(122, 20);
            this.txtEstado.TabIndex = 52;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(434, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(238, 137);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(179, 20);
            this.txtCidade.TabIndex = 50;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(192, 140);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 49;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(82, 101);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(134, 20);
            this.txtBairro.TabIndex = 48;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(30, 104);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 47;
            this.lblBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(517, 101);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 46;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(440, 104);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 45;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(643, 137);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 44;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(608, 140);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 43;
            this.lblPais.Text = "País";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(287, 101);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(147, 20);
            this.txtRua.TabIndex = 42;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(235, 104);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(46, 13);
            this.lblRua.TabIndex = 41;
            this.lblRua.Text = "Rua/AV";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(681, 101);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 20);
            this.txtNumero.TabIndex = 40;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(631, 104);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 39;
            this.lblNumero.Text = "Número";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(598, 65);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(145, 20);
            this.txtCNPJ.TabIndex = 36;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(559, 68);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 35;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(69, 137);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(111, 20);
            this.txtCEP.TabIndex = 34;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(35, 140);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 33;
            this.lblCEP.Text = "CEP";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 20);
            this.txtNome.TabIndex = 32;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(78, 13);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome Fantasia";
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
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
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmLoja";
            this.Text = "FrmLoja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}