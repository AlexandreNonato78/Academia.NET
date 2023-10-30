using System;
using System.Collections.Generic;

namespace ExercicioCorretoraDeImoveis
{
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }
    class CorretoraDeImóveis
    {
        // Atributos da classe
        private List<Imovel> imoveis;

        // Construtor
        public CorretoraDeImóveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para inserir um imóvel
        public void InserirImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPrecoImovel(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.Find(i => i.Endereco == endereco);
            if (imovel != null)
            {
                imovel.Preco = novoPreco;
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine("Endereço: " + imovel.Endereco);
                Console.WriteLine("Preço: " + imovel.Preco);
                Console.WriteLine("Tipo: " + imovel.Tipo);
                Console.WriteLine("==============================");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMédio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }

            double total = 0;
            foreach (Imovel imovel in imoveis)
            {
                total += imovel.Preco;
            }

            return total / imoveis.Count;
        }
    }
}
