using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_PilhaDinamica
{
    internal class PilhaLivros
    {
        public Livro TOPO { get; set; }

        public PilhaLivros()
        {
            TOPO = null;
            Console.WriteLine("pilha criada com sucesso!");
        }
    }
}
