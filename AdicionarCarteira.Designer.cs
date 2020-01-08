namespace Visualizador_de_Renda {
    partial class AdicionarCarteira {
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
            this.txb_Nome_Proprietario = new System.Windows.Forms.TextBox();
            this.btn_Criar_Carteira = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(510, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Criar Carteira";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Nome_Proprietario
            // 
            this.txb_Nome_Proprietario.Location = new System.Drawing.Point(202, 35);
            this.txb_Nome_Proprietario.Name = "txb_Nome_Proprietario";
            this.txb_Nome_Proprietario.Size = new System.Drawing.Size(320, 27);
            this.txb_Nome_Proprietario.TabIndex = 1;
            // 
            // btn_Criar_Carteira
            // 
            this.btn_Criar_Carteira.Location = new System.Drawing.Point(16, 73);
            this.btn_Criar_Carteira.Name = "btn_Criar_Carteira";
            this.btn_Criar_Carteira.Size = new System.Drawing.Size(506, 32);
            this.btn_Criar_Carteira.TabIndex = 2;
            this.btn_Criar_Carteira.Text = "Criar";
            this.btn_Criar_Carteira.UseVisualStyleBackColor = true;
            this.btn_Criar_Carteira.Click += new System.EventHandler(this.btn_Criar_Carteira_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Proprietário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdicionarCarteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(534, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Criar_Carteira);
            this.Controls.Add(this.txb_Nome_Proprietario);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdicionarCarteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCarteira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txb_Nome_Proprietario;
        private System.Windows.Forms.Button btn_Criar_Carteira;
        private System.Windows.Forms.Label label1;
    }
}