using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWindowsForms2
{
    internal class Amigo
    {
        string nome;
        string email;

        public Amigo(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }

        public static bool amigoCadastrado(string nome, List<Amigo>lista)
        {
            foreach (Amigo i in lista) 
            {
                if (nome.Equals(i.Nome)) 
                {
                    return true;
                }                  
            }
            return false; //amigo não localizado na lista
        }
    }

}
