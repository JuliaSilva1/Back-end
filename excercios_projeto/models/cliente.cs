namespace Models
{
    public class cliente{
        public int id_cliente { get; set; }
        private string nome { get; set; }
        private int datadeNascimento { get; set;}
        private string email { get; set; }
        private int senha { get; set; }
        private int confirmar { get; set; }

         public cliente (string nome, string cpf, string datadeNascimento, string email, int senha, int confirmar)
        {
           this.nome = nome;
           this.datadeNascimento = datadeNascimento;
           this.email = email;
           this.senha = senha;
           this.confirmar = confirmar;
        }

    }
}