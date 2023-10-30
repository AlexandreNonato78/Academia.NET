//7 - Utilize o exercício 1 para criar uma lista de produtos e
//faça métodos para apresentar na tela e para consultar produtos pelo código.
using System;
using System.Collections.Generic;

namespace _2610ExercicioOrient.Obj._7

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProdutos = new List<Produto>();

            while (true)
            {
                Console.WriteLine("===== Menu da Lista de Produtos =====");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Apresentar Produtos");
                Console.WriteLine("3 - Consultar Produto por Código");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Código do Produto: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.Write("Nome do Produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Preço do Produto: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Quantidade em Estoque: ");
                        int quantidadeEstoque = int.Parse(Console.ReadLine());

                        Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEstoque);
                        listaProdutos.Add(novoProduto);
                        Console.WriteLine("Produto adicionado com sucesso.");
                        break;

                    case 2:
                        Console.WriteLine("Lista de Produtos:");
                        foreach (Produto produto in listaProdutos)
                        {
                            Console.WriteLine("Código: " + produto.Codigo);
                            Console.WriteLine("Nome: " + produto.Nome);
                            Console.WriteLine("Preço: R$ " + produto.Preco);
                            Console.WriteLine("Quantidade em Estoque: " + produto.QuantidadeEstoque + " unidades");
                            Console.WriteLine("==============================");
                        }
                        break;

                    case 3:
                        Console.Write("Digite o Código do Produto a ser consultado: ");
                        int codigoConsulta = int.Parse(Console.ReadLine());
                        Produto produtoConsultado = listaProdutos.Find(p => p.Codigo == codigoConsulta);

                        if (produtoConsultado != null)
                        {
                            Console.WriteLine("Produto encontrado:");
                            Console.WriteLine("Código: " + produtoConsultado.Codigo);
                            Console.WriteLine("Nome: " + produtoConsultado.Nome);
                            Console.WriteLine("Preço: R$ " + produtoConsultado.Preco);
                            Console.WriteLine("Quantidade em Estoque: " + produtoConsultado.QuantidadeEstoque + " unidades");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saindo do programa.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
