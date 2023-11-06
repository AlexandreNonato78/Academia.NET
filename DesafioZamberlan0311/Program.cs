using System;

namespace DesafioAmigoSecreto
{
    class Amigo
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome};{Email}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Amigo other = (Amigo)obj;
            return Nome == other.Nome && Email == other.Email;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() ^ Email.GetHashCode();
        }
    }

    class Program
    {
        static List<Amigo> amigos = new List<Amigo>();
        static List<Amigo> amigosSecretos = new List<Amigo>();

        static void Main(string[] args)
        {
            CarregarAmigos();
            int opcao;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastrar amigo");
                Console.WriteLine("2. Listar amigos");
                Console.WriteLine("3. Gerar amigo secreto");
                Console.WriteLine("4. Gerar arquivo de amigos");
                Console.WriteLine("5. Gerar arquivo de amigos secretos");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarAmigo();
                            break;
                        case 2:
                            ListarAmigos();
                            break;
                        case 3:
                            GerarAmigoSecreto();
                            break;
                        case 4:
                            GerarArquivoAmigos();
                            break;
                        case 5:
                            GerarArquivoAmigosSecretos();
                            break;
                        case 6:
                            SalvarAmigos();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            } while (opcao != 6);
        }

        static void CadastrarAmigo()
        {
            Console.Write("Digite o nome do amigo: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do amigo: ");
            string email = Console.ReadLine();

            if (AmigoJaCadastrado(nome, email))
            {
                Console.WriteLine("Nome ou email já cadastrado. Não é permitido duplicações.");
            }
            else
            {
                Amigo amigo = new Amigo(nome, email);
                amigos.Add(amigo);
                Console.WriteLine("Amigo cadastrado com sucesso!");
            }
        }

        static bool AmigoJaCadastrado(string nome, string email)
        {
            return amigos.Any(a => a.Nome == nome || a.Email == email);
        }

        static void ListarAmigos()
        {
            Console.WriteLine("Lista de amigos:");
            foreach (var amigo in amigos)
            {
                Console.WriteLine(amigo);
            }
        }

        static void GerarAmigoSecreto()
        {
            if (amigos.Count < 3)
            {
                Console.WriteLine("É necessário ter pelo menos 3 amigos para gerar o amigo secreto.");
                return;
            }

            amigosSecretos.Clear();
            List<Amigo> amigosNaoSorteados = amigos.ToList();
            Random random = new Random();

            foreach (var amigo in amigos)
            {
                Amigo amigoSecreto;
                do
                {
                    amigoSecreto = amigosNaoSorteados[random.Next(amigosNaoSorteados.Count)];
                } while (amigo.Equals(amigoSecreto));

                amigosNaoSorteados.Remove(amigoSecreto);
                amigosSecretos.Add(amigoSecreto);
                Console.WriteLine($"{amigo.Nome} tirou {amigoSecreto.Nome} como amigo secreto.");
            }
        }

        static void CarregarAmigos()
        {
            if (File.Exists("amigos.csv"))
            {
                using (StreamReader reader = new StreamReader("amigos.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] data = reader.ReadLine().Split(';');
                        if (data.Length == 2)
                        {
                            amigos.Add(new Amigo(data[0], data[1]));
                        }
                    }
                }
            }
        }

        static void SalvarAmigos()
        {
            using (StreamWriter writer = new StreamWriter("amigos.csv"))
            {
                foreach (var amigo in amigos)
                {
                    writer.WriteLine(amigo);
                }
            }

            using (StreamWriter writer = new StreamWriter("secretos.csv"))
            {
                for (int i = 0; i < amigos.Count; i++)
                {
                    writer.WriteLine($"{amigos[i]};{amigosSecretos[i]}");
                }
            }
        }

        static void GerarArquivoAmigos()
        {
            using (StreamWriter writer = new StreamWriter("amigos.csv"))
            {
                foreach (var amigo in amigos)
                {
                    writer.WriteLine(amigo);
                }
                Console.WriteLine("Arquivo amigos.csv gerado com sucesso!");
            }
        }

        static void GerarArquivoAmigosSecretos()
        {
            using (StreamWriter writer = new StreamWriter("secretos.csv"))
            {
                for (int i = 0; i < amigos.Count; i++)
                {
                    writer.WriteLine($"{amigos[i]};{amigosSecretos[i]}");
                }
                Console.WriteLine("Arquivo secretos.csv gerado com sucesso!");
            }
        }
    }
}
