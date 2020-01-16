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
        private static List<Recibo> ListaDeDesejos = new List<Recibo>();

        public static void CarregarListaExistente(int idAtual, List<Recibo> listaExistente, List<Recibo> listaDeDesejos) {
            IDAtual = idAtual;
            ListaDeItemsComprados = listaExistente;
            ListaDeDesejos = listaDeDesejos;
        }

        public static void AdicionarRecibo(Recibo novoProduto, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                ListaDeDesejos.Add(novoProduto);
            else
                ListaDeItemsComprados.Add(novoProduto);
        }

        public static List<Recibo> PegarTodosOsRecibos(TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                return ListaDeDesejos;
            return ListaDeItemsComprados;
        }

        public static List<Recibo> PegarReciboPorTipo(Tipo tipo, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                return ListaDeDesejos.FindAll(x => x.Tipo == tipo);
            return ListaDeItemsComprados.FindAll(x => x.Tipo == tipo);
        }

        public static void RemoverReciboPeloNome(string nome, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                ListaDeDesejos.Remove(PegarReciboPeloNome(nome, TipoDeLista.ListaDeDesejo));
            else
                ListaDeItemsComprados.Remove(PegarReciboPeloNome(nome));
        }

        public static void RemoverReciboPelaID(int id, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                ListaDeDesejos.Remove(PegarReciboPelaID(id, TipoDeLista.ListaDeDesejo));
            else
                ListaDeItemsComprados.Remove(PegarReciboPelaID(id));
        }

        public static Recibo PegarReciboPeloNome(string nome, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                return ListaDeDesejos.Find(x => x.Nome == nome);
            return ListaDeItemsComprados.Find(x => x.Nome == nome);
        }

        public static Recibo PegarReciboPelaID(int id, TipoDeLista tipoDeLista = TipoDeLista.ListaDeItemsComprados) {
            if(tipoDeLista == TipoDeLista.ListaDeDesejo)
                return ListaDeDesejos.Find(x => x.ID == id);
            return ListaDeItemsComprados.Find(x => x.ID == id);
        }

        public static int PegarIDAtual() {
            if(ListaDeItemsComprados.Count == 0)
                IDAtual = 1;
            return IDAtual++;
        }

    }
}
