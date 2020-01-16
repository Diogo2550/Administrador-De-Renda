using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Documentos;

namespace Visualizador_de_Renda.Entities {
    static class Carteira {
        static public string Endereco { get; private set; }
        static public string CEP { get; private set; }
        static public string Telefone { get; private set; }
        static public string EstadoCivil { get; private set; }
        static public string Naturalidade { get; private set; }
        static public string Mae { get; private set; }
        static public string Pai { get; private set; }
        static public string RA { get; private set; }
        static public string SUS { get; private set; }
        static private string Proprietario;
        static private string RG;
        static private string CPF;
        static private float SaldoTotal;

        static public CTPS CTPS { get; private set; }
        static public TituloDeEleitor TituloDeEleitor { get; private set; }
        static public CartaoDeCredito CartaoDeCredito { get; private set; }

        public static void CriarNovaCarteira(string nomeDoProprietario) {
            Proprietario = nomeDoProprietario;
            RG = null;
            CPF = null;
            SaldoTotal = 0;

            CTPS = new CTPS();
            TituloDeEleitor = new TituloDeEleitor();
            CartaoDeCredito = new CartaoDeCredito();
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
            float saldo = SaldoTotal;

            List<Recibo> recibos = Administradores.AdministradorDeGastos.PegarTodosOsRecibos();
            recibos.ForEach(x => {
                if(x.Tipo == Enums.Tipo.Salario)
                    saldo += x.Total;
                else
                    saldo -= x.Total;
            });

            return saldo;
        }
    
        public static void AdicionarDinheiro(float montante) {
            SaldoTotal += montante;
        }

        public static void EditarCarteira(string proprietario, string rg, string cpf, string endereco, string cep, string telefone, string estadoCivil, string naturalidade, string mae, string pai, string ra, string sus, CTPS ctps, TituloDeEleitor titulo, CartaoDeCredito cartaoDeCredito) {
            Proprietario = proprietario;
            RG = rg;
            CPF = cpf;
            Endereco = endereco;
            CEP = cep;
            Telefone = telefone;
            EstadoCivil = estadoCivil;
            Naturalidade = naturalidade;
            Mae = mae;
            Pai = pai; 
            RA = ra;
            SUS = sus;
            CTPS = ctps;
            TituloDeEleitor = titulo;
            CartaoDeCredito = cartaoDeCredito;
        }

    }
}
