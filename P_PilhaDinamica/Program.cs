using System;

namespace P_PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivros minhaPilha = new PilhaLivros();

            Menu(minhaPilha);
        }
        static void Menu(PilhaLivros minhaPilha)
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tDENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?\n");
                Console.WriteLine("\t|°°°°°°°°°°°°°°°°°°°°°°  MENU  °°°°°°°°°°°°°°°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : sair                                     |");
                Console.WriteLine("\t|                                                      |");
                Console.WriteLine("\t|   opção 1 : inserir livro na pilha                   |");
                Console.WriteLine("\t|   opção 2 : remover livro da pilha                   |");
                Console.WriteLine("\t|   opção 3 : imprimir a pilha                         |");
                Console.WriteLine("\t|   opção 4 : imprimir a quantidade de livros da pilha |");
                Console.WriteLine("\t|   opção 5 : localizar um livro na pilha              |");
                Console.WriteLine("\t|______________________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();
                Console.Beep();

                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    switch (opcao)
                    {
                        case "0":
                            Console.WriteLine("\nVOCÊ ESCOLHEU SAIR.");
                            break;
                        case "1":
                            Console.Clear();
                            InserirLivro(minhaPilha);
                            break;

                        case "2":
                            Console.Clear();
                            RemoverLivro(minhaPilha);
                            break;

                        case "3":
                            Console.Clear();
                            ImprimirPilha(minhaPilha);
                            break;

                        case "4":
                            Console.Clear();
                            ImprimirQuantidadeLivro();
                            break;

                        case "5":
                            Console.Clear();
                            LocalizarLivro();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void InserirLivro(PilhaLivros minhaPilha)
        {
            Livro livro = new Livro();
            minhaPilha.Push(livro);
            Console.WriteLine("\nAperte qualquer coisa para voltar ao menu.");
            Console.ReadKey();
        }

        static void RemoverLivro(PilhaLivros minhaPilha)
        {
            minhaPilha.Pop();
            Console.WriteLine("\nAperte qualquer coisa para voltar ao menu.");
            Console.ReadKey();
        }

        static void ImprimirPilha(PilhaLivros minhaPilha)
        {
            minhaPilha.Print();
            Console.WriteLine("\nAperte qualquer coisa para voltar ao menu.");
            Console.ReadKey();
        }

        static void ImprimirQuantidadeLivro()
        {

        }

        static void LocalizarLivro()
        {

        }
    }
}

