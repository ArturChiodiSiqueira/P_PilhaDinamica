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
            Console.WriteLine("Pilha criada com sucesso!\n");
        }

        public void Push(Livro aux)//para inserir
        {
            if (Vazia())
                TOPO = aux;
            else
            {
                aux.Anterior = TOPO;
                TOPO = aux;
            }
        }

        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                Livro aux = TOPO;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;

                } while (aux != null);
                Console.WriteLine("\nFIM DA IMPRESSÃO!");
            }
        }

        public void Pop()//para remover
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia! Impossivel remover");
            else
            {
                TOPO = TOPO.Anterior;
            }
        }

        private bool Vazia()
        {
            if (TOPO == null)
                return true;
            else
                return false;
        }
    }
}
