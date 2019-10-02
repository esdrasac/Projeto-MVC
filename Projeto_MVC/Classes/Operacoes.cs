using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projeto_MVC.Classes {
    class Operacoes {
        private Dados MeusDados;

        public Operacoes(Dados D) {
            MeusDados = new Dados();
        }

        public void Inserir() {
            Aluno MyAluno;
            do {
                MyAluno = new Aluno();
                Console.Clear();
                Console.WriteLine("          Cadastro de Alunos");
                Console.WriteLine("=======================================\n");
                Console.WriteLine($"Código.....: {MyAluno.Codigo}");
                Console.Write("Nome.......: ");
                MyAluno.Nome = Console.ReadLine();
                Console.Write("Telefone...: ");
                MyAluno.Telefone = Console.ReadLine();
                Console.Write("E-mail.....: ");
                MyAluno.Mail = Console.ReadLine();
                MeusDados.InserirAluno(MyAluno);
                Console.WriteLine("\nNovo Registro? (Esc - Cancelar)");
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public void Listar() {
            ArrayList Lista;
            Console.Clear();
            Console.WriteLine("Listagem de alunos cadastrados");
            Console.WriteLine("=======================================");
            Lista = MeusDados.ListarAlunos();
            foreach(Aluno x in Lista) {
                Console.WriteLine($"Nome do Aluno: {x.Nome} ({x.Codigo})");
                Console.WriteLine($"Telefone: {x.Telefone}");
                Console.WriteLine($"Email: {x.Mail}\n");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void Pesquisar() {
            Aluno MyAluno;
            string codPesq;
            Console.Clear();
            Console.WriteLine("Pesquisar Alunos");
            Console.WriteLine("=======================================");
            Console.Write("Código do aluno: ");
            codPesq = Console.ReadLine().ToUpper();
            MyAluno = MeusDados.PesquisarAluno(codPesq);
            if(MyAluno != null) {
                Console.WriteLine($"Nome do Aluno: {MyAluno.Nome} ({MyAluno.Codigo})");
                Console.WriteLine($"Telefone: {MyAluno.Telefone}");
                Console.WriteLine($"Email: {MyAluno.Mail}\n");
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Aluno não cadastrado");
                Thread.Sleep(2000);
            }
            Console.ReadKey();
        }

        public void Excluir() {
            Aluno MyAluno;
            string codPesq;
            Console.Clear();
            Console.WriteLine("Excluir Aluno");
            Console.WriteLine("=======================================");
            Console.Write("Código do aluno: ");
            codPesq = Console.ReadLine().ToUpper();
            MyAluno = MeusDados.PesquisarAluno(codPesq);
            if(MyAluno != null) {
                Console.WriteLine($"Nome do Aluno: {MyAluno.Nome} ({MyAluno.Codigo})");
                Console.WriteLine($"Telefone: {MyAluno.Telefone}");
                Console.WriteLine($"Email: {MyAluno.Mail}\n");
                MeusDados.ExcluirAluno(MyAluno);
                Console.WriteLine("\nAluno excluido do cadastro");
                Thread.Sleep(2000);
            }
            else {
                Console.WriteLine("Aluno não cadastrado");
                Thread.Sleep(2000);
            }
            Console.ReadKey();
        }

        public void Alterar() {
            Aluno MyAluno;
            Aluno MyAlunoChanged = new Aluno();
            string codPesq;
            Console.Clear();
            Console.WriteLine("Alterar cadastro");
            Console.WriteLine("=======================================");
            Console.Write("Código do aluno: ");
            codPesq = Console.ReadLine().ToUpper();
            MyAluno = MeusDados.PesquisarAluno(codPesq);
            if(MyAluno != null) {
                Console.WriteLine($"Nome do Aluno: {MyAluno.Nome} ({MyAluno.Codigo})");
                Console.WriteLine($"Telefone: {MyAluno.Telefone}");
                Console.WriteLine($"Email: {MyAluno.Mail}\n");
                Console.WriteLine("\nDados de Atualização: \n");
                MyAlunoChanged.Codigo = MyAluno.Codigo;
                Console.Write("Nome.......: ");
                MyAlunoChanged.Nome = Console.ReadLine();
                Console.Write("Telefone...: ");
                MyAlunoChanged.Telefone = Console.ReadLine();
                Console.Write("E-mail.....: ");
                MyAlunoChanged.Mail = Console.ReadLine();

                MeusDados.AlterarAluno(MyAluno, MyAlunoChanged);
                Console.WriteLine("Dados Atualizados!");
                Thread.Sleep(2000);


            }
            else {
                Console.WriteLine("Aluno não cadastrado");
                Thread.Sleep(2000);
            }
            Console.ReadKey();
        }

        public void Ordenar() {
            Console.Clear();
            Console.WriteLine("Ordenação de registro do cadastro de alunos");
            Console.WriteLine("===========================================");
            MeusDados.OrdenarAlunos();
            Console.WriteLine("\nArquivo Ordenado com sucesso");
            Thread.Sleep(2000);
        }

        public void Salvar() {
            Console.Clear();
            Console.WriteLine("Salvar Cadastro em Arquivo XML");
            Console.WriteLine("==============================");

            MeusDados.SalvarArquivo();

            Console.WriteLine("\nArquivo XML gerado com sucesso!");
            Thread.Sleep(200);
        }

        public void Carregar() {
            Console.Clear();
            Console.WriteLine("Carregar Arquivo XML");
            Console.WriteLine("====================");

            MeusDados.CarregarArquivo();

            Console.WriteLine("\nArquivo XML carregado com sucesso!");
            Thread.Sleep(200);
        }
    }
}
