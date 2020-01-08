using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualizador_de_Renda.Entities.Enums;

namespace Visualizador_de_Renda.Entities.Administradores {
    static class AdministradorDeGastos {
        public static int IDAtual { get; private set; }
        private static List<Recibo> ListaDeItemsComprados = new List<Recibo>();

        public static void CarregarListaExistente(int idAtual, List<Recibo> listaExistente) {
            IDAtual = idAtual;
            ListaDeItemsComprados = listaExistente;
        }
        public static void AdicionarRecibo(Recibo novoProduto) {
            ListaDeItemsComprados.Add(novoProduto);
        }

        public static List<Recibo> PegarTodosOsRecibos() {
            return ListaDeItemsComprados;
        }

        public static List<Recibo> PegarReciboPorTipo(Tipo tipo) {
            return ListaDeItemsComprados.FindAll(x => x.Tipo == tipo);
        }

        public static void RemoverReciboPeloNome(string nome) {
            ListaDeItemsComprados.Remove(PegarReciboPeloNome(nome));
        }

        public static void RemoverReciboPelaID(int id) {
            ListaDeItemsComprados.Remove(PegarReciboPelaID(id));
        }

        public static Recibo PegarReciboPeloNome(string nome) {
            return ListaDeItemsComprados.Find(x => x.Nome == nome);
        }

        public static Recibo PegarReciboPelaID(int id) {
            return ListaDeItemsComprados.Find(x => x.ID == id);
        }

        public static int PegarIDAtual() {
            if(ListaDeItemsComprados.Count == 0)
                IDAtual = 1;
            return IDAtual++;
        }

    }
}
