namespace Visualizador_de_Renda {
    partial class VisualizadorDeRenda {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lsb_Saida = new System.Windows.Forms.ListBox();
            this.btn_Add_New = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Information = new System.Windows.Forms.Label();
            this.lbl_Title_ListBox = new System.Windows.Forms.Label();
            this.lbl_Title_Information = new System.Windows.Forms.Label();
            this.btn_Deletar_Item = new System.Windows.Forms.Button();
            this.btn_Abrir_Carteira = new System.Windows.Forms.Button();
            this.btn_Show_Funcionalidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_Saida
            // 
            this.lsb_Saida.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_Saida.FormattingEnabled = true;
            this.lsb_Saida.ItemHeight = 21;
            this.lsb_Saida.Location = new System.Drawing.Point(12, 76);
            this.lsb_Saida.Name = "lsb_Saida";
            this.lsb_Saida.Size = new System.Drawing.Size(393, 256);
            this.lsb_Saida.TabIndex = 0;
            this.lsb_Saida.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsb_Saida_DrawItem);
            this.lsb_Saida.SelectedIndexChanged += new System.EventHandler(this.lsb_Saida_SelectedIndexChanged);
            // 
            // btn_Add_New
            // 
            this.btn_Add_New.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New.Location = new System.Drawing.Point(247, 338);
            this.btn_Add_New.Name = "btn_Add_New";
            this.btn_Add_New.Size = new System.Drawing.Size(158, 46);
            this.btn_Add_New.TabIndex = 1;
            this.btn_Add_New.Text = "Adicionar Novo Item";
            this.btn_Add_New.UseVisualStyleBackColor = true;
            this.btn_Add_New.Click += new System.EventHandler(this.btn_Add_New_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Consolas", 16.75F);
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(760, 29);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Renda";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Information
            // 
            this.lbl_Information.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.lbl_Information.Location = new System.Drawing.Point(411, 76);
            this.lbl_Information.Name = "lbl_Information";
            this.lbl_Information.Size = new System.Drawing.Size(361, 251);
            this.lbl_Information.TabIndex = 3;
            this.lbl_Information.Text = "Informações";
            this.lbl_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Title_ListBox
            // 
            this.lbl_Title_ListBox.Font = new System.Drawing.Font("Consolas", 16.75F);
            this.lbl_Title_ListBox.Location = new System.Drawing.Point(12, 38);
            this.lbl_Title_ListBox.Name = "lbl_Title_ListBox";
            this.lbl_Title_ListBox.Size = new System.Drawing.Size(393, 35);
            this.lbl_Title_ListBox.TabIndex = 4;
            this.lbl_Title_ListBox.Text = "Entrada/Saída de Dinheiro";
            this.lbl_Title_ListBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title_Information
            // 
            this.lbl_Title_Information.Font = new System.Drawing.Font("Consolas", 16.75F);
            this.lbl_Title_Information.Location = new System.Drawing.Point(411, 38);
            this.lbl_Title_Information.Name = "lbl_Title_Information";
            this.lbl_Title_Information.Size = new System.Drawing.Size(361, 35);
            this.lbl_Title_Information.TabIndex = 5;
            this.lbl_Title_Information.Text = "Informações";
            this.lbl_Title_Information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Deletar_Item
            // 
            this.btn_Deletar_Item.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar_Item.Location = new System.Drawing.Point(12, 338);
            this.btn_Deletar_Item.Name = "btn_Deletar_Item";
            this.btn_Deletar_Item.Size = new System.Drawing.Size(158, 46);
            this.btn_Deletar_Item.TabIndex = 6;
            this.btn_Deletar_Item.Text = "Deletar Item";
            this.btn_Deletar_Item.UseVisualStyleBackColor = true;
            this.btn_Deletar_Item.Click += new System.EventHandler(this.btn_Deletar_Item_Click);
            // 
            // btn_Abrir_Carteira
            // 
            this.btn_Abrir_Carteira.Location = new System.Drawing.Point(688, 338);
            this.btn_Abrir_Carteira.Name = "btn_Abrir_Carteira";
            this.btn_Abrir_Carteira.Size = new System.Drawing.Size(84, 46);
            this.btn_Abrir_Carteira.TabIndex = 7;
            this.btn_Abrir_Carteira.Text = "Carteira";
            this.btn_Abrir_Carteira.UseVisualStyleBackColor = true;
            this.btn_Abrir_Carteira.Click += new System.EventHandler(this.btn_Abrir_Carteira_Click);
            // 
            // btn_Show_Funcionalidade
            // 
            this.btn_Show_Funcionalidade.Location = new System.Drawing.Point(416, 338);
            this.btn_Show_Funcionalidade.Name = "btn_Show_Funcionalidade";
            this.btn_Show_Funcionalidade.Size = new System.Drawing.Size(266, 46);
            this.btn_Show_Funcionalidade.TabIndex = 8;
            this.btn_Show_Funcionalidade.Text = "Funcionalidades futura";
            this.btn_Show_Funcionalidade.UseVisualStyleBackColor = true;
            this.btn_Show_Funcionalidade.Click += new System.EventHandler(this.btn_Show_Funcionalidade_Click);
            // 
            // VisualizadorDeRenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 392);
            this.Controls.Add(this.btn_Show_Funcionalidade);
            this.Controls.Add(this.btn_Abrir_Carteira);
            this.Controls.Add(this.btn_Deletar_Item);
            this.Controls.Add(this.lbl_Title_Information);
            this.Controls.Add(this.lbl_Title_ListBox);
            this.Controls.Add(this.lbl_Information);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Add_New);
            this.Controls.Add(this.lsb_Saida);
            this.MaximizeBox = false;
            this.Name = "VisualizadorDeRenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Renda";
            this.Load += new System.EventHandler(this.VisualizadorDeRenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Saida;
        private System.Windows.Forms.Button btn_Add_New;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Information;
        private System.Windows.Forms.Label lbl_Title_ListBox;
        private System.Windows.Forms.Label lbl_Title_Information;
        private System.Windows.Forms.Button btn_Deletar_Item;
        private System.Windows.Forms.Button btn_Abrir_Carteira;
        private System.Windows.Forms.Button btn_Show_Funcionalidade;
    }
}

