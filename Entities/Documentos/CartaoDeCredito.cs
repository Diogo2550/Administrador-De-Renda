using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_de_Renda.Entities.Documentos {
    [Serializable]
    class CartaoDeCredito {
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public string ContaCorrente { get; private set; }
        public string Validade { get; private set; }

        public CartaoDeCredito() {

        }

        public CartaoDeCredito(string numero, string agencia, string contaCorrente, string validade) {
            Numero = numero;
            Agencia = agencia;
            ContaCorrente = contaCorrente;
            Validade = validade;
        }

    }
}
