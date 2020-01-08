using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualizador_de_Renda.Entities;

namespace Visualizador_de_Renda {
    public partial class AdicionarCarteira : Form {
        public AdicionarCarteira() {
            InitializeComponent();
        }

        private void btn_Criar_Carteira_Click(object sender, EventArgs e) {
            Carteira.CriarNovaCarteira(txb_Nome_Proprietario.Text);
            Close();
        }
    }
}
