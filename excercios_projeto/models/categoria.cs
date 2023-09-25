namespace Models
{
     public class categoria{
        public int id_categoria { get; set; }
        private string nomedaCategoria { get; set; }
       
         public categoria (string nomedaCategoria )
        {
          this.nomedaCategoria = nomedaCategoria
        }

    }
}