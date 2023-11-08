//3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()".
//Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo".
//Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes,
//de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.
using System;
namespace _0611_O.O_Abstração3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as informações do Retângulo:");
        Console.Write("Largura: ");
        double largura = double.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Retangulo retangulo = new Retangulo(largura, altura);

        Console.WriteLine("\nDigite as informações do Círculo:");
        Console.Write("Raio: ");
        double raio = double.Parse(Console.ReadLine());

        Circulo circulo = new Circulo(raio);

        Console.WriteLine("\nÁrea e Perímetro do Retângulo:");
        Console.WriteLine($"Área: {retangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro()}");

        Console.WriteLine("\nÁrea e Perímetro do Círculo:");
        Console.WriteLine($"Área: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");
    }
}