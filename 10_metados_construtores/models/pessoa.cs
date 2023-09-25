namespace Models
{
    public class Pessoa 
    {
        //atributos da nossa classe pessoa
       private string nome { get; set; }
       private int idade { get; set;}
       private string email { get; set; }
       private int anoNascimento { get; set; }

       //metado construtor da classe pessoa
       public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
       {
         this.nome = nomePessoa;
         this.idade = idadePessoa;
         this.email = emailPessoa;
         this.anoNascimento = DateTime.Now.Year - idadePessoa;
       }

        //metado da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes(){
            Console.WriteLine($"{nome} tem {idade} o seu email {email} e nasceu em {anoNascimento}");
        }
    }
}