namespace _051023ExercicioRepetição2;
//2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles.Não usar vetor.
class Program
{
    static void Main()
    {
        int maiorNumero = int.MinValue; // Inicializamos com o menor valor possível

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o número " + i + ": ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Console.WriteLine("O maior número é: " + maiorNumero);
    }
}