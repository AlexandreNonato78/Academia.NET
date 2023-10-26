namespace _2510ExercicioO.O._3
//3 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao.
//Além disso, na maincrie 2 objetos do tipo Carro e exibir na tela os valores dos atributos criados.
//Esses valores devem ser solicitados ao usuário, no programa.
{
    using System;    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do primeiro carro:");

            Carro primeiroCarro = new Carro(); // Instanciar o primeiro objeto da classe Carro

            Console.Write("Marca: ");
            primeiroCarro.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            primeiroCarro.Modelo = Console.ReadLine();

            Console.Write("Ano de fabricação: ");
            if (int.TryParse(Console.ReadLine(), out int anoFabricacao))
            {
                primeiroCarro.AnoFabricacao = anoFabricacao;
            }
            else
            {
                Console.WriteLine("Ano de fabricação inválido.");
            }

            Console.WriteLine("\nInforme os dados do segundo carro:");

            Carro segundoCarro = new Carro(); // Instanciar o segundo objeto da classe Carro

            Console.Write("Marca: ");
            segundoCarro.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            segundoCarro.Modelo = Console.ReadLine();

            Console.Write("Ano de fabricação: ");
            if (int.TryParse(Console.ReadLine(), out anoFabricacao))
            {
                segundoCarro.AnoFabricacao = anoFabricacao;
            }
            else
            {
                Console.WriteLine("Ano de fabricação inválido.");
            }

            Console.WriteLine("\nValores dos atributos dos carros:");

            Console.WriteLine("Primeiro Carro:");
            Console.WriteLine("Marca: " + primeiroCarro.Marca);
            Console.WriteLine("Modelo: " + primeiroCarro.Modelo);
            Console.WriteLine("Ano de Fabricação: " + primeiroCarro.AnoFabricacao);

            Console.WriteLine("\nSegundo Carro:");
            Console.WriteLine("Marca: " + segundoCarro.Marca);
            Console.WriteLine("Modelo: " + segundoCarro.Modelo);
            Console.WriteLine("Ano de Fabricação: " + segundoCarro.AnoFabricacao);
        }
    }

}