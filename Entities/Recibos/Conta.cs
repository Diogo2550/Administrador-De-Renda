using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities {
    [Serializable]
    class Conta : Recibo {
        public Conta(string nome, float total, DateTime dateTime, Tipo tipo) : base(nome, dateTime, tipo) {
            base.Total = total;
        }

        public override string ImprimirInformacao() {
            string informacao = "Nome: " + Nome + "\n"
                                + "Valor: " + Total + "\n"
                                + "Data do pagamento: " + DataDaCompra.ToString("dd/MM/yyyy") + "\n"
                                + "Tipo: " + Tipo;
            return informacao;
        }
    }
}
