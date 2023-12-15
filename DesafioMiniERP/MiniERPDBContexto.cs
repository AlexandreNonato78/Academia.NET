using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniERP.Models;

namespace MiniERP
{
  
    public class MiniERPDBContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get;set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MiniERP;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-J8B2L40;Database=MiniERP;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J8B2L40; Initial Catalog=MiniERP; User ID=minierp4; Password=Senha1234; Integrated Security=False; TrustServerCertificate=True");
            //"Data Source=DESKTOP-J8B2L40; Initial Catalog=MiniERP; User ID=minierp4; Password=Senha1234; Integrated Security=False;TrustServerCertificate=True");

        }
    }
}
