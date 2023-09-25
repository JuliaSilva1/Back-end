using Models;

public class Program
{
    public static void Main()
    {
        //criando um objeto da classe pessoa
        //instanciando sem um metado construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Julia";
        pessoa1.idade = 16;
        pessoa1.Cantar();


        //alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
          nome = "Ricardo",
          idade = 22
    };
     pessoa2.Cantar();
     */
     Pessoa pessoa1 = new Pessoa("Julia", 16, "julia.oliveira@senai.br");
     pessoa1.Cantar();
     pessoa1.Informacoes();

     Pessoa pessoa2 = new Pessoa("Giovana", 25, "giovana.venancio@senai.br");
     pessoa2.Cantar();
     pessoa2.Informacoes();

     Pessoa pessoa3 = new Pessoa("Clara", 18, "clara.sangali@senai.br");
     pessoa3.Cantar();
     pessoa3.Informacoes();

    }
}