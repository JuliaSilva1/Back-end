namespace Models
{
     public class produtos{
        public int id_produtos { get; set; }
        private string nomedoProduto { get; set; }
        private decimal preco { get; set; }
        private string imagem { get; set; }
        private string descricao { get; set; }
    

         public produtos (string nomedoProduto, decimal preco, string imagem, string descricao)
        {
          this.nomedoPedido = nomedoProduto;
          this.preco = preco;
          this.imagem = imagem;
          this.descricao = descricao;
        }

    }
}