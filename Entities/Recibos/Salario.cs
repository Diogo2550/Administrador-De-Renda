using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities {
    [Serializable]
    class Salario : Recibo {
        public Salario(float total, DateTime dateTime, Tipo tipo) {
            base.Nome = "Salario";
            base.Total = total;
            base.DataDaCompra = dateTime;
            base.Tipo = tipo;
        }

        public override string ImprimirInformacao() {
            string informacao = "Nome: " + Nome + "\n"
                                + "Valor: R$" + Total.ToString("F2") + "\n"
                                + "Data do recebimento: " + DataDaCompra.ToString("dd/MM/yyyy") + "\n"
                                + "Tipo: " + Tipo;
            return informacao;
        }
    }
}
