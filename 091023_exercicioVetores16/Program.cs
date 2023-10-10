namespace _091023_exercicioVetores16;

//16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.
//Crie, a seguir, um vetor para cada uma das operações:
//•	A união de X com Y
//•	A diferença entre X e Y
//•	A interseção entre X e Y
//Escreva o vetor resultado de cada uma das operações.

using System;

// SEGUNDA TENTATIVA - VERSAO2

class Program
{
    static void Main()
    {
        int[] x = new int[4] { 0, 1, 2, 3 };
        int[] y = new int[4] { 3, 4, 5, 2 };

        int[] uniao = new int[8];
        int[] diferenca = new int[4];
        int[] interseccao = new int[4];

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine("X[" + i + "] = " + x[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < y.Length; i++)
        {
            Console.WriteLine("Y[" + i + "] = " + y[i]);
        }

        Console.WriteLine();

        //UNIÃO 
        x.CopyTo(uniao, 0);

        int aux = 4;

        for (int i = 0; i < y.Length; i++)
        {
            for (int j = 0; j < x.Length; j++)
            {
                if (y[i] == x[j])
                {
                    break;
                }

                if (j == (x.Length - 1))
                {
                    uniao[aux] = y[i];
                    aux++;
                }
            }
        }

        for (int i = 0; i < aux; i++)
        {
            Console.WriteLine("união[" + i + "] = " + uniao[i]);
        }

        //DIFERENÇA
        Console.WriteLine();

        int aux2 = 0;

        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < y.Length; j++)
            {
                if (x[i] == y[j])
                {
                    break;
                }

                if (j == (y.Length - 1))
                {
                    diferenca[aux2] = x[i];
                    aux2++;
                }
            }
        }

        for (int i = 0; i < aux2; i++)
        {
            Console.WriteLine("Diferença[" + i + "] = " + diferenca[i]);
        }

        Console.WriteLine();


        //INTERSECÇÃO

        int aux3 = 0;

        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < y.Length; j++)
            {
                if (x[i] == y[j])
                {
                    interseccao[aux3] = x[i];
                    aux3++;
                    break;
                }
            }
        }

        for (int i = 0; i < aux3; i++)
        {
            Console.WriteLine("Intersecção[" + i + "] = " + interseccao[i]);
        }
    }
}



// PRIMEIRA TENTATIVA - VERSAO1


//        int[] X = new int[10];
//        int[] Y = new int[10];

//        // Leitura dos valores para os vetores X e Y
//        Console.WriteLine("Digite 10 números para o vetor X:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Digite o {i + 1}º número para X: ");
//            X[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nDigite 10 números para o vetor Y:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Digite o {i + 1}º número para Y: ");
//            Y[i] = int.Parse(Console.ReadLine());
//        }

//        // União de X e Y
//        int[] uniao = new int[20];
//        for (int i = 0; i < 10; i++)
//        {
//            uniao[i] = X[i];
//            uniao[i + 10] = Y[i];
//        }

//        // Diferença entre X e Y
//        int[] diferenca = new int[10];
//        int indiceDiferenca = 0;
//        for (int i = 0; i < 10; i++)
//        {
//            bool pertenceY = false;
//            for (int j = 0; j < 10; j++)
//            {
//                if (X[i] == Y[j])
//                {
//                    pertenceY = true;
//                    break;
//                }
//            }
//            if (!pertenceY)
//            {
//                diferenca[indiceDiferenca] = X[i];
//                indiceDiferenca++;
//            }
//        }

//        // Interseção entre X e Y
//        int[] intersecao = new int[10];
//        int indiceIntersecao = 0;
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (X[i] == Y[j])
//                {
//                    intersecao[indiceIntersecao] = X[i];
//                    indiceIntersecao++;
//                    break;
//                }
//            }
//        }

//        // Mostrar os vetores resultantes
//        Console.WriteLine("\nUnião de X e Y:");
//        MostrarVetor(uniao);

//        Console.WriteLine("\nDiferença entre X e Y (X - Y):");
//        MostrarVetor(diferenca);

//        Console.WriteLine("\nInterseção entre X e Y:");
//        MostrarVetor(intersecao);
//    }

//    static void MostrarVetor(int[] vetor)
//    {
//        foreach (int numero in vetor)
//        {
//            Console.Write(numero + " ");
//        }
//        Console.WriteLine();
//    }
//}
