//5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto".
//Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto"
//de acordo com as regras específicas de desconto para cada tipo de produto.
//Livro – 5% de desconto
//Eletrônico  - 12.5% de desconto # os dados deve ser inseridos pelo usuário

namespace _0611_O.O_Abstração5;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        decimal precoProduto = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Selecione o tipo de produto:");
        Console.WriteLine("1 - Livro");
        Console.WriteLine("2 - Eletrônico");
        int escolha = int.Parse(Console.ReadLine());

        Produto produto;

        if (escolha == 1)
        {
            produto = new Livro(nomeProduto, precoProduto);
        }
        else if (escolha == 2)
        {
            produto = new Eletronico(nomeProduto, precoProduto);
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        decimal desconto = produto.CalcularDesconto();

        Console.WriteLine($"Nome do produto: {produto.Nome}");
        Console.WriteLine($"Preço do produto: {produto.Preco:C}");
        Console.WriteLine($"Desconto aplicado: {desconto:C}");
        Console.WriteLine($"Preço com desconto: {produto.Preco - desconto:C}");
    }
}
