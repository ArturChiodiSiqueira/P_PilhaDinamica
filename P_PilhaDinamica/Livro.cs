using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_PilhaDinamica
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro()
        {
            Console.Write("Informe o título: ");
            Titulo = Console.ReadLine();

            Console.Write("Informe o ISBN: ");
            ISBN = int.Parse(Console.ReadLine());

            Console.Write("Informe o autor: ");
            Autor = Console.ReadLine();

            Anterior = null;
        }

        public override string ToString()
        {
            return "\nDados do livro:\nTitulo: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + ISBN;
        }
    }
}
