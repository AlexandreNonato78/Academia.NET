//10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade.
//Crie também um método chamado EmitirSom, que imprime na tela o som do animal.

using System;

namespace _0111ExercicioO.O._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine("===== Cadastro de Animal =====");
            do
            {
                Console.Write("Nome do Animal: ");
                animal.Nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(animal.Nome));

            do
            {
                Console.Write("Espécie do Animal: ");
                animal.Espécie = Console.ReadLine();
            } while (string.IsNullOrEmpty(animal.Espécie));

            Console.Write("Idade do Animal: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                animal.Idade = idade;
            }
            else
            {
                Console.WriteLine("Idade inválida.");
                return;
            }

            Console.WriteLine("Som emitido pelo Animal: ");
            string som = Console.ReadLine();
            animal.EmitirSom(som);

            Console.WriteLine("\n===== Informações do Animal =====");
            Console.WriteLine("Nome do Animal: " + animal.Nome);
            Console.WriteLine("Espécie do Animal: " + animal.Espécie);
            Console.WriteLine("Idade do Animal: " + animal.Idade);
        }
    }
}
