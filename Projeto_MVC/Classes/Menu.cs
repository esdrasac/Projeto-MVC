using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projeto_MVC.Classes {
    static class Menu {
        public static void Inicializar(Operacoes MyOp) {
            int Op;
            do {
                Console.Clear();
                Console.WriteLine("     Sistema de Cadastro de Alunos");
                Console.WriteLine("=======================================\n");
                Console.WriteLine("     1. Inserir");
                Console.WriteLine("     2. Alterar");
                Console.WriteLine("     3. Excluir");
                Console.WriteLine("     4. Pesquisar");
                Console.WriteLine("     5. Listar");
                Console.WriteLine("     6. Ordenar");
                Console.WriteLine("     7. Salvar dados em Arquivo");
                Console.WriteLine("     8. Ler dados em Arquivo");
                Console.WriteLine("     9. Sair");
                Console.Write("\nOpção: ");
                Op = int.Parse(Console.ReadLine());
                switch(Op) {
                    case 1:
                        MyOp.Inserir();
                        break;
                    case 2:
                        MyOp.Alterar();
                        break;
                    case 3:
                        MyOp.Excluir();
                        break;
                    case 4:
                        MyOp.Pesquisar();
                        break;
                    case 5:
                        MyOp.Listar();
                        break;
                    case 6:
                        MyOp.Ordenar();
                        break;
                    case 7:
                        MyOp.Salvar();
                        break;
                    case 8:
                        MyOp.Carregar();
                        break;
                    case 9:
                        Console.WriteLine("\nSaindo...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Thread.Sleep(2000);
                        break;
                }
            } while(Op != 9);
        }
    }
}
