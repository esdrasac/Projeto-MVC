using Projeto_MVC.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Projeto_MVC {
    class MinhaOrdenacao:IComparer {
        int IComparer.Compare(object x, object y) {
            return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
        }
    }
}
