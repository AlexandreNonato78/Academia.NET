namespace _2610ExercicioO.O._4
{
    namespace Aula2610
    {
        internal class Program
        {        
            /** Crie uma classe Livro que represente os dados básicos de um livro, além destes,
             * * criar um atributo do tipo boolean chamado emprestado.
             * - Crie métodos emprestar e devolver que altera o atributo emprestado
             * - Crie um método construtor que receba todos os valores por parâmetros, exceto o
             * atributo emprestado que obrigatoriamente deve ser inicializado como false
             * - Faça a leitura pelo teclado dos atributos para instanciar dois livros */
            static void Main(string[] args)
            {
                Console.WriteLine("Olá, sejam bem vindos ao sistema da biblioteca!");
                List<Livro> listaLivros = new List<Livro>();
                    for (int i = 0; i < 3; i++)
                {
                    // para adicionar um livro, eu preciso de 1 autor
                    Console.WriteLine("Digite o autor do livro: ");
                    string autorNome = Console.ReadLine();
                    Console.WriteLine("Digite a nacionalidade do autor: ");
                    string nacionalidadeAutor = Console.ReadLine();
                    Autor a = new Autor(autorNome, nacionalidadeAutor);
                    agora que temos o autor, podemos instanciar um livro
                    Console.WriteLine("Digite um titulo do livro: ");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Digite o ano da publicação no formato DD/MM/AAAA"); string anoPub = Console.ReadLine(); Console.WriteLine("Digite a editora do livro: "); string editora = Console.ReadLine(); Livro l = new Livro(titulo, a, anoPub, editora);                /* l.ExibirInformacoes();                 l.Emprestar();                 l.Emprestar();                 l.ExibirInformacoes();                 l.Devolver();                 l.Devolver();                 l.ExibirInformacoes();*/                    listaLivros.Add(l);
                }
                for (int i = 0; i < listaLivros.Count; i++) { Console.WriteLine("Livro: " + listaLivros[i].titulo); Console.WriteLine("Autor: " + listaLivros[i].autor.nome); }
                foreach (Livro livro in listaLivros) { Console.WriteLine("Livro: " + livro.titulo); Console.WriteLine("Autor: " + livro.autor.nome); }
            }
        }
    }
}