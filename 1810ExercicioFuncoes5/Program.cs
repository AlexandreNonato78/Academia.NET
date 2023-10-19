namespace _1810ExercicioFuncoes5
    //5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = ConverterCelsiusParaFahrenheit(celsius);
                Console.WriteLine($"{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico válido.");
            }
        }

        static double ConverterCelsiusParaFahrenheit(double celsius)
        {
            // Fórmula de conversão de Celsius para Fahrenheit
            return (celsius * 9 / 5) + 32;
        }
    }
}