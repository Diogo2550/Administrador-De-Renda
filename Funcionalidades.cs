using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_Renda {
    public partial class Funcionalidades : Form {
        public Funcionalidades() {
            InitializeComponent();
        }

        private void Funcionalidades_Load(object sender, EventArgs e) {
            lbl_Log.Text = "Lista de novas funcionalidades\n"
                + "1 - Adionar lista de desejos que ao marcar, deverar entrar para a lista principal\n"
                + "2 - Adicionar sistema de log in, só porque sim\n"
                + "3 - A janela de editar carteira deverá aparecer \"Aprovado\" de verde ou \"Reprovado\" de vermelho durante o preenchimento\n"
                + "4 - Consertar a janela da carteira para mostrar TODOS os dados\n"
                + "Obs: As funcionalidades não chegaram na ordem listada.";
        }
    }
}
