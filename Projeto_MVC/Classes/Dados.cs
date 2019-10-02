using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projeto_MVC.Classes {
    class Dados {
        private ArrayList Cadastro;

        public Dados() {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(Aluno x) {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos() {
            return Cadastro;
        }

        public Aluno PesquisarAluno(string cod) {
            foreach(Aluno x in Cadastro) {
                if(x.Codigo == cod) {
                    return x;
                }
            }
            return null;

        }
        public void ExcluirAluno(Aluno x) {
            Cadastro.Remove(x);
        }

        public void AlterarAluno(Aluno x, Aluno y) {
            int posicao;
            posicao = Cadastro.IndexOf(x);
            Cadastro.Remove(x);
            Cadastro.Insert(posicao, y);
        }

        public void OrdenarAlunos() {
            Cadastro.Sort(new MinhaOrdenacao());
        }

        public void SalvarArquivo() {
            TextWriter MeuWriter = new StreamWriter(@"C:\GitHub\Exercícios POO\Projeto_MVC\Alunos.xml");
            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer Serializacao = new XmlSerializer(ListaAlunoVetor.GetType());
            Serializacao.Serialize(MeuWriter, ListaAlunoVetor);
            MeuWriter.Close();

        }

        public void CarregarArquivo() {
            FileStream Arquivo = new FileStream(@"C:\GitHub\Exercícios POO\Projeto_MVC\Alunos.xml", FileMode.Open);
            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer Serializacao = new XmlSerializer(ListaAlunoVetor.GetType());
            ListaAlunoVetor = (Aluno[])Serializacao.Deserialize(Arquivo);
            Cadastro.Clear();
            Cadastro.AddRange(ListaAlunoVetor);
            Arquivo.Close();

        }
    }
}
