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

namespace Visualizador_de_Renda {
    public partial class VisualizadorDeRenda : Form {
        string itemSelecionadoNome;
        int itemSelecionadoID;

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
            window.ShowDialog();

            UpdateListBox();
            SaveLoad.Save();
        }

        private void btn_Deletar_Item_Click(object sender, EventArgs e) {
            if(itemSelecionadoNome == "") {
                MessageBox.Show("Item não selecionado!");
                return;
            }

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
            Funcionalidades janelaDeFuncionalidades = new Funcionalidades();
            janelaDeFuncionalidades.ShowDialog();
        }

        private void UpdateListBox() {
            lsb_Saida.Items.Clear();
            List<Recibo> produtos = AdministradorDeGastos.PegarTodosOsRecibos();

            produtos.ForEach(x => { lsb_Saida.Items.Add(x.ID.ToString() + " - " + x.Nome); });

            if(lsb_Saida.Items.Count > 0)
                lsb_Saida.SelectedIndex = 0;
        }

        private void lsb_Saida_SelectedIndexChanged(object sender, EventArgs e) {
            if(lsb_Saida.SelectedIndex == -1)
                return;

            itemSelecionadoID = int.Parse(lsb_Saida.SelectedItem.ToString().Split(' ')[0]);
            Recibo recibo = AdministradorDeGastos.PegarReciboPelaID(itemSelecionadoID);
            lbl_Information.Text = recibo.ImprimirInformacao();
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
