namespace _2510ExercicioO.O._2
//2 - Crie uma classe "Estúdio" com os seguintes atributos:
//Nome, Ano de fundação, País de origem e Número de jogos produzidos.
//Na main, instancie um objeto e faça a leitura pelo teclado.
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do estúdio:");

            Estudio meuEstudio = new Estudio(); // Instanciar um objeto da classe Estudio

            Console.Write("Nome do estúdio: ");
            meuEstudio.Nome = Console.ReadLine();

            Console.Write("Ano de fundação: ");
            if (int.TryParse(Console.ReadLine(), out int anoFundacao))
            {
                meuEstudio.AnoFundacao = anoFundacao;
            }
            else
            {
                Console.WriteLine("Ano de fundação inválido.");
            }

            Console.Write("País de origem: ");
            meuEstudio.PaisOrigem = Console.ReadLine();

            Console.Write("Número de jogos produzidos: ");
            if (int.TryParse(Console.ReadLine(), out int numJogosProduzidos))
            {
                meuEstudio.NumeroJogosProduzidos = numJogosProduzidos;
            }
            else
            {
                Console.WriteLine("Número de jogos produzidos inválido.");
            }

            Console.WriteLine("\nDados do estúdio informados:");
            Console.WriteLine("Nome do estúdio: " + meuEstudio.Nome);
            Console.WriteLine("Ano de fundação: " + meuEstudio.AnoFundacao);
            Console.WriteLine("País de origem: " + meuEstudio.PaisOrigem);
            Console.WriteLine("Número de jogos produzidos: " + meuEstudio.NumeroJogosProduzidos);
        }
    }

}