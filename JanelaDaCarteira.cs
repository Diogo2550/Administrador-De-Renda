using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualizador_de_Renda.Entities;
using Visualizador_de_Renda.Entities.Administradores;
using Visualizador_de_Renda.Entities.Documentos;

namespace Visualizador_de_Renda {
    public partial class JanelaDaCarteira : Form {
        Size tamanhoPadraoDaJanela = new Size(800, 350);
        bool adicionandoMontante;

        public JanelaDaCarteira() {
            InitializeComponent();
        }

        private void JanelaDaCarteira_Load(object sender, EventArgs e) {
            this.Size = tamanhoPadraoDaJanela;
            UpdateInformation();
        }

        private async void btn_Adicionar_Dinheiro_Click(object sender, EventArgs e) {
            if(adicionandoMontante) {
                await Task.Run(() => ExpandirJanela(this.Width, 350));
                MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
                MostrarEsconderControl(btn_Adicionar_Montante, true);
                adicionandoMontante = false;
                return;
            }
            adicionandoMontante = true;
            MessageBox.Show("Adicionar dinheiro através deste botão irá dificultar na administração das contas!\nRecomendamos que só seja feito seu uso em caso de extrema necessidade");
            
            await Task.Run(() => ExpandirJanela(this.Width, 380));
            MostrarEsconderControl(txb_Adicionar_Dinheiro);
            MostrarEsconderControl(btn_Adicionar_Montante);
        }

        private async void btn_Editar_Carteira_Click(object sender, EventArgs e) {
            if(adicionandoMontante) {
                MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
                MostrarEsconderControl(btn_Adicionar_Montante, true);
                adicionandoMontante = false;
            }

            await Task.Run(() => ExpandirJanela(this.Width, 400));
            MostrarEsconderControl(panel_Editar_Carteira);
        }

        private async void btn_Cancelar_Click(object sender, EventArgs e) {
            await Task.Run(() => ExpandirJanela(this.Width, 350));
            MostrarEsconderControl(panel_Editar_Carteira, true);
        }

        private async void btn_Editar_Click(object sender, EventArgs e) {
            string proprietario = PegarTexto(txb_Proprietario);
            string rg = PegarTexto(txb_RG_Geral);
            string cpf = PegarTexto(txb_CPF_Geral);
            string numeroCTPS = PegarTexto(txb_Numero_CTPS);
            string serieCTPS = PegarTexto(txb_Serie_CTPS);
            string ufCTPS = PegarTexto(txb_UF_CTPS);
            string pisCTPS = PegarTexto(txb_PIS_CTPS);
            string numeroTitulo = PegarTexto(txb_Numero_Titulo);
            string zonaTitulo = PegarTexto(txb_Zona_Titulo);
            string sesaoTitulo = PegarTexto(txb_Sesao_Titulo);
            string municipioTitulo = PegarTexto(txb_Municipio_Titulo);
            string ufTitulo = PegarTexto(txb_UF_Titulo);
            string ra = PegarTexto(txb_RA_Editar);
            string sus = PegarTexto(txb_SUS_Editar);

            TituloDeEleitor titulo = new TituloDeEleitor(numeroTitulo, zonaTitulo, sesaoTitulo, municipioTitulo, ufTitulo);
            CTPS ctps = new CTPS(numeroCTPS, serieCTPS, ufCTPS, pisCTPS);

            Carteira.EditarCarteira(ra, sus, proprietario, rg, cpf, ctps, titulo);
            await Task.Run(() => MessageBox.Show("Editado com sucesso!"));
            await Task.Run(() => ExpandirJanela(this.Width, 350));
            MostrarEsconderControl(panel_Editar_Carteira, true);
            UpdateInformation();

            SaveLoad.Save();
        }

        private async void btn_Adicionar_Montante_Click(object sender, EventArgs e) {
            string montante = txb_Adicionar_Dinheiro.Text;
            if(!ChecarPreco(montante))
                return;
            Carteira.AdicionarDinheiro(float.Parse(montante));

            MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
            MostrarEsconderControl(btn_Adicionar_Montante, true);
            await Task.Run(() => ExpandirJanela(this.Width, 350));
            adicionandoMontante = false;

            SaveLoad.Save();
        }

        private void ExpandirJanela(int width, int height) {
            while(true) {
                if(this.Size.Width == width && this.Size.Height == height)
                    break;
                int plusHeight = 0;
                int plusWidth = 0;
                
                if(Size.Width > width) {
                    plusWidth = -1;
                } else if(Size.Width < width) {
                    plusWidth = 1;
                }

                if(Size.Height > height) {
                    plusHeight = -1;
                } else if(Size.Height < height) {
                    plusHeight = 1;
                }

                Size size = new Size(this.Width + plusWidth, this.Height + plusHeight);
                this.Size = size;
            }
        }

        private void MostrarEsconderControl(Control control, bool esconder = false) {
            control.Visible = esconder ? false : true;
        }

        private bool ChecarPreco(string preco) {
            try {
                float fPreco = float.Parse(preco);
            } catch {
                MessageBox.Show("Valor Inválido!");
                return false;
            }
            return true;
        }
    
        private void UpdateInformation() {
            EditarTextoDoLabel(lbl_Titular, "Titular: " + Carteira.PegarProprietario());
            EditarTextoDoLabel(lbl_RG, "RG: " + Carteira.PegarRG());
            EditarTextoDoLabel(lbl_CPF, "CPF: " + Carteira.PegarCPF());
            EditarTextoDoLabel(lbl_Data_De_Nascimento, "Data de Nascimento: " + "05/03/2001");
            EditarTextoDoLabel(lbl_Cartao_De_Credito, "Cartão de Crédito: " + "0000 0000 0000 0000");
            EditarTextoDoLabel(lbl_Filiacao, "Filiação: " + "Andrea Alves de Souza | Walter Augusto Da Cruz");
            EditarTextoDoLabel(lbl_Naturalidade, "Nacionalidade: " + "Brasileiro");
            EditarTextoDoLabel(lbl_CTPS, "CTPS: " + Carteira.CTPS.Numero);
            EditarTextoDoLabel(lbl_RA, "RA: " + Carteira.RA);
            EditarTextoDoLabel(lbl_Dinheiro_Na_Carteira, "R$" + Carteira.PegarSaldo().ToString("F2"));
        }

        private string PegarTexto(Control control) {
            return control.Text;
        }

        private void EditarTextoDoLabel(Label label, string text) {
            label.Text = text;
        }
    }
}
