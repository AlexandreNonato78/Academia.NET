//8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.
//Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco.
//Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 

using System;

namespace ExercicioFabricanteProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();

            Console.WriteLine("===== Cadastro de Fabricante =====");
            do
            {
                Console.Write("Nome do Fabricante: ");
                fabricante.Nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(fabricante.Nome));

            Console.Write("Endereço do Fabricante: ");
            fabricante.Endereço = Console.ReadLine();
            Console.Write("Cidade do Fabricante: ");
            fabricante.Cidade = Console.ReadLine();

            Produto produto = new Produto();
            produto.Fabricante = fabricante;

            Console.WriteLine("\n===== Cadastro de Produto =====");
            do
            {
                Console.Write("Nome do Produto: ");
                produto.Nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(produto.Nome));

            Console.Write("Preço do Produto: ");
            if (double.TryParse(Console.ReadLine(), out double preço))
            {
                produto.Preço = preço;
            }
            else
            {
                Console.WriteLine("Preço inválido.");
                return;
            }

            Console.WriteLine("\n===== Informações do Produto =====");
            Console.WriteLine("Nome do Produto: " + produto.Nome);
            Console.WriteLine("Preço do Produto: R$ " + produto.Preço);
            Console.WriteLine("Fabricante: " + produto.Fabricante.Nome);
            Console.WriteLine("Endereço do Fabricante: " + produto.Fabricante.Endereço);
            Console.WriteLine("Cidade do Fabricante: " + produto.Fabricante.Cidade);
        }
    }
}

