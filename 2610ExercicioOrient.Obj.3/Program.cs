using System;
//3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
//Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
//Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.
//Insira os imoveis numa lista para facilitar o trabalho.


namespace ExercicioCorretoraDeImoveis
{
    class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImóveis corretora = new CorretoraDeImóveis();

            while (true)
            {
                Console.WriteLine("===== Menu da Corretora de Imóveis =====");
                Console.WriteLine("1 - Inserir Imóvel");
                Console.WriteLine("2 - Alterar Preço de Imóvel");
                Console.WriteLine("3 - Listar Imóveis Disponíveis");
                Console.WriteLine("4 - Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Endereço do Imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do Imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do Imóvel: ");
                        string tipo = Console.ReadLine();

                        Imovel novoImovel = new Imovel(endereco, preco, tipo);
                        corretora.InserirImovel(novoImovel);
                        break;

                    case 2:
                        Console.Write("Endereço do Imóvel a ser alterado: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Novo Preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPrecoImovel(enderecoAlterar, novoPreco);
                        break;

                    case 3:
                        corretora.ListarImoveis();
                        break;

                    case 4:
                        double valorMedio = corretora.CalcularValorMédio();
                        Console.WriteLine("O valor médio dos imóveis é: " + valorMedio);
                        break;

                    case 5:
                        Console.WriteLine("Saindo do programa.");
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
