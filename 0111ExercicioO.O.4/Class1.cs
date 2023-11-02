using System;

namespace _0111ExercicioO.O._4
{
    class Carro
    {
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    modelo = value;
                else
                    Console.WriteLine("O modelo do carro não pode ser vazio.");
            }
        }

        private int ano;
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value >= 0)
                    ano = value;
                else
                    Console.WriteLine("O ano do carro deve ser um número positivo.");
            }
        }

        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
            set
            {
                velocidade = Math.Max(value, 0); // Garante que a velocidade nunca seja negativa
            }
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            Velocidade -= 10;
        }
    }
}
