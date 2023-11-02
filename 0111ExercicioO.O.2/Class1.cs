using System;

namespace _0111ExercicioO.O._2
{
    class Autor
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nome = value;
                else
                    Console.WriteLine("O nome do autor não pode ser vazio.");
            }
        }
    }

    class Livro
    {
        private string título;
        public string Título
        {
            get { return título; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    título = value;
                else
                    Console.WriteLine("O título do livro não pode ser vazio.");
            }
        }

        public Autor Autor { get; set; }
    }
}
