using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Documentos;

namespace Visualizador_de_Renda.Entities {
    [Serializable]
    class DadosImportantes {
        public string Proprietario;
        public string RG;
        public string CPF;
        public string RA;
        public string SUS;
        public string Endereco;
        public string CEP;
        public string Telefone;
        public string EstadoCivil;
        public string Naturalidade;
        public string Mae;
        public string Pai;
        public float Saldo;
        public List<Recibo> ListaDeItemsComprados = new List<Recibo>();
        public List<Recibo> ListaDeDesejos = new List<Recibo>();
        public int IDAtual;

        public CTPS ctps;
        public TituloDeEleitor tituloDeEleitor;
        public CartaoDeCredito cartaoDeCredito;
    }
}
