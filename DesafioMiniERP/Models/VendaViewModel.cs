namespace MiniERP.Models
{
    internal class VendaViewModel
    {
        public int VendaId { get; set; }
        public string Data { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string NomeCliente { get; set; }
        public string NomeProduto { get; set; }

        public decimal TotalAPagar
        { 
            get
            {
                if (Preco == 0 || Quantidade == 0) return 0;    
                return Preco * Quantidade;
            }
        
        }
    }
}