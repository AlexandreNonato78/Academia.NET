namespace _061023_exercicioRepeticao_pt2_5;
//5. Modifique o programa em VS anterior para aceitar votos nulos
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos
//e o número de pessoas que votaram.
 
using System;

class Program
{
    static void Main()
    {
        int votosJoao = 0;
        int votosZeca = 0;
        int votosBranco = 0;
        int votosNulos = 0;
        int totalVotos = 0;

        while (true)
        {
            Console.Write("Digite o voto (JOAO, ZECA, BRANCO, NULO, ou FIM para encerrar): ");
            string voto = Console.ReadLine().ToUpper();

            if (voto == "FIM")
            {
                break;
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
            else if (voto == "NULO")
            {
                votosNulos++;
            }
            else
            {
                Console.WriteLine("Voto inválido. Tente novamente.");
            }

            totalVotos++;
        }

        Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
        Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
        Console.WriteLine($"Total de votos nulos: {votosNulos}");
        Console.WriteLine($"Total de pessoas que votaram: {totalVotos}");

        // Determinar o candidato vencedor
        string vencedor;
        if (votosJoao > votosZeca)
        {
            vencedor = "JOAO";
        }
        else if (votosZeca > votosJoao)
        {
            vencedor = "ZECA";
        }
        else
        {
            vencedor = "Empate";
        }

        Console.WriteLine($"Candidato vencedor: {vencedor}");
    }
}
