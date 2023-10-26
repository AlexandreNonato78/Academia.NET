namespace _2510ExercicioO.O._4
//4 - Crie uma classe Livro com os atributos título, autor e ano de publicação.
//Faça a instanciação de 3 objetos e imprima as informações do livro na tela.
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro
            {
                Titulo = "O Senhor dos Anéis: A Sociedade do Anel",
                Autor = "J.R.R. Tolkien",
                AnoPublicacao = 1954
            };

            Livro livro2 = new Livro
            {
                Titulo = "1984",
                Autor = "George Orwell",
                AnoPublicacao = 1949
            };

            Livro livro3 = new Livro
            {
                Titulo = "Dom Quixote",
                Autor = "Miguel de Cervantes",
                AnoPublicacao = 1605
            };

            Console.WriteLine("Informações dos Livros:");

            Console.WriteLine("Livro 1:");
            Console.WriteLine("Título: " + livro1.Titulo);
            Console.WriteLine("Autor: " + livro1.Autor);
            Console.WriteLine("Ano de Publicação: " + livro1.AnoPublicacao);

            Console.WriteLine("\nLivro 2:");
            Console.WriteLine("Título: " + livro2.Titulo);
            Console.WriteLine("Autor: " + livro2.Autor);
            Console.WriteLine("Ano de Publicação: " + livro2.AnoPublicacao);

            Console.WriteLine("\nLivro 3:");
            Console.WriteLine("Título: " + livro3.Titulo);
            Console.WriteLine("Autor: " + livro3.Autor);
            Console.WriteLine("Ano de Publicação: " + livro3.AnoPublicacao);
        }
    }

}