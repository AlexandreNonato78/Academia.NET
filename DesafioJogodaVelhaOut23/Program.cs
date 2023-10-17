namespace DesafioJogodaVelhaOut23

{
using System;
    using System.Diagnostics.Metrics;
    using System.Runtime.Intrinsics.X86;

    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Faça com que cada jogador insira a sua jogada em uma interface amigavel.
            //2) Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada.
            //3) Após cada jogada, apresente o tabuleiro com as jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
            //4) Caso seja empate, apresente o resultado na tela.
            //5) Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o programa.

            Console.WriteLine("Bem-vindo ao Jogo da Velha!"); //Apresentação do jogo
            Console.WriteLine();
            Console.Write("Digite o nome do Jogador 1: "); 
            string jogador1 = Console.ReadLine();
            Console.Write("Digite o nome do Jogador 2: ");
            string jogador2 = Console.ReadLine();

            bool jogarNovamente = true; //Essa variável será usada para controlar se os jogadores desejam jogar novamente após o término de uma partida.

            while (jogarNovamente) //Este é um loop principal que permite que os jogadores joguem novamente após o término de uma partida.
            {
                bool fimDeJogo = false; //A variável é inicializada como falsa no início e será usada para determinar quando o jogo atual terminou.
                int jogadas = 0; // é usada para contar as jogadas realizadas durante o jogo. Isso ajuda a alternar entre os jogadores (Jogador 1 e Jogador 2).
                string[,] tabuleiro = new string[3, 3]; //representa o tabuleiro do jogo, sendo que cada elemento da matriz armazenará uma jogada (X, O ou espaço vazio).
                bool jogadaValida; //verifica se a jogada feita por um jogador é válida.

                while (!fimDeJogo)
                {
                    Console.Clear();
                    DesenharTabuleiro(tabuleiro);

                    if (jogadas % 2 == 0)
                    {
                        Console.WriteLine($"{jogador1}, é sua vez (X)");
                    }
                    else
                    {
                        Console.WriteLine($"{jogador2}, é sua vez (O)");
                    }

                    jogadaValida = false;

                    while (!jogadaValida)
                    {
                        Console.Write("Digite a linha (1 a 3): ");
                        int linha = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Digite a coluna (1 a 3): ");
                        int coluna = int.Parse(Console.ReadLine()) - 1;

                        if (tabuleiro[linha, coluna] == null)
                        {
                            if (jogadas % 2 == 0)
                            {
                                tabuleiro[linha, coluna] = "X";
                            }
                            else
                            {
                                tabuleiro[linha, coluna] = "O";
                            }

                            jogadaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Jogada inválida. Tente novamente.");
                        }
                    }
                    //Verifica se um dos jogadores venceu o jogo. Se a função retornar verdadeiro, há um vencedor. 
                    if (VerificarGanhador(tabuleiro, jogadas)) 
                    {
                        fimDeJogo = true;
                        Console.Clear();
                        DesenharTabuleiro(tabuleiro);

                        if (jogadas % 2 == 0)
                        {
                            Console.WriteLine($"{jogador1} ganhou!");
                        }
                        else
                        {
                            Console.WriteLine($"{jogador2} ganhou!");
                        }
                    }
                    //Empate! Verifica se o número de jogadas é 8. Se isso acontecer,
                    //todas as células do tabuleiro foram preenchidas sem vencedor.
                    else if (jogadas == 8)  
                    {
                        fimDeJogo = true;
                        Console.Clear();
                        DesenharTabuleiro(tabuleiro);
                        Console.WriteLine("Empate!"); //Apresentando o resultado de empate na tela.
                    }
                    jogadas++;
                }
                Console.WriteLine();
                Console.Write("Deseja jogar novamente? (S/N) "); // Opção de reiniciar o jogo,
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S") // Reiniciando o jogo sem a necessidade de reiniciar o programa!
                {
                    jogarNovamente = false;
                }
            }

            static void DesenharTabuleiro(string[,] tabuleiro) //Formatação do Tabuleiro
            {
                Console.Clear();
                Console.WriteLine("    1   2   3 ");
                Console.WriteLine("  +---+---+---+");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{i + 1} ");

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"| {tabuleiro[i, j] ?? " "} ");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("  +---+---+---+");
                }
            }

            static bool VerificarGanhador(string[,] tabuleiro, int jogadas)
            {
                string jogador;

                if (jogadas % 2 == 0)
                {
                    jogador = "X";
                }
                else
                {
                    jogador = "O";
                }

                // Verifica linhas. O loop for percorre as 3 linhas do tabuleiro (variável i usada como contador).
                //verifica se as 3 células em cada linha têm o símbolo do jogador atual.
                // i representa a linha que está sendo verificada.
                for (int i = 0; i < 3; i++) 
                {
                    if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador) 
                    {
                        return true;
                    }
                }
                // Verifica colunas. O loop for percorre as 3 colunas do tabuleiro (variável i usada como contador).
                //verifica se as 3 células em cada coluna têm o símbolo do jogador atual.
                // i representa a coluna que está sendo verificada.
                for (int i = 0; i < 3; i++) 
                {
                    if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador) 
                    {
                        return true;
                    }
                }

                // Verifica diagonal principal.
                // Verifica se as 3 células da diagonal principal têm o símbolo do jogador atual (seja "X" ou "O").
                //Se a condição é verdadeira, um jogador ganhou através da diagonal principal e a função retorna true.
                if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
                {
                    return true;
                }

                // Verifica diagonal secundária.
                // Verifica se as 3 células da diagonal secundária têm o símbolo do jogador atual (seja "X" ou "O").
                //Se a condição é verdadeira, um jogador ganhou através da diagonal principal e a função retorna true.
                if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
                {
                    return true;
                }
                return false;
            }
        }
    }
}