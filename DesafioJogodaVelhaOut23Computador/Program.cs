using System;

namespace JogoDaVelha
{
    internal class Program
    {
        public static void popularComVazio(char[,] matriz)
        {
            // Populando matriz com vazio
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = ' ';
                }
            }
        }

        public static void mostrarTabuleiro(char[,] matriz)
        {
            Console.Clear();
            Console.WriteLine(" Jogo da Velha\n");
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                Console.Write(" ");
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (coluna > 0)
                    {
                        Console.Write(" | ");
                    }

                    Console.Write(matriz[linha, coluna]);
                }
                Console.WriteLine();

                if (linha < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
            Console.WriteLine("\n");
        }

        public static bool validarPosicao(int linha, int coluna, char[,] matriz)
        {
            if (linha > 2 || linha < 0 || coluna > 2 || coluna < 0)
            {
                return false;
            }
            else
            {
                if (matriz[linha, coluna] == ' ')
                {
                    return true;
                }
                return false;
            }
        }

        public static bool verificarVitoria(char[,] matriz, char xOuBolinha)
        {
            if (xOuBolinha == 'X')
            {
                if (matriz[0, 0] == xOuBolinha && matriz[1, 0] == xOuBolinha && matriz[2, 0] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 1] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 1] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 2] == xOuBolinha && matriz[1, 2] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 0] == xOuBolinha && matriz[0, 1] == xOuBolinha && matriz[0, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[1, 0] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[1, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[2, 0] == xOuBolinha && matriz[2, 1] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 0] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 2] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 0] == xOuBolinha)
                {
                    return true;
                }
            }

            if (xOuBolinha == 'O')
            {
                if (matriz[0, 0] == xOuBolinha && matriz[1, 0] == xOuBolinha && matriz[2, 0] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 1] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 1] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 2] == xOuBolinha && matriz[1, 2] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 0] == xOuBolinha && matriz[0, 1] == xOuBolinha && matriz[0, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[1, 0] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[1, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[2, 0] == xOuBolinha && matriz[2, 1] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 0] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 2] == xOuBolinha)
                {
                    return true;
                }

                else if (matriz[0, 2] == xOuBolinha && matriz[1, 1] == xOuBolinha && matriz[2, 0] == xOuBolinha)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool verificarEmpate(char[,] matriz, bool boolVitoria) {

            int cont = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[linha,coluna] == 'X' || matriz[linha, coluna] == 'O'){
                        cont++;
                    }
                }
            }

            if(cont == 9 && boolVitoria == false) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void playGame(string j1, string j2, char[,] matriz)
        {
            popularComVazio(matriz);
            bool boolVitoria;

            while (true) {              

                while (true)
                {
                    
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" " + j1 + " digite a linha (0, 1 ou 2): ");
                    int linha = int.Parse(Console.ReadLine());
                    Console.WriteLine(" " + j1 + " digite a coluna (0, 1 ou 2): ");
                    int coluna = int.Parse(Console.ReadLine());
                    

                    if (validarPosicao(linha, coluna, matriz))
                    {
                        matriz[linha, coluna] = 'X';
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine(" Erro. Tente novamente!.");
                        Thread.Sleep(1000);
                    }
                }

                char xOuBolinha = 'X';
                if(verificarVitoria(matriz, xOuBolinha))
                {
                    Console.Clear();
                    Console.WriteLine();
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" PARABENS JOGADOR " + j1 + " VOCÊ GANHOU!!!!");
                    break;
                }

                else{ 
                    boolVitoria = false; 
                }

                if (verificarEmpate(matriz, boolVitoria)){
                    Console.WriteLine();
                    Console.WriteLine(" EMPATE!!!!!! ");
                    break;
                }
                
                while (true)
                {
                    
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" " + j2 + " digite a linha (0, 1 ou 2): ");                    
                    int linha = int.Parse(Console.ReadLine());

                    Console.WriteLine(" " + j2 + " digite a coluna (0, 1 ou 2): ");
                    int coluna = int.Parse(Console.ReadLine());
                    

                    if (validarPosicao(linha, coluna, matriz))
                    {
                        matriz[linha, coluna] = 'O';
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(" Erro. Tente novamente!");
                        Thread.Sleep(1000);
                    }
                }

                xOuBolinha = 'O';
                if (verificarVitoria(matriz, xOuBolinha))
                {
                    Console.Clear();
                    Console.WriteLine();
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" PARABÉNS JOGADOR " + j2 + " VOCÊ GANHOU!!!!");
                    break;
                }
                else
                {
                    boolVitoria = false;
                }

                if (verificarEmpate(matriz, boolVitoria))
                {
                    Console.WriteLine();
                    Console.WriteLine(" EMPATE!!!!!! ");
                    break;
                }

            }
        }

        public static void jogadaMaquina(char[,] matriz, int cont)
        {
            if (cont == 1){ matriz[1, 1] = 'X'; }

            if(cont == 2)
            {
                if (matriz[0, 0] == 'O'){ matriz[2, 2] = 'X'; }
                else if (matriz[2, 2] == 'O') { matriz[0, 0] = 'X'; }
                else if (matriz[0, 2] == 'O') { matriz[2, 0] = 'X'; }
                else if (matriz[2, 0] == 'O') { matriz[0, 2] = 'X'; }
                else if (matriz[1, 0] == 'O') { matriz[1, 2] = 'X'; }
                else if (matriz[1, 2] == 'O') { matriz[1, 0] = 'X'; }
                else if (matriz[0, 1] == 'O') { matriz[2, 1] = 'X'; }
                else if (matriz[2, 1] == 'O') { matriz[0, 1] = 'X'; }
            }


            if(cont >= 3)
            {
                
                if ((matriz[0,0] == 'O' && matriz[0,2] == 'O') && (matriz[0, 1] != 'O') && (matriz[0, 1] != 'X')) { matriz[0, 1] = 'X'; }
                else if ((matriz[2, 0] == 'O' && matriz[2, 2] == 'O') && (matriz[2, 1] != 'O') && (matriz[2, 1] != 'X')) { matriz[2, 1] = 'X'; }
                else if ((matriz[0, 0] == 'O' && matriz[2, 0] == 'O') && (matriz[1, 0] != 'O') && (matriz[1, 0] != 'X')){ matriz[1, 0] = 'X'; }
                else if ((matriz[0, 2] == 'O' && matriz[2, 2] == 'O') && (matriz[1, 2] != 'O') && (matriz[1, 2] != 'X')) { matriz[1, 2] = 'X'; }

                else if ((matriz[0, 2] == 'O' && matriz[1, 2] == 'O') && (matriz[2,2] != 'O') && (matriz[2, 2] != 'X')) { matriz[2, 2] = 'X'; }
                else if((matriz[1, 2] == 'O' && matriz[2, 2] == 'O') && (matriz[0,2] != 'O') && (matriz[0, 2] != 'X')) { matriz[0, 2] = 'X'; }

                else if ((matriz[0, 0] == 'O' && matriz[1, 0] == 'O') && (matriz[2, 0] != 'O') && (matriz[2, 0] != 'X')) { matriz[2, 0] = 'X'; }
                else if ((matriz[1, 0] == 'O' && matriz[2, 0] == 'O') && (matriz[0, 0] != 'O') && (matriz[0, 0] != 'X')) { matriz[0, 0] = 'X'; }

                else if ((matriz[0, 0] == 'O' && matriz[0, 1] == 'O') && (matriz[0, 2] != 'O') && (matriz[0, 2] != 'X')) { matriz[0, 2] = 'X'; }
                else if ((matriz[0, 1] == 'O' && matriz[0, 2] == 'O') && (matriz[0, 0] != 'O') && (matriz[0, 0] != 'X')) { matriz[0, 0] = 'X'; }

                else if ((matriz[2, 0] == 'O' && matriz[2, 1] == 'O') && (matriz[2, 2] != 'O') && (matriz[2, 2] != 'X')) { matriz[2, 2] = 'X'; }
                else if ((matriz[2, 1] == 'O' && matriz[2, 2] == 'O') && (matriz[2, 0] != 'O') && (matriz[2, 0] != 'X')) { matriz[2, 0] = 'X'; }

                else
                {
                    bool pararForExterno = false;
                    for (int linha = 0; linha < matriz.GetLength(0); linha++)
                    {

                        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                        {
                            if ( matriz[linha, coluna] == ' ' || matriz[linha, coluna] == '_') {
                                matriz[linha, coluna] = 'X';
                                pararForExterno = true;
                                break;
                            }
                        }

                        if (pararForExterno) { break; }
                    }
                }
            }
        }   

        public static void playGameCpu(string j1, char[,] matriz)
        {
            popularComVazio(matriz);
            bool boolVitoria;
            char xOuBolinha;
            int cont = 0;
            while (true) {
                cont++;

                Console.WriteLine();
                Console.WriteLine(" A máquina está jogando...");
                Thread.Sleep(2000);
                Console.Clear();
                jogadaMaquina(matriz, cont);

                xOuBolinha = 'X';
                if (verificarVitoria(matriz, xOuBolinha))
                {
                    Console.Clear();
                    Console.WriteLine();
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" VOCÊ PERDEU PARA A MÁQUINA!");
                    break;
                }
                else
                {
                    boolVitoria = false;
                }

                if (verificarEmpate(matriz, boolVitoria))
                {
                    Console.WriteLine();
                    Console.WriteLine(" EMPATE!!!!!! ");
                    break;
                }

                while (true)
                {

                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" " + j1 + " digite a linha (0, 1 ou 2): ");
                    int linha = int.Parse(Console.ReadLine());
                    Console.WriteLine(" " + j1 + " digite a coluna (0, 1 ou 2): ");
                    int coluna = int.Parse(Console.ReadLine());


                    if (validarPosicao(linha, coluna, matriz))
                    {
                        matriz[linha, coluna] = 'O';
                        break;
                    }
                    else
                    {

                        Console.WriteLine();
                        Console.WriteLine(" Erro. Tente novamente!");
                        Thread.Sleep(1000);
                    }
                }


                xOuBolinha = 'O';
                if (verificarVitoria(matriz, xOuBolinha))
                {
                    Console.Clear();
                    Console.WriteLine();
                    mostrarTabuleiro(matriz);
                    Console.WriteLine();
                    Console.WriteLine(" PARABÉNS JOGADOR " + j1 + " VOCÊ GANHOU!!!!");
                    break;
                }
                else
                {
                    boolVitoria = false;
                }

                if (verificarEmpate(matriz, boolVitoria))
                {
                    Console.WriteLine();
                    Console.WriteLine(" EMPATE!!!!!! ");
                    break;
                }


            }

        }
        static void Main(string[] args)
        {
            char[,] tabuleiro = new char[3, 3];
            char opcao, opcaoReniciar;
            bool sair = false;
            string j1, j2;


            while(sair == false) {
                
                Console.WriteLine(" -------------");
                Console.WriteLine(" JOGO DA VELHA");
                Console.WriteLine(" -------------");
                Console.WriteLine("");

                Console.WriteLine(" Digite 1 - Jogador 1 VS Jogador 2");
                Console.WriteLine(" Digite 2 - Jogador 1 VS Computador");
                Console.WriteLine(" Digite 3 - Sair");
                Console.WriteLine("");

                Console.WriteLine(" Selecione uma das opções:");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        while (true) {
                            Console.Clear();

                            Console.WriteLine(" Jogador 1, você jogará com o (X), digite seu nome: ");
                            j1 = Console.ReadLine();
                            Console.Clear();


                            Console.WriteLine(" Jogador 2, você jogará com o (O) digite seu nome: ");
                            j2 = Console.ReadLine();
                            Console.Clear();

                            
                            
                            playGame(j1,j2,tabuleiro);

                            Console.WriteLine();
                            Console.WriteLine(" Digite (1) para reiniciar ou qualquer caracter para sair: ");
                            Console.WriteLine("");
                            opcaoReniciar = char.Parse(Console.ReadLine());
                            
                            if (opcaoReniciar != '1') {
                                Console.Clear();
                                break;
                            }
                            
                        }
                        
                        break;

                    case '2':
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine(" Jogador 1, você jogará com o (O), digite seu nome: ");
                            j1 = Console.ReadLine();
                            Console.Clear();

                            playGameCpu(j1, tabuleiro);

                            Console.WriteLine();
                            Console.WriteLine(" Digite (1) para reiniciar ou qualquer caracter para sair: ");
                            Console.WriteLine("");
                            opcaoReniciar = char.Parse(Console.ReadLine());

                            if (opcaoReniciar != '1')
                            {
                                Console.Clear();
                                break;
                            }

                        }
                        break;

                    case '3':
                        sair = true;
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Obrigado!");
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(" Opção inválida. Tente novamente!");
                        Console.WriteLine("");
                        break;
                }

                
            }
        }
    }
}
