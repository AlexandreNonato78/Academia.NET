namespace _061023_exercicioRepeticao_pt2_4;
//4. Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA.
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
//de votos em branco.
using System;

class Program
{
    static void Main()
    {
        int votosJoao = 0;
        int votosZeca = 0;
        int votosBranco = 0;

        while (true)
        {
            Console.Write("Digite o voto (JOAO, ZECA, BRANCO, ou FIM para encerrar): ");
            string voto = Console.ReadLine().ToUpper(); // Converte o voto para maiúsculas para evitar diferenciação de caixa.

            if (voto == "FIM")
            {
                break; // Sai do loop quando o usuário digitar "FIM".
            }
            else if (voto == "JOAO")
            {
                votosJoao++;
            }
            else if (voto == "ZECA")
            {
                votosZeca++;
            }
            else if (voto == "BRANCO")
            {
                votosBranco++;
            }
            else
            {
                Console.WriteLine("Voto inválido. Tente novamente.");
            }
        }

        Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
        Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
    }
}
