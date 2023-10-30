using System;
using System.Collections.Generic;

namespace ExercicioAgendaTelefonica
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    class AgendaTelefônica
    {
        // Atributos da classe
        private List<Contato> contatos;

        // Construtor
        public AgendaTelefônica()
        {
            contatos = new List<Contato>();
        }

        // Método para adicionar um contato
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        // Método para remover um contato
        public void RemoverContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        // Método para buscar um contato
        public Contato BuscarContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            return contato;
        }
    }
}
