using _2811Aula.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811Aula
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionStringSettings settings =
            //        ConfigurationManager.ConnectionStrings["aulaentity"];

            //string retorno = "";

            //if (settings != null)
            //    retorno = settings.ConnectionString;

            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=_2811aula; User ID=_2811aulab; password=senha1234;language=Portuguese");
            //optionsBuilder.UseSqlServer(retorno);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);

        }

    }

}
