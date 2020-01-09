using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Documentos;

namespace Visualizador_de_Renda.Entities {
    static class Carteira {
        static public string RA { get; private set; }
        static public string SUS { get; private set; }
        static private string Proprietario;
        static private string RG;
        static private string CPF;
        static private float Saldo;

        static public CTPS CTPS { get; private set; }
        static public TituloDeEleitor TituloDeEleitor { get; private set; }

        public static void CriarNovaCarteira(string nomeDoProprietario) {
            Proprietario = nomeDoProprietario;
            RG = null;
            CPF = null;
            Saldo = 0;

            CTPS = new CTPS();
            TituloDeEleitor = new TituloDeEleitor();
        }

        public static void CriarNovaCarteira(string nomeDoProprietario, string rg, string cpf, float saldo, string ra, string sus, CTPS ctps, TituloDeEleitor tituloDeEleitor) {
            Proprietario = nomeDoProprietario;
            RG = rg;
            CPF = cpf;
            Saldo = saldo;
            CTPS = ctps;
            TituloDeEleitor = tituloDeEleitor;
        }

        public static string PegarProprietario() {
            return Proprietario;
        }

        public static string PegarRG() {
            return RG;
        }

        public static string PegarCPF() {
            return CPF;
        }

        public static float PegarSaldo() {
            return Saldo;
        }
    
        public static void AdicionarDinheiro(float montante) {
            Saldo += montante;
        }

        public static void EditarCarteira(string ra, string sus, string proprietario, string rg, string cpf, CTPS ctps, TituloDeEleitor titulo) {
            Proprietario = proprietario;
            RG = rg;
            CPF = cpf;
            CTPS = ctps;
            TituloDeEleitor = titulo;
            RA = ra;
            SUS = sus;
        }

    }
}
