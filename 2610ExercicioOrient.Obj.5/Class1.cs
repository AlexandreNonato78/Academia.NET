using System;

namespace _2610ExercicioOrient.Obj._5
{
    class Música
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Música(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    class Playlist
    {
        public string Dono { get; set; }
        private List<Música> músicas;
        private Random random;

        public Playlist(string dono)
        {
            Dono = dono;
            músicas = new List<Música>();
            random = new Random();
        }

        public void AdicionarMúsica(Música música)
        {
            músicas.Add(música);
        }

        public void TocarMúsicaAleatória()
        {
            if (músicas.Count > 0)
            {
                int índiceAleatório = random.Next(0, músicas.Count);
                Música músicaTocada = músicas[índiceAleatório];
                Console.WriteLine("Tocando a música: " + músicaTocada.Nome);
            }
            else
            {
                Console.WriteLine("Playlist vazia. Adicione músicas antes de tentar tocá-las.");
            }
        }
    }
}
