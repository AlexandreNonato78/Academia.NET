using System;
using System.Collections.Generic;

namespace _0111ExercicioO.O._5
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }
    }

    class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = nome,
                Idade = idade,
                Altura = altura
            };
            pessoas.Add(pessoa);
        }

        public void RemovePessoa(string nome)
        {
            pessoas.RemoveAll(p => p.Nome == nome);
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("\n===== Agenda de Pessoas =====");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}

