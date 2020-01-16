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
using Visualizador_de_Renda.Entities.Administradores;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda {
    public partial class VisualizadorDeRenda : Form {
        string itemSelecionadoNome;
        int itemSelecionadoID;
        List<CheckBox> desejosArray;

        public VisualizadorDeRenda() {
            InitializeComponent();
        }

        private void VisualizadorDeRenda_Load(object sender, EventArgs e) {
            try {
                SaveLoad.Load();
            } catch {
                if(Carteira.PegarProprietario() == null) {
                    MessageBox.Show("Parece que é sua primeira vez aqui...\nVamos redirecioná-lo para que possa criar uma nova carteira");
                    AdicionarCarteira janelaDeAdicionarCarteira = new AdicionarCarteira();
                    janelaDeAdicionarCarteira.ShowDialog();
                    if(Carteira.PegarProprietario() == null)
                        Close();
                }
            }
            
            lsb_Saida.DrawMode = DrawMode.OwnerDrawFixed;
            UpdateListBox();
        }

        private void btn_Add_New_Click(object sender, EventArgs e) {
            AdicionarProduto window = new AdicionarProduto();
            AdicionarProduto.isDesejo = false;
            window.ShowDialog();

            UpdateListBox();
            SaveLoad.Save();
        }

        private void btn_Deletar_Item_Click(object sender, EventArgs e) {
            if(itemSelecionadoNome == "") {
                MessageBox.Show("Item não selecionado!");
                return;
            }

            if(MessageBox.Show("Tem certeza que deseja excluir o registro " + itemSelecionadoNome + "?", "DESEJA CONCLUIR A OPERAÇÃO?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                return;

            AdministradorDeGastos.RemoverReciboPelaID(itemSelecionadoID);
            MessageBox.Show("Item removido com sucesso!");
            UpdateListBox();

            SaveLoad.Save();
        }

        private void btn_Abrir_Carteira_Click(object sender, EventArgs e) {
            JanelaDaCarteira janelaDaCarteira = new JanelaDaCarteira();
            janelaDaCarteira.ShowDialog();
        }

        private void btn_Show_Funcionalidade_Click(object sender, EventArgs e) {
            AdministradorDeGastos.AdicionarRecibo(new Produto("Comida", 2, 2.90f, DateTime.Now, Importancia.Baixa, Tipo.CompraDeProduto), TipoDeLista.ListaDeDesejo);
            Funcionalidades janelaDeFuncionalidades = new Funcionalidades();
            janelaDeFuncionalidades.ShowDialog();
        }

        private async void btn_Lista_De_Desejos_Click(object sender, EventArgs e) {
            UpdateDesejosCheckBox();

            await Task.Run(() => Controle.MoverJanela(panel_Lista_De_Desejos, 399, panel_Lista_De_Desejos.Location.Y));
        }

        private async void btn_Fechar_Panel_Desejos_Click(object sender, EventArgs e) {
            await Task.Run(() => Controle.MoverJanela(panel_Lista_De_Desejos, 785, panel_Lista_De_Desejos.Location.Y));
        }

        private void btn_Adicionar_Desejo_Click(object sender, EventArgs e) {
            AdicionarProduto newWindow = new AdicionarProduto();
            AdicionarProduto.isDesejo = true;
            newWindow.ShowDialog();
            UpdateDesejosCheckBox();

            SaveLoad.Save();
        }

        private void btn_Excluir_Desejo_Click(object sender, EventArgs e) {
            desejosArray.ForEach(x => {
                if(x.Checked) {
                    AdministradorDeGastos.RemoverReciboPelaID(int.Parse(x.Name), TipoDeLista.ListaDeDesejo);
                }
            });
            UpdateDesejosCheckBox();

            SaveLoad.Save();
        }

        private void btn_Realizar_Desejos_Click(object sender, EventArgs e) {
            desejosArray.ForEach(x => {
                if(x.Checked) {
                    Produto produto = (Produto)AdministradorDeGastos.PegarReciboPelaID(int.Parse(x.Name), TipoDeLista.ListaDeDesejo);
                    produto.DesejoRealizado();
                    AdministradorDeGastos.AdicionarRecibo(produto);
                    AdministradorDeGastos.RemoverReciboPelaID(int.Parse(x.Name), TipoDeLista.ListaDeDesejo);
                }
            });
            UpdateDesejosCheckBox();
            UpdateListBox();

            SaveLoad.Save();
        }

        private void lsb_Saida_SelectedIndexChanged(object sender, EventArgs e) {
            if(lsb_Saida.SelectedIndex == -1)
                return;

            itemSelecionadoID = int.Parse(lsb_Saida.SelectedItem.ToString().Split(' ')[0]);
            Recibo recibo = AdministradorDeGastos.PegarReciboPelaID(itemSelecionadoID);
            lbl_Information.Text = recibo.ImprimirInformacao();
        }

        private void UpdateListBox() {
            lsb_Saida.Items.Clear();
            List<Recibo> produtos = AdministradorDeGastos.PegarTodosOsRecibos();

            produtos.ForEach(x => { lsb_Saida.Items.Add(x.ID.ToString() + " - " + x.Nome); });

            if(lsb_Saida.Items.Count > 0)
                lsb_Saida.SelectedIndex = 0;
        }

        private void UpdateDesejosCheckBox() {
            panel_Desejos.Controls.Clear();
            List<Recibo> desejos = AdministradorDeGastos.PegarTodosOsRecibos(TipoDeLista.ListaDeDesejo);

            desejosArray = new List<CheckBox>();
            desejos.ForEach(x => {
                desejosArray.Add(Controle.CriarCheckBox(x.ID, x.Nome + "    " + x.Total.ToString("F2")));
            });

            desejosArray.Reverse();

            desejosArray.ForEach(x => {
                panel_Desejos.Controls.Add(x);
            });
        }

        private void lsb_Saida_DrawItem(object sender, DrawItemEventArgs e) {
            SolidBrush foregroundBrushSelected = new SolidBrush(Color.White);
            SolidBrush foregroundBrushDeselected = new SolidBrush(Color.Black);
            SolidBrush backgroundBrushSelected = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));
            SolidBrush backgroundBrushSalary = new SolidBrush(Color.Green);
            SolidBrush backgroundBrushLose = new SolidBrush(Color.IndianRed);
            SolidBrush backgroundBrushConta = new SolidBrush(Color.Red);
            SolidBrush backgroundBrushNothing = new SolidBrush(Color.White);

            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;

            if(index >= 0 && index < lsb_Saida.Items.Count) {
                string text = lsb_Saida.Items[index].ToString();
                int id = int.Parse(lsb_Saida.Items[index].ToString().Split(' ')[0]);
                Graphics g = e.Graphics;

                //background:
                SolidBrush backgroundBrush = backgroundBrushNothing;
                if(selected)
                    backgroundBrush = backgroundBrushSelected;
                else if(AdministradorDeGastos.PegarReciboPelaID(id).Tipo == Entities.Enums.Tipo.Salario)
                    backgroundBrush = backgroundBrushSalary;
                else if(AdministradorDeGastos.PegarReciboPelaID(id).Tipo == Entities.Enums.Tipo.CompraDeProduto)
                    backgroundBrush = backgroundBrushLose;
                else if(AdministradorDeGastos.PegarReciboPelaID(id).Tipo == Entities.Enums.Tipo.Conta)
                    backgroundBrush = backgroundBrushConta;
                g.FillRectangle(backgroundBrush, e.Bounds);

                //text:
                SolidBrush foregroundBrush = (selected) ? foregroundBrushSelected : foregroundBrushDeselected;
                g.DrawString(text, e.Font, foregroundBrush, lsb_Saida.GetItemRectangle(index).Location);
            }
        }

    }
}
