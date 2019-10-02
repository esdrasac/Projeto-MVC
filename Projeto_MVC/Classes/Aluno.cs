using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_MVC.Classes {
    public class Aluno {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }

        public Aluno() {
            Codigo = Guid.NewGuid().ToString().Substring(9,4).ToUpper();
        }
    }
}
