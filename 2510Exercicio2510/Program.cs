namespace _2510Exercicio2510

//1 - Crie em c# uma classe "Jogo" com os seguintes atributos:
//Título, Gênero, Plataforma (por exemplo, PC, Xbox, PlayStation), Ano de lançamento.
//Na main, instancie um objeto e faça a leitura pelo teclado.
{
    using System;

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do jogo:");

            Jogo meuJogo = new Jogo(); // Instanciar um objeto da classe Jogo

            Console.Write("Título: ");
            meuJogo.Titulo = Console.ReadLine();

            Console.Write("Gênero: ");
            meuJogo.Genero = Console.ReadLine();

            Console.Write("Plataforma: ");
            meuJogo.Plataforma = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            if (int.TryParse(Console.ReadLine(), out int ano))
            {
                meuJogo.AnoLancamento = ano;
            }
            else
            {
                Console.WriteLine("Ano de lançamento inválido.");
            }

            Console.WriteLine("\nDados do jogo informados:");
            Console.WriteLine("Título: " + meuJogo.Titulo);
            Console.WriteLine("Gênero: " + meuJogo.Genero);
            Console.WriteLine("Plataforma: " + meuJogo.Plataforma);
            Console.WriteLine("Ano de lançamento: " + meuJogo.AnoLancamento);
        }
    }

}