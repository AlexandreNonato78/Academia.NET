using System;

namespace _0111ExercicioO.O._3
{
    class Animal
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
                    Console.WriteLine("O nome do animal não pode ser vazio.");
            }
        }

        private string espécie;
        public string Espécie
        {
            get { return espécie; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    espécie = value;
                else
                    Console.WriteLine("A espécie do animal não pode ser vazia.");
            }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                    idade = value;
                else
                    Console.WriteLine("A idade do animal deve ser um número positivo.");
            }
        }

        public void EmitirSom(string som)
        {
            Console.WriteLine("O som do animal é: " + som);
        }
    }
}
