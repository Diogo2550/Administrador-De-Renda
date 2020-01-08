using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_de_Renda.Entities {
    class Account {
        public string NomeCompleto { get; private set; }
        public string NomeDeUsuario { get; private set; }
        public string Senha { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string CartaoDeCredito { get; private set; }
        public string Endereco { get; private set; }
        public string NumeroDeTelefone { get; private set; }
        public string Email { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public float DinheiroTotal { get; private set; }
        
        public Account(string fullname, string username, string password) {
            NomeCompleto = fullname;
            NomeDeUsuario = username;
            Senha = password;
        }
    }
}
