namespace _061023_exercicioRepeticao_pt2_20;
//20. Foi realizada uma pesquisa de algumas características físicas da população de uma
//certa região, a qual coletou os seguintes dados referentes a cada habitante para serem analisados:
//- sexo(masculino e feminino)
//- cor dos olhos(azuis, verdes ou castanhos)
//- cor dos cabelos(louros, castanhos, pretos)
//- idade

//Faça um algoritmo que determine e escreva:
//- a maior idade dos habitantes
//- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros.
//O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

using System;

class Program
{
    static void Main()
    {
        int sexo;
        int maiorIdade = 0, idade;
        int corOlhos; //0 = azul, 1 = verde, 2 = castanhos
        int corCabelo; //0 = loiro, 1 = castanho, 2 = preto
        int op = -1;
        int contagem = 0;

        do
        {

            Console.WriteLine("CADASTRO DE INDIVÍDUOS");
            Console.WriteLine("Digite o sexo da pessoa (0 - feminino e 1 para Masculino) : ");
            sexo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cor dos olhos (0 = azul, 1 = verde, 2 = castanhos):");
            corOlhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cor dos cabelos 0 = loiro, 1 = castanho, 2 = preto:");
            corCabelo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade > maiorIdade)
            {
                maiorIdade = idade;
            }

            if (sexo == 0 && (idade > 18 && idade < 35)
                && corOlhos == 1 && corCabelo == 0)
            {
                contagem++;
            }

            Console.WriteLine("Informe -1 para encerrar ou quqlquer outro valor para continuar");
            op = int.Parse(Console.ReadLine());

        } while (op != -1);

        Console.WriteLine("A pessoa mais velha possui " +
            maiorIdade + " anos e existem " + contagem +
            " mulheres com idade entre 18 e 35 com olhos " +
            "verdes e cabelos louros.");
    }
}
