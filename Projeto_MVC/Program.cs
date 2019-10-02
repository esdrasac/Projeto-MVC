using Projeto_MVC.Classes;
using System;

namespace Projeto_MVC {
    class Program {
        static void Main(string[] args) {
            Menu.Inicializar(new Operacoes(new Dados()));
        }
    }
}
