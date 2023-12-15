using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }      
        public int Quantidade { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public decimal Preco { get; set; }       

    }
}


