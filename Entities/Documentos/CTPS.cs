using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_de_Renda.Entities.Documentos {
    [Serializable]
    class CTPS {
        public string Numero { get; set; }
        public string Serie { get; set; }
        public string UF { get; set; }
        public string PIS { get; set; }

        public CTPS() {

        }

        public CTPS(string numero, string serie, string uF, string pIS) {
            Numero = numero;
            Serie = serie;
            UF = uF;
            PIS = pIS;
        }

    }
}
