using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Visualizador_de_Renda.Entities.Administradores;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities {
    [Serializable]
    abstract class Recibo {
        public int ID;
        public string Nome { get; protected set; }
        public float Total { get; protected set; }
        public DateTime DataDaCompra { get; protected set; }
        public Tipo Tipo { get; protected set; }
        
        public Recibo() {
            ID = AdministradorDeGastos.PegarIDAtual();
        }

        public Recibo(string nome, DateTime dataDaCompra, Tipo tipo) {
            ID = AdministradorDeGastos.PegarIDAtual();
            Nome = nome;
            DataDaCompra = dataDaCompra;
            Tipo = tipo;
        }

        public virtual string ImprimirInformacao() { return null; }

    }
}
