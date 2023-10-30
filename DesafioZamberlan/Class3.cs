namespace _2_Padel;

public class Comunicacao
{
    public static void cadastrarAtleta(List<Atleta> lista)
    {
        string nome;
        string email;
        DateOnly dataNascimento;
        string posicao;
        string categoria;

        Console.Write("Informe o email: ");
        email = Console.ReadLine();

        //lista de atletas
        //[{nome,email,dataNascimento,posicao,categoria}, {}, {}, {}]
        if (Atleta.estaContido(email, lista))
        {
            Console.WriteLine("Email já utilizado no sistema!!");
        }
        else
        {
            //pedir o restante dos dados
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Data nascimento [dd/mm/aaaa]: ");
            dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write("Posição na quadra [direita ou esquerda]: ");
            posicao = Console.ReadLine();
            Console.Write("Categoria [1 ou 2 ou 3 ou 4 ou 5]: ");
            categoria = Console.ReadLine();

            //instanciar um objeto atleta
            Atleta atleta = new Atleta(nome, email, dataNascimento, posicao, categoria);

            //adicionar na lista
            lista.Add(atleta);
        }
    }

    public static void listarAtletas(List<Atleta> lista)
    {
        foreach (var atleta in lista)
        {
            Console.WriteLine(atleta.sobrenome() + " - " + atleta.PosicaoQuadra + " - " + atleta.Categoria);
        }
    }
    public static void cadastrarTreinador(List<Treinador> lista)
    {
        string nomeTreinador;
        string clube;

        Console.Write("Nome do Treinador: ");
        nomeTreinador = Console.ReadLine();
        Console.Write("Clube: ");
        clube = Console.ReadLine();

        Treinador treinador = new Treinador(nomeTreinador, clube);
        lista.Add(treinador);
    }

    public static void listarTreinadores(List<Treinador> lista)
    {
        foreach (var treinador in lista)
        {
            Console.WriteLine(treinador.NomeTreinador + " - " + treinador.Clube);
        }
    }

    public static void removerAtleta(List<Atleta> lista, string email)
    {
        // Verifica se o atleta com o email especificado está na lista.
        Atleta atletaParaRemover = lista.Find(a => a.Email == email);

        if (atletaParaRemover != null)
        {
            lista.Remove(atletaParaRemover);
            Console.WriteLine("Atleta removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Atleta não encontrado na lista.");
        }
    }

    public static void removerTreinador(List<Treinador> lista, string nomeTreinador)
    {
        // Verifica se o treinador com o nome especificado está na lista.
        Treinador treinadorParaRemover = lista.Find(t => t.NomeTreinador == nomeTreinador);

        if (treinadorParaRemover != null)
        {
            lista.Remove(treinadorParaRemover);
            Console.WriteLine("Treinador removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Treinador não encontrado na lista.");
        }
    }
}