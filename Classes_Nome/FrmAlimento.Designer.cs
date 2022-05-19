namespace Classes_Nome
{
    partial class FrmAlimento
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.lblAumento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(477, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 45);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(120, 207);
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(433, 70);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(246, 20);
            this.txtIngredientes.TabIndex = 9;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(362, 73);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(65, 13);
            this.lblIngredientes.TabIndex = 8;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtCalorias
            // 
            this.txtCalorias.Location = new System.Drawing.Point(107, 104);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(246, 20);
            this.txtCalorias.TabIndex = 11;
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(57, 107);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(44, 13);
            this.lblCalorias.TabIndex = 10;
            this.lblCalorias.Text = "Calorias";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(453, 104);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(246, 20);
            this.txtCompra.TabIndex = 13;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(362, 109);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(85, 13);
            this.lblCompra.TabIndex = 12;
            this.lblCompra.Text = "Valor de Compra";
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(383, 143);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(157, 20);
            this.txtAumento.TabIndex = 15;
            // 
            // lblAumento
            // 
            this.lblAumento.AutoSize = true;
            this.lblAumento.Location = new System.Drawing.Point(242, 146);
            this.lblAumento.Name = "lblAumento";
            this.lblAumento.Size = new System.Drawing.Size(136, 13);
            this.lblAumento.TabIndex = 14;
            this.lblAumento.Text = "Valor com 10% de aumento";
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.lblAumento);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAlimento";
            this.Text = "FrmAlimento";
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Label lblAumento;
    }
}