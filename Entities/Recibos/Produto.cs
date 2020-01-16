using System;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities {
    [Serializable]
    class Produto : Recibo {
        public int Quantidade { get; private set; }
        public float Preco { get; private set; }
        public Importancia Importancia { get; private set; }
        public string Lembrete { get; private set; }

        public Produto(string name, int quantity, float price, DateTime dateTime, Importancia importancia, Tipo tipo) : base(name, dateTime, tipo) {
            Quantidade = quantity;
            Preco = price;
            Importancia = importancia;
            Lembrete = "Lembrete não informado";

            base.Total = Preco * quantity;
        }

        public Produto(string name, int quantity, float price, DateTime dateTime, Importancia importancia, Tipo tipo, string lembrete) : base(name, dateTime, tipo) {
            Quantidade = quantity;
            Preco = price;
            Importancia = importancia;
            Lembrete = lembrete;

            base.Total = Preco * quantity;
        }

        public override string ImprimirInformacao() {
            string informacao = "Nome: " + Nome + "\n"
                                + "Quantidade: " + Quantidade + " unidade(s)" + "\n"
                                + "Preço: R$" + Preco.ToString("F2") + "\n"
                                + "Valor Total: R$" + Total.ToString("F2") + "\n"
                                + "Data da Compra: " + DataDaCompra.ToString("dd/MM/yyyy") + "\n"
                                + "Importancia: " + Importancia.ToString() + "\n"
                                + "Lembrete: " + Lembrete + "\n"
                                + "Tipo: " + Tipo;
            return informacao;
        }

        public void DesejoRealizado() {
            Tipo = Tipo.CompraDeProduto;
        }

    }
}
