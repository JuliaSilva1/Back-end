namespace Models
{
     public class pedidos{
        public int id_pedidos { get; set; }
        private int qtdProdutos{ get; set; }
        private string nome {get; set;}
        private decimal total {get; set;}
         public pedidos (int qtdProdutos, string nome , decimal total)
        {
         this.qtdProdutos=qtdProdutos;
         this.nome = nome;
         this.total = total;
        }

    }
}