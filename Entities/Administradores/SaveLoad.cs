using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Visualizador_de_Renda.Entities.Administradores {
    static class SaveLoad {
        public static void Save() {
            DadosImportantes d = new DadosImportantes();
            d.Proprietario = Carteira.PegarProprietario();
            d.RG = Carteira.PegarRG();
            d.CPF = Carteira.PegarCPF();
            d.Saldo = Carteira.PegarSaldo();
            d.ListaDeItemsComprados = AdministradorDeGastos.PegarTodosOsRecibos();
            d.IDAtual = AdministradorDeGastos.IDAtual;
            d.RA = Carteira.RA;
            d.ctps = Carteira.CTPS;
            d.tituloDeEleitor = Carteira.TituloDeEleitor;
            d.SUS = Carteira.SUS;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Data\\carteira.bin", FileMode.Create);
            
            try {
                binaryFormatter.Serialize(stream, d);
            } catch(SerializationException e) {
                MessageBox.Show(e.Message);
            } finally {
                stream.Close();
            }

        }

        public static void Load() {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\..\\Data\\carteira.bin", FileMode.Open);

            DadosImportantes d = (DadosImportantes)binaryFormatter.Deserialize(stream);
            AdministradorDeGastos.CarregarListaExistente(d.IDAtual, d.ListaDeItemsComprados);
            Carteira.CriarNovaCarteira(d.Proprietario, d.RG, d.CPF, d.Saldo, d.RA, d.SUS, d.ctps, d.tituloDeEleitor);
            stream.Close();
        }
    }
}
