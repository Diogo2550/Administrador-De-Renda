using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_de_Renda.Entities {
    static class Carteira {
        static private string Proprietario;
        static private string RG;
        static private string CPF;
        static private float Saldo;

        public static void CriarNovaCarteira(string nomeDoProprietario) {
            Proprietario = nomeDoProprietario;
            RG = null;
            CPF = null;
            Saldo = 0;
        }

        public static void CriarNovaCarteira(string nomeDoProprietario, string rg, string cpf, float saldo) {
            Proprietario = nomeDoProprietario;
            RG = rg;
            CPF = cpf;
            Saldo = saldo;
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
    }
}
