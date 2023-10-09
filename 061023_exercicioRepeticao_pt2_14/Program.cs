namespace _061023_exercicioRepeticao_pt2_14;
    //14. Mostrar as potências de 2 variando de 0 a 10.
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            double resultado = Math.Pow(2, i);
            Console.WriteLine($"2^{i} = {resultado}");
        }
    }
}
