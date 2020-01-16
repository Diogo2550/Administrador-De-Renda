using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualizador_de_Renda.Entities.Administradores;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities {
    public partial class AdicionarProduto : Form {
        public static bool isDesejo;

        private Tipo tipo;
        private string lembreteDefault = "Caso necessário, informe um lembrete desejado";
        private string errorMessage = "Algum dos campos está incorreto";

        public AdicionarProduto() {
            InitializeComponent();
        }

        private void AdicionarProduto_Load(object sender, EventArgs e) {
            IniciarComboBox();
            txb_Lembrete.Text = lembreteDefault;
            num_Quantidade.GotFocus += num_Quantidade_GotFocus;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e) {
            LimparTextBox(txb_Nome);
            LimparTextBox(txb_Preco);
            num_Quantidade.Value = 1;
            cbb_Importancia.SelectedIndex = 0;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e) {
            if(CamposDevidamentePreenchidos()) {
                string nome = txb_Nome.Text;
                int quantidade = (int)num_Quantidade.Value;
                string valAux = txb_Preco.Text.Replace('.', ',');
                float preco = float.Parse(valAux);
                Importancia importancia = (Importancia)cbb_Importancia.SelectedItem;
                Tipo tipo = (Tipo)cbb_Tipo.SelectedItem;
                string lembrete = txb_Lembrete.Text;
                DateTime dateTime = DateTime.Now;

                Recibo recibo;

                if(tipo == Tipo.CompraDeProduto || tipo == Tipo.Desejo) {
                    if(lembrete == lembreteDefault || lembrete == "")
                        recibo = new Produto(nome, quantidade, preco, DateTime.Now, importancia, tipo);
                    else
                        recibo = new Produto(nome, quantidade, preco, DateTime.Now, importancia, tipo, lembrete);
                } else if(tipo == Tipo.Conta) {
                    recibo = new Conta(nome, preco, dateTime, tipo);
                } else {
                    recibo = new Salario(preco, dateTime, tipo);
                }

                if(cbb_Tipo.SelectedItem.ToString() == Tipo.Desejo.ToString())
                    AdministradorDeGastos.AdicionarRecibo(recibo, TipoDeLista.ListaDeDesejo);
                else
                    AdministradorDeGastos.AdicionarRecibo(recibo);

                Close();
            } else {
                MessageBox.Show(errorMessage);
            }
        }

        private void cbb_Tipo_SelectedIndexChanged(object sender, EventArgs e) {
            string item = cbb_Tipo.SelectedItem.ToString();
            if(item == Tipo.Salario.ToString() || item == Tipo.Conta.ToString()) {
                num_Quantidade.Enabled = false;
                cbb_Importancia.Enabled = false;
                txb_Lembrete.Enabled = false;
                if(item == Tipo.Salario.ToString())
                    txb_Nome.Enabled = false;
                else
                    txb_Nome.Enabled = true;
            } else {
                num_Quantidade.Enabled = true;
                cbb_Importancia.Enabled = true;
                txb_Lembrete.Enabled = true;
            }

            tipo = (Tipo)cbb_Tipo.SelectedItem;
        }

        private void IniciarComboBox() {
            cbb_Importancia.Items.Clear();
            AdicionarItemAComboBox(cbb_Importancia, Importancia.Baixa);
            AdicionarItemAComboBox(cbb_Importancia, Importancia.Media);
            AdicionarItemAComboBox(cbb_Importancia, Importancia.Alta);
            AdicionarItemAComboBox(cbb_Importancia, Importancia.Extrema);
            cbb_Importancia.SelectedIndex = 0;

            cbb_Tipo.Items.Clear(); 
            AdicionarItemAComboBox(cbb_Tipo, Tipo.CompraDeProduto);
            AdicionarItemAComboBox(cbb_Tipo, Tipo.Salario);
            AdicionarItemAComboBox(cbb_Tipo, Tipo.Conta);
            AdicionarItemAComboBox(cbb_Tipo, Tipo.Desejo);
            AdicionarItemAComboBox(cbb_Tipo, Tipo.Outro);

            if(isDesejo) {
                cbb_Tipo.SelectedIndex = 3;
                txb_Nome.Select();
            } else {
                cbb_Tipo.SelectedIndex = 0;
            }
        }

        private bool CamposDevidamentePreenchidos() {
            bool nome = txb_Nome.Text != "";
            bool preco = txb_Preco.Text != "";
            bool aprovadoNaPrimeiraEtapa = false;

            if(tipo == Tipo.Outro) {
                errorMessage = "Campo de \"Outros\" ainda está indisponível no momento...\nPor favor, aguarde novas atualizações";
            } else if(tipo == Tipo.Salario) {
                aprovadoNaPrimeiraEtapa = preco ? true : false;
            } else {
                aprovadoNaPrimeiraEtapa = (nome && preco) ? true : false;
            }

            if(aprovadoNaPrimeiraEtapa && ChecarPreco()) {
                return true;
            }
            return false;
        }

        private bool ChecarPreco() {
            string preco = txb_Preco.Text;
            try {
                float fPreco = float.Parse(preco);
            } catch {
                return false;
            }
            return true;
        }

        private void num_Quantidade_GotFocus(object sender, EventArgs e) {
            num_Quantidade.Select(0, num_Quantidade.Value.ToString().Length);
        }

        private void AdicionarItemAComboBox(ComboBox comboBox, object item) {
            comboBox.Items.Add(item);
        }

        private void LimparTextBox(TextBox textBox) {
            textBox.Text = "";
        }

        private void txb_Lembrete_Enter(object sender, EventArgs e) {
            txb_Lembrete.SelectAll();
        }
    
    }
}
