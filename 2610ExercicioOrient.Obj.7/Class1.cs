namespace _2610ExercicioOrient.Obj._7
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(int codigo, string nome, double preco, int quantidadeEstoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}
