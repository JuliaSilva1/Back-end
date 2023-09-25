// sempre que formos utilizar bibliotecas ou classes já criadas 
// importamos ela com o using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma variavel aluno1 e instanciando da classe aluno
        //ou seja, estamos criando nosso objeto
       var aluno1 = new Aluno();
       //atribuindo um valor ao atributo nome do aluno1
       aluno1.nome = "Julia";
       aluno1.idade = 16;
       aluno1.turma = "2°EM";
       //chamando o metado da classe aluno
       aluno1.Apresentar();
       aluno1.ResumirFaltas();
       aluno1.AdicionarFaltas(10);
       aluno1.ResumirFaltas();
       aluno1.AdicionarFaltas(7);
       aluno1.ResumirFaltas();
       aluno1.JustificarFaltas();
       aluno1.ResumirFaltas();


       var aluno2 = new Aluno();
       aluno2.nome = "Giovana";
       aluno2.idade = 17;
       aluno2.turma = "2°EM";
       aluno2.Apresentar();


    }
}