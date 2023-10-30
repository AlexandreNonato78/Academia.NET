using System;
//Exercicio 1 - Crie uma classe chamada Pessoa com seus atributos conforme sua preferência
//(Digite: Nome, CPF, data de nascimento, RG etc). Crie métodos para cadastrar e apresentar na tela os dados desta classe.
class Pessoa
{
    // Atributos da classe Pessoa
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string RG { get; set; }

    // Método para cadastrar os dados da Pessoa
    public void CadastrarPessoa(string nome, string cpf, DateTime dataNascimento, string rg)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        RG = rg;
    }

    // Método para apresentar os dados da Pessoa na tela
    public void ApresentarDados()
    {
        Console.WriteLine("Dados da Pessoa:");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + CPF);
        Console.WriteLine("Data de Nascimento: " + DataNascimento.ToShortDateString());
        Console.WriteLine("RG: " + RG);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciar um objeto da classe Pessoa
        Pessoa pessoa = new Pessoa();

        // Solicitar ao usuário que insira os dados da Pessoa
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Data de Nascimento (yyyy-MM-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
        {
            Console.Write("RG: ");
            string rg = Console.ReadLine();

            // Chamar o método para cadastrar os dados
            pessoa.CadastrarPessoa(nome, cpf, dataNascimento, rg);

            // Chamar o método para apresentar os dados
            pessoa.ApresentarDados();
        }
        else
        {
            Console.WriteLine("Data de Nascimento inválida.");
        }
    }
}
