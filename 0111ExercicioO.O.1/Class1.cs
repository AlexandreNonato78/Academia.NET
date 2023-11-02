using System;

namespace ExercicioFabricanteProduto
{
    class Fabricante
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nome = value;
                else
                    Console.WriteLine("O nome do fabricante não pode ser vazio.");
            }
        }

        public string Endereço { get; set; }
        public string Cidade { get; set; }
    }

    class Produto
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nome = value;
                else
                {
                    Console.WriteLine("O nome do produto não pode ser vazio.");
                    return;
                }
            }
        }

        public Fabricante Fabricante { get; set; }

        private double preco;
        public double Preço
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                    preco = value;
                else
                {
                    Console.WriteLine("O preço do produto deve ser positivo.");
                    return;
                }
            }
        }
    }
}
