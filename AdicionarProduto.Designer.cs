namespace Visualizador_de_Renda.Entities {
    partial class AdicionarProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.txb_Preco = new System.Windows.Forms.TextBox();
            this.num_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.lbl_Importancia = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cbb_Importancia = new System.Windows.Forms.ComboBox();
            this.cbb_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Lembrete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(425, 24);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Adicionar Novo Produto";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(188, 69);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(249, 27);
            this.txb_Nome.TabIndex = 2;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(169, 301);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(109, 35);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(16, 69);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(166, 24);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.Location = new System.Drawing.Point(20, 100);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(162, 24);
            this.lbl_Quantidade.TabIndex = 4;
            this.lbl_Quantidade.Text = "Quantidade:";
            this.lbl_Quantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txb_Preco
            // 
            this.txb_Preco.Location = new System.Drawing.Point(188, 137);
            this.txb_Preco.Name = "txb_Preco";
            this.txb_Preco.Size = new System.Drawing.Size(249, 27);
            this.txb_Preco.TabIndex = 4;
            // 
            // num_Quantidade
            // 
            this.num_Quantidade.Location = new System.Drawing.Point(188, 101);
            this.num_Quantidade.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_Quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Quantidade.Name = "num_Quantidade";
            this.num_Quantidade.Size = new System.Drawing.Size(249, 27);
            this.num_Quantidade.TabIndex = 3;
            this.num_Quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.Location = new System.Drawing.Point(20, 137);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(162, 24);
            this.lbl_Preco.TabIndex = 11;
            this.lbl_Preco.Text = "Preço:";
            this.lbl_Preco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Importancia
            // 
            this.lbl_Importancia.Location = new System.Drawing.Point(20, 170);
            this.lbl_Importancia.Name = "lbl_Importancia";
            this.lbl_Importancia.Size = new System.Drawing.Size(162, 24);
            this.lbl_Importancia.TabIndex = 12;
            this.lbl_Importancia.Text = "Importância:";
            this.lbl_Importancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(328, 301);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(109, 35);
            this.btn_Adicionar.TabIndex = 9;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 301);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cbb_Importancia
            // 
            this.cbb_Importancia.FormattingEnabled = true;
            this.cbb_Importancia.Location = new System.Drawing.Point(188, 170);
            this.cbb_Importancia.Name = "cbb_Importancia";
            this.cbb_Importancia.Size = new System.Drawing.Size(249, 27);
            this.cbb_Importancia.TabIndex = 5;
            // 
            // cbb_Tipo
            // 
            this.cbb_Tipo.FormattingEnabled = true;
            this.cbb_Tipo.Location = new System.Drawing.Point(188, 36);
            this.cbb_Tipo.Name = "cbb_Tipo";
            this.cbb_Tipo.Size = new System.Drawing.Size(249, 27);
            this.cbb_Tipo.TabIndex = 1;
            this.cbb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cbb_Tipo_SelectedIndexChanged);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.Location = new System.Drawing.Point(16, 36);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(166, 24);
            this.lbl_Tipo.TabIndex = 14;
            this.lbl_Tipo.Text = "Tipo de Renda:";
            this.lbl_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lembrete:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txb_Lembrete
            // 
            this.txb_Lembrete.Location = new System.Drawing.Point(188, 203);
            this.txb_Lembrete.Multiline = true;
            this.txb_Lembrete.Name = "txb_Lembrete";
            this.txb_Lembrete.Size = new System.Drawing.Size(249, 92);
            this.txb_Lembrete.TabIndex = 6;
            this.txb_Lembrete.Text = "Caso necessário, informe um lembrete desejado";
            this.txb_Lembrete.Enter += new System.EventHandler(this.txb_Lembrete_Enter);
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(449, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Lembrete);
            this.Controls.Add(this.cbb_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.cbb_Importancia);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.lbl_Importancia);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.num_Quantidade);
            this.Controls.Add(this.txb_Preco);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProduto";
            this.Load += new System.EventHandler(this.AdicionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.TextBox txb_Preco;
        private System.Windows.Forms.NumericUpDown num_Quantidade;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Label lbl_Importancia;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cbb_Importancia;
        private System.Windows.Forms.ComboBox cbb_Tipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Lembrete;
    }
}