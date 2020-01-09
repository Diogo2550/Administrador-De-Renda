using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_de_Renda.Entities.Documentos {
    [Serializable]
    class TituloDeEleitor {
        public string Numero { get; set; }
        public string Zona { get; set; }
        public string Sesao { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }

        public TituloDeEleitor() {

        }

        public TituloDeEleitor(string numero, string zona, string sesao, string municipio, string uF) {
            Numero = numero;
            Zona = zona;
            Sesao = sesao;
            Municipio = municipio;
            UF = uF;
        }

    }
}
