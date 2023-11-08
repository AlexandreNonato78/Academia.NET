//2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo.
//Criar um método abstrato chamado Dirigir. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
//A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada.
//Criar um método abstrato Dirigir na classe Veiculo. Em seguida, criar um método Dirigir na classe Carro
//que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e
//um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"

namespace _0611_O.O_Abstração2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informações do Carro:");
        Console.Write("Marca: ");
        string marcaCarro = Console.ReadLine();
        Console.Write("Modelo: ");
        string modeloCarro = Console.ReadLine();
        Console.Write("Quantidade de Portas: ");
        int quantidadeDePortas = int.Parse(Console.ReadLine());

        Carro carro = new Carro(marcaCarro, modeloCarro, quantidadeDePortas);

        Console.WriteLine("\nInformações da Moto:");
        Console.Write("Marca: ");
        string marcaMoto = Console.ReadLine();
        Console.Write("Modelo: ");
        string modeloMoto = Console.ReadLine();
        Console.Write("Cilindradas: ");
        int cilindradas = int.Parse(Console.ReadLine());

        Moto moto = new Moto(marcaMoto, modeloMoto, cilindradas);

        Console.WriteLine("\nIniciar a condução:");
        carro.Dirigir();
        moto.Dirigir();
    }
}
