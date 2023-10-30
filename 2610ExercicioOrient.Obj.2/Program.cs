namespace _2610ExercicioOrient.Obj._2;
//2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras(data, produto, valor).
//Implemente um construtor e métodos para adicionar e listar compras.


using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe os dados do Produto:");

        RegistroDeCompras meuRegistro = new RegistroDeCompras(); // Instanciar um objeto da classe Estudio

        Console.Write("Nome do Produto: ");
        meuRegistro.Produto = Console.ReadLine();

        // Solicita a data no formato "dd/mm/aa"
        Console.Write("Informe a data da compra (dd/mm/aaaa): ");
        string dataInput = Console.ReadLine();

        // Define o formato esperado da data
        string formatoData = "dd/MM/yyyy";

        // Tenta analisar a entrada do usuário no formato especificado
        if (DateTime.TryParseExact(dataInput, formatoData, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
        {
            Console.WriteLine("Data válida: " + data.ToString("dd/MM/yyyy"));
            meuRegistro.DataVenda = data;
        }
        else
        {
            Console.WriteLine("Data inválida. Certifique-se de inserir a data no formato dd/mm/aaaa.");
        }

        Console.Write("Preço do Produto: ");
        if (double.TryParse(Console.ReadLine(), out double Preco))
        {
            meuRegistro.Preco = Preco;
        }
        else
        {
            Console.WriteLine("Preço inválido.");
        }
        Console.WriteLine("\nDados informados no Registro de Compras:");
         Console.WriteLine("Nome do Produto: " + meuRegistro.Produto);
         Console.WriteLine("Preço do Produto: " + meuRegistro.Preco);
         Console.WriteLine("Data da Venda do Produto: " + meuRegistro.DataVenda.ToString("dd/MM/yyyy"));
        
    }

}