using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Visualizador_de_Renda {
    static class Controle {
        public static CheckBox CriarCheckBox(int id, string text) {
            CheckBox checkBox = new CheckBox();
            checkBox.Size = new Size(30, 30);
            checkBox.Dock = DockStyle.Top;
            checkBox.Text = text;
            checkBox.Name = id.ToString();
            return checkBox;
        }

        public static string PegarTexto(Control control) {
            return control.Text;
        }

        public static void EditarTextoDoControle(Control control, string text) {
            control.Text = text;
        }

        public static void MostrarEsconderControl(Control control, bool esconder = false) {
            control.Visible = esconder ? false : true;
        }

        public static void ExpandirJanela(Form windowSize, int width, int height) {
            while(true) {
                if(windowSize.Width == width && windowSize.Height == height)
                    break;
                int plusHeight = 0;
                int plusWidth = 0;

                if(windowSize.Width > width) {
                    plusWidth = -1;
                } else if(windowSize.Width < width) {
                    plusWidth = 1;
                }

                if(windowSize.Height > height) {
                    plusHeight = -1;
                } else if(windowSize.Height < height) {
                    plusHeight = 1;
                }

                Size size = new Size(windowSize.Width + plusWidth, windowSize.Height + plusHeight);
                windowSize.Size = size;
            }
        }

        public static void MoverJanela(Control controlToMove, int X, int Y) {
            while(true) {
                if(controlToMove.Location.X == X && controlToMove.Location.Y == Y)
                    break;

                int x = 0;
                int y = 0;
                if(X > controlToMove.Location.X) x = 1;
                else if(X < controlToMove.Location.X) x = -1;
                if(Y > controlToMove.Location.Y) y = 1;
                else if(Y < controlToMove.Location.Y) y = -1;

                Point posicao = controlToMove.Location;
                posicao.X += x;
                posicao.Y += y;
                controlToMove.Location = posicao;
            }
        }
    }
}
