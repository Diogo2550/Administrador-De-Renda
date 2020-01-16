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
            panel_Editar_Carteira.Location = new Point(0, 0);
            panel_Info.Location = new Point(0, -panel_Info.Height);
            UpdateInformation();
        }

        private async void btn_Adicionar_Dinheiro_Click(object sender, EventArgs e) {
            if(adicionandoMontante) {
                await Task.Run(() => Controle.ExpandirJanela(this, this.Width, 350));
                Controle.MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
                Controle.MostrarEsconderControl(btn_Adicionar_Montante, true);
                adicionandoMontante = false;
                return;
            }
            adicionandoMontante = true;
            MessageBox.Show("Adicionar dinheiro através deste botão irá dificultar na administração das contas!\nRecomendamos que só seja feito seu uso em caso de extrema necessidade");

            await Task.Run(() => Controle.ExpandirJanela(this, this.Width, 380));
            Controle.MostrarEsconderControl(txb_Adicionar_Dinheiro);
            Controle.MostrarEsconderControl(btn_Adicionar_Montante);
        }

        private async void btn_Editar_Carteira_Click(object sender, EventArgs e) {
            if(adicionandoMontante) {
                Controle.MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
                Controle.MostrarEsconderControl(btn_Adicionar_Montante, true);
                adicionandoMontante = false;
            }

            Controle.EditarTextoDoControle(txb_Proprietario, Carteira.PegarProprietario());
            Controle.EditarTextoDoControle(txb_RG_Geral, Carteira.PegarRG());
            Controle.EditarTextoDoControle(txb_CPF_Geral, Carteira.PegarCPF());
            Controle.EditarTextoDoControle(txb_RA_Geral, Carteira.RA);
            Controle.EditarTextoDoControle(txb_SUS_Geral, Carteira.SUS);
            Controle.EditarTextoDoControle(txb_Numero_CTPS, Carteira.CTPS.Numero);
            Controle.EditarTextoDoControle(txb_Serie_CTPS, Carteira.CTPS.Serie);
            Controle.EditarTextoDoControle(txb_UF_CTPS, Carteira.CTPS.UF);
            Controle.EditarTextoDoControle(txb_PIS_CTPS, Carteira.CTPS.PIS);
            Controle.EditarTextoDoControle(txb_Numero_Titulo, Carteira.TituloDeEleitor.Numero);
            Controle.EditarTextoDoControle(txb_Zona_Titulo, Carteira.TituloDeEleitor.Zona);
            Controle.EditarTextoDoControle(txb_Sesao_Titulo, Carteira.TituloDeEleitor.Sesao);
            Controle.EditarTextoDoControle(txb_Municipio_Titulo, Carteira.TituloDeEleitor.Municipio);
            Controle.EditarTextoDoControle(txb_UF_Titulo, Carteira.TituloDeEleitor.UF);
            Controle.EditarTextoDoControle(txb_Endereco_Geral, Carteira.Endereco);
            Controle.EditarTextoDoControle(txb_CEP_Geral, Carteira.CEP);
            Controle.EditarTextoDoControle(txb_Telefone_Geral, Carteira.Telefone);
            Controle.EditarTextoDoControle(txb_Estado_Civil_Geral, Carteira.EstadoCivil);
            Controle.EditarTextoDoControle(txb_Naturalidade_Geral, Carteira.Naturalidade);
            Controle.EditarTextoDoControle(txb_Mae_Geral, Carteira.Mae);
            Controle.EditarTextoDoControle(txb_Pai_Geral, Carteira.Pai);
            Controle.EditarTextoDoControle(txb_Cartao_Agencia, Carteira.CartaoDeCredito.Agencia);
            Controle.EditarTextoDoControle(txb_Cartao_Conta_Corrente, Carteira.CartaoDeCredito.ContaCorrente);
            Controle.EditarTextoDoControle(txb_Cartao_Numero, Carteira.CartaoDeCredito.Numero);
            Controle.EditarTextoDoControle(txb_Cartao_Validade, Carteira.CartaoDeCredito.Validade);

            await Task.Run(() => Controle.ExpandirJanela(this, this.Width, panel_Editar_Carteira.Height));
            Controle.MostrarEsconderControl(panel_Editar_Carteira);
        }

        private async void btn_Cancelar_Click(object sender, EventArgs e) {
            await Task.Run(() => Controle.ExpandirJanela(this, this.Width, 350));
            Controle.MostrarEsconderControl(panel_Editar_Carteira, true);
        }

        private async void btn_Editar_Click(object sender, EventArgs e) {
            string proprietario = Controle.PegarTexto(txb_Proprietario);
            string rg = Controle.PegarTexto(txb_RG_Geral);
            string cpf = Controle.PegarTexto(txb_CPF_Geral);
            string numeroCTPS = Controle.PegarTexto(txb_Numero_CTPS);
            string serieCTPS = Controle.PegarTexto(txb_Serie_CTPS);
            string ufCTPS = Controle.PegarTexto(txb_UF_CTPS);
            string pisCTPS = Controle.PegarTexto(txb_PIS_CTPS);
            string numeroTitulo = Controle.PegarTexto(txb_Numero_Titulo);
            string zonaTitulo = Controle.PegarTexto(txb_Zona_Titulo);
            string sesaoTitulo = Controle.PegarTexto(txb_Sesao_Titulo);
            string municipioTitulo = Controle.PegarTexto(txb_Municipio_Titulo);
            string ufTitulo = Controle.PegarTexto(txb_UF_Titulo);
            string ra = Controle.PegarTexto(txb_RA_Geral);
            string sus = Controle.PegarTexto(txb_SUS_Geral);
            string endereco = Controle.PegarTexto(txb_Endereco_Geral);
            string cep = Controle.PegarTexto(txb_CEP_Geral);
            string telefone = Controle.PegarTexto(txb_Telefone_Geral);
            string estadoCivil = Controle.PegarTexto(txb_Estado_Civil_Geral);
            string naturalidade = Controle.PegarTexto(txb_Naturalidade_Geral);
            string mae = Controle.PegarTexto(txb_Mae_Geral);
            string pai = Controle.PegarTexto(txb_Pai_Geral);
            string numeroCartao = Controle.PegarTexto(txb_Cartao_Numero);
            string agenciaCartao = Controle.PegarTexto(txb_Cartao_Agencia);
            string validadeCartao = Controle.PegarTexto(txb_Cartao_Validade);
            string contaCartao = Controle.PegarTexto(txb_Cartao_Conta_Corrente);

            TituloDeEleitor titulo = new TituloDeEleitor(numeroTitulo, zonaTitulo, sesaoTitulo, municipioTitulo, ufTitulo);
            CTPS ctps = new CTPS(numeroCTPS, serieCTPS, ufCTPS, pisCTPS);
            CartaoDeCredito cartaoDeCredito = new CartaoDeCredito(numeroCartao, agenciaCartao, contaCartao, validadeCartao);

            Carteira.EditarCarteira(proprietario, rg, cpf, endereco, cep, telefone, estadoCivil, naturalidade, mae, pai, ra, sus, ctps, titulo, cartaoDeCredito);
            Task x = Task.Run(() => MessageBox.Show("Editado com sucesso!"));
            await Task.Run(() => Controle.ExpandirJanela(this, this.Width, 350));
            Controle.MostrarEsconderControl(panel_Editar_Carteira, true);
            UpdateInformation();

            SaveLoad.Save();
        }

        private async void btn_Adicionar_Montante_Click(object sender, EventArgs e) {
            string montante = txb_Adicionar_Dinheiro.Text;
            if(!ChecarPreco(montante))
                return;
            Carteira.AdicionarDinheiro(float.Parse(montante));

            Controle.MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
            Controle.MostrarEsconderControl(btn_Adicionar_Montante, true);
            await Task.Run(() => Controle.ExpandirJanela(this, this.Width, 350));
            adicionandoMontante = false;

            SaveLoad.Save();
        }

        private async void btn_Mostrar_Info_Click(object sender, EventArgs e) {
            if(adicionandoMontante) {
                Controle.MostrarEsconderControl(txb_Adicionar_Dinheiro, true);
                Controle.MostrarEsconderControl(btn_Adicionar_Montante, true);
                adicionandoMontante = false;
            }
            
            // Variavel declarada só para tirar o aviso do compilador
            var x = Task.Run(() => Controle.ExpandirJanela(this, Width, panel_Info.Height));
            await Task.Run(() => Controle.MoverJanela(panel_Info, 0, 0));
        }

        private async void btn_Info_Voltar_Click(object sender, EventArgs e) {
            await Task.Run(() => Controle.ExpandirJanela(this, tamanhoPadraoDaJanela.Width, tamanhoPadraoDaJanela.Height));
            await Task.Run(() => Controle.MoverJanela(panel_Info, 0, -panel_Info.Height));
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
            Controle.EditarTextoDoControle(lbl_Titular, "Titular: " + Carteira.PegarProprietario());
            Controle.EditarTextoDoControle(lbl_RG, "RG: " + Carteira.PegarRG());
            Controle.EditarTextoDoControle(lbl_CPF, "CPF: " + Carteira.PegarCPF());
            Controle.EditarTextoDoControle(lbl_Data_De_Nascimento, "Data de Nascimento: " + "05/03/2001");
            Controle.EditarTextoDoControle(lbl_Filiacao, "Filiação: " + "Andrea Alves de Souza | Walter Augusto Da Cruz");
            Controle.EditarTextoDoControle(lbl_Naturalidade, "Nacionalidade: " + "Brasileiro");
            Controle.EditarTextoDoControle(lbl_CTPS, "CTPS: " + Carteira.CTPS.Numero);
            Controle.EditarTextoDoControle(lbl_RA, "RA: " + Carteira.RA);
            Controle.EditarTextoDoControle(lbl_Dinheiro_Na_Carteira, "R$" + Carteira.PegarSaldo().ToString("F2"));
        }

    }
}
