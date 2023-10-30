namespace _2610ExercicioOrient.Obj._1;
//1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque.
//Implemente um construtor e métodos para adicionar e remover itens do estoque.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe os dados do Produto:");

        Produto meuProduto = new Produto(); // Instanciar um objeto da classe Estudio

        Console.Write("Nome do Produto: ");
        meuProduto.Nome = Console.ReadLine();

        Console.Write("Preço do Produto: ");
        if (double.TryParse(Console.ReadLine(), out double Preco))
        {
            meuProduto.Preco = Preco;
        }
        else
        {
            Console.WriteLine("Preço inválido.");
        }

        Console.Write("Quantidade em Estoque: ");
        if (int.TryParse(Console.ReadLine(), out int QuantidadeEstoque))
        {
            meuProduto.QuantidadeEstoque = QuantidadeEstoque;
        }
        else
        {
            Console.WriteLine("Estoque inválido.");
        }

        Console.WriteLine("\nDados de produtos informados:");
        Console.WriteLine("Nome do Produto: " + meuProduto.Nome);
        Console.WriteLine("Preço do Produto: R$ " + meuProduto.Preco);
        Console.WriteLine("Quantidade em Estoque: " + meuProduto.QuantidadeEstoque + " unidades");            
        
    }

}