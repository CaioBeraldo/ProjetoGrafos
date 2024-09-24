using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrafos
{
    internal class ClasseGrafo
    {
        private int[,] matrizGrafo;

        public ClasseGrafo(int V)
        {
            MatrizGrafo = new int[V,V];
        }

        public int[,] MatrizGrafo { get => matrizGrafo; set => matrizGrafo = value; }

        public String Multigrafo()
        {
            string aux = "";
            ///

            return aux;
        }
    }
}
