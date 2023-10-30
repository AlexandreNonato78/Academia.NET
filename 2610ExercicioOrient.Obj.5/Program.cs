using System;
//5 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
//Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e
//uma string para armazenar o dono da playlist. Implemente um método para adicionar músicas na lista,
//para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música).
//Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista,
//faça um random para acessar valores aleatórios válidos.

namespace _2610ExercicioOrient.Obj._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist("Seu Nome");

            while (true)
            {
                Console.WriteLine("===== Menu da Playlist de Músicas =====");
                Console.WriteLine("1 - Adicionar Música");
                Console.WriteLine("2 - Tocar Música Aleatória");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Nome da Música: ");
                        string nomeMúsica = Console.ReadLine();
                        Console.Write("Autor da Música: ");
                        string autorMúsica = Console.ReadLine();
                        Console.Write("Gravadora da Música: ");
                        string gravadoraMúsica = Console.ReadLine();

                        Música novaMúsica = new Música(nomeMúsica, autorMúsica, gravadoraMúsica);
                        playlist.AdicionarMúsica(novaMúsica);
                        Console.WriteLine("Música adicionada com sucesso.");
                        break;

                    case 2:
                        playlist.TocarMúsicaAleatória();
                        break;

                    case 3:
                        Console.WriteLine("Saindo da Playlist de Músicas.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
