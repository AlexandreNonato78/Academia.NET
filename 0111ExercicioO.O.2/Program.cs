//9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe).
//Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.
using System;

namespace _0111ExercicioO.O._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor();

            Console.WriteLine("===== Cadastro de Autor =====");
            do
            {
                Console.Write("Nome do Autor: ");
                autor.Nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(autor.Nome));

            Livro livro = new Livro();
            livro.Autor = autor;

            Console.WriteLine("\n===== Cadastro de Livro =====");
            do
            {
                Console.Write("Título do Livro: ");
                livro.Título = Console.ReadLine();
            } while (string.IsNullOrEmpty(livro.Título));

            Console.WriteLine("\n===== Informações do Livro =====");
            Console.WriteLine("Título do Livro: " + livro.Título);
            Console.WriteLine("Autor do Livro: " + livro.Autor.Nome);
        }
    }
}
