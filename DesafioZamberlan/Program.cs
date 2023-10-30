namespace _2_Padel;

using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> listaAtletas = new List<Atleta>();
            List<Treinador> listaTreinadores = new List<Treinador>();
            string opcao = "";
            do
            {
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar Atleta");
                Console.WriteLine("2 - Listar Atletas");
                Console.WriteLine("3 - Remover Atleta");
                Console.WriteLine("4 - Cadastrar Treinador");
                Console.WriteLine("5 - Listar Treinadores");
                Console.WriteLine("6 - Remover Treinador");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Atleta");
                        Comunicacao.cadastrarAtleta(listaAtletas);
                        break;
                    case "2":
                        Console.WriteLine("Listagem de Atletas");
                        Comunicacao.listarAtletas(listaAtletas);
                        break;
                    case "3":
                        Console.WriteLine("Remoção de Atleta");
                        // Chame o método para remover atletas aqui
                        break;
                    case "4":
                        Console.WriteLine("Cadastro de Treinador");
                        Comunicacao.cadastrarTreinador(listaTreinadores);
                        break;
                    case "5":
                        Console.WriteLine("Listagem de Treinadores");
                        Comunicacao.listarTreinadores(listaTreinadores);
                        break;
                    case "6":
                        Console.WriteLine("Remoção de Treinador");
                        // Chame o método para remover treinadores aqui
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "7");

            // Adicione uma pausa no final do programa
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }

